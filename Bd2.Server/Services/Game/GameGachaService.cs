using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using Google.Protobuf.Collections;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameGachaService : IGameGachaService
{
	private readonly ILogger<GameGachaService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public GameGachaService(ISqlSugarClient db, ILogger<GameGachaService> logger, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
	}

	public async Task<GameActionResult> GachaInfo()
	{
		var response = new GachaInfoResponse();
		// 客户端 RawDataManager 使用 SQLite 行主键查表；当前 common 的 ProtoBuf
		// 字段布局由 GachaDesignManager 兼容解析，不能使用旧生成类的字段号。
		var gachaIds = GachaDesignManager.LoadGachaIds();
		var groups = GachaDesignManager.LoadGroups();
		var scheduleConfigs = await _db.Queryable<GachaScheduleConfigDao>().ToListAsync();
		var scheduleByGroup = scheduleConfigs.GroupBy(x => x.GachaGroupRowId).ToDictionary(x => x.Key, x => x.OrderByDescending(v => v.UpdatedAt).First());
		var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		var end = now + 365L * 24 * 60 * 60 * 1000;
		var validGroups = groups
			.Where(x => x.RowId > 0
				&& (x.Type == 1 || x.Type == 2)
				&& x.SortId > 0
				&& !string.IsNullOrWhiteSpace(x.BannerImage)
				&& (gachaIds.Contains(x.OneTimeGachaId) || gachaIds.Contains(x.TenTimeGachaId))
				&& (x.ScheduleType == 0
					|| (scheduleByGroup.TryGetValue(x.RowId, out var config) && config.Enabled == 1 && config.StartTime <= now && now < config.EndTime)))
			.GroupBy(x => x.RowId)
			.Select(x => x.First())
			.ToList();
		_logger.LogInformation("GachaInfo: designGroups={DesignGroups}, validGroups={ValidGroups}, skipped={Skipped}", groups.Count, validGroups.Count, groups.Count - validGroups.Count);
		foreach (var group in validGroups)
		{
			response.ScheduleInfo.Add(new GachaScheduleDBInfo
			{
				GroupId = group.RowId,
				StartTime = group.ScheduleType == 0 ? 0 : now,
				EndTime = group.ScheduleType == 0 ? 0 : end
			});
			if (group.PickUpItemId != 0)
				response.GachaSelectionInfo.Add(new GachaSelectionDBInfo { GroupId = group.RowId, ItemId = group.PickUpItemId });
		}
		foreach (var fixedInfo in DesignDbHelper.LoadFromCommon("GachaFixedTable", GachaFixedTable.Parser))
		{
			response.GachaFixedInfo.Add(new GachaFixedDBInfo
			{
				FixedId = fixedInfo.Id,
				Type = 0,
				Count = fixedInfo.G5CostumeFixedCount,
				ApplySortId = -1
			});
		}
		foreach (var step in DesignDbHelper.LoadFromCommon("GachaStepUpTable", GachaStepUpTable.Parser))
			response.StepUpScheduleInfo.Add(new GachaStepUpScheduleDBInfo { GroupId = step.GroupId });
		return await Task.FromResult(ResultUtil.CreateResult(response));
	}

	public async Task<GameActionResult> GachaBuy(GachaBuyRequest request, string uid)
	{
		return request.Id switch
		{
			100 => ResultUtil.CreateResult(await GachaBuyCostume(1, uid)), 
			101 => ResultUtil.CreateResult(await GachaBuyCostume(10, uid)), 
			200 => ResultUtil.CreateResult(await GachaBuyEquipment(1, uid)), 
			201 => ResultUtil.CreateResult(await GachaBuyEquipment(10, uid)), 
			_ => ResultUtil.CreateResult(await GachaBuyCostume(1, uid)), 
		};
	}

	private async Task<GachaBuyResponse> GachaBuyCostume(int count, string uid)
	{
		long userId = long.Parse(uid);
		List<CostumeTable> costumeDatas = CostumeManager.GetCostumeList(count);
		List<CharDBInfo> charDbInfos = new List<CharDBInfo>();
		List<CostumeDBInfo> costumeDbInfos = new List<CostumeDBInfo>();
		List<ItemDBInfo> viewItemDbInfos = new List<ItemDBInfo>();
		List<ItemDBInfo> itemDbInfos = new List<ItemDBInfo>();
		List<ItemAutoUpgradeInfo> itemAutoUpgradeInfos = new List<ItemAutoUpgradeInfo>();
		List<ItemAutoExchangeInfo> itemAutoExchangeInfos = new List<ItemAutoExchangeInfo>();
		int i = 0;
		while (true)
		{
			if (i >= costumeDatas.Count)
			{
				break;
			}
			if (await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.Uid == userId && x.UniqueCharId == costumeDatas[i].UseUniqueCharId) == null)
			{
				CostumeTable baseCostume = CostumeManager.GetCostume(costumeDatas[i].Id);
				CostumeInfoDao newCostumeInfo = new CostumeInfoDao
				{
					Uid = userId,
					Id = costumeDatas[i].Id
				};
				CostumeInfoDao costumeInfoDao = newCostumeInfo;
				costumeInfoDao.InvenIndex = await _db.Insertable(newCostumeInfo).ExecuteReturnIdentityAsync();
				CharTable baseCharData = CharManager.GetBaseCharData(costumeDatas[i].UseUniqueCharId);
				CharInfoDao newCharInfo = new CharInfoDao
				{
					InvenIndex = 0L,
					Uid = userId,
					Id = baseCharData.Id,
					Hp = (long)Math.Round(baseCharData.HealthValue),
					Level = 1,
					SolidarityReward = 1,
					TalentLevel = 1,
					ExpiryTime = -32400000L,
					UseCostume = newCostumeInfo.InvenIndex,
					ConnectPotentialCostume = baseCostume.SkillGroupId,
					UniqueCharId = baseCharData.UniqueCharId
				};
				CharInfoDao charInfoDao = newCharInfo;
				charInfoDao.InvenIndex = await _db.Insertable(newCharInfo).ExecuteReturnIdentityAsync();
				newCostumeInfo.UseChar = newCharInfo.InvenIndex;
				await _db.Updateable(newCostumeInfo).ExecuteCommandAsync();
				CostumeDBInfo costumeDBInfo = _mapper.Map<CostumeDBInfo>(newCostumeInfo);
				costumeDBInfo.SortId = i;
				costumeDbInfos.Add(costumeDBInfo);
				charDbInfos.Add(_mapper.Map<CharDBInfo>(newCharInfo));
				viewItemDbInfos.Add(new ItemDBInfo
				{
					Id = newCostumeInfo.Id,
					Type = 11,
					Count = 1
				});
				viewItemDbInfos.Add(new ItemDBInfo
				{
					Id = newCharInfo.Id,
					Type = 6,
					Count = 1
				});
			}
			else
			{
				CostumeInfoDao newCostumeInfo = await _db.Queryable<CostumeInfoDao>().SingleAsync((CostumeInfoDao x) => x.Uid == userId && x.Id == costumeDatas[i].Id);
				if (newCostumeInfo == null)
				{
					CostumeInfoDao costumeInfoDao = new CostumeInfoDao
					{
						Uid = userId,
						Id = costumeDatas[i].Id
					};
					CostumeInfoDao costumeInfoDao2 = costumeInfoDao;
					costumeInfoDao2.InvenIndex = await _db.Insertable(costumeInfoDao).ExecuteReturnIdentityAsync();
					CostumeDBInfo costumeDBInfo2 = _mapper.Map<CostumeDBInfo>(costumeInfoDao);
					costumeDBInfo2.SortId = i;
					costumeDbInfos.Add(costumeDBInfo2);
					viewItemDbInfos.Add(new ItemDBInfo
					{
						Id = costumeInfoDao.Id,
						Type = 11,
						Count = 1
					});
				}
				else if (newCostumeInfo.Level < costumeDatas[i].MaxLevel)
				{
					newCostumeInfo.Level++;
					await _db.Updateable(newCostumeInfo).ExecuteCommandAsync();
					itemAutoUpgradeInfos.Add(new ItemAutoUpgradeInfo
					{
						InvenIndex = newCostumeInfo.InvenIndex,
						ItemType = 11,
						ItemId = newCostumeInfo.Id,
						BeforeLevel = newCostumeInfo.Level - 1,
						AfterLevel = newCostumeInfo.Level,
						SortId = i
					});
					viewItemDbInfos.Add(new ItemDBInfo
					{
						Id = newCostumeInfo.Id,
						Type = 11,
						Count = 1
					});
				}
				else if (newCostumeInfo.Level == costumeDatas[i].MaxLevel)
				{
					ItemDBInfo itemDBInfo = new ItemDBInfo
					{
						Type = 20,
						Count = 1
					};
					viewItemDbInfos.Add(itemDBInfo);
					itemDBInfo.SortId = i;
					itemDbInfos.Add(itemDBInfo);
					ItemAutoExchangeInfo item = new ItemAutoExchangeInfo
					{
						OriginalItemType = 11,
						OriginalItemId = newCostumeInfo.Id,
						OriginalItemCount = 1,
						ExchangeItemType = itemDBInfo.Type,
						ExchangeItemCount = itemDBInfo.Count,
						SortId = i
					};
					itemAutoExchangeInfos.Add(item);
				}
			}
			i++;
		}
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		rewardDBInfoBundle.ItemInfo.AddRange(itemDbInfos);
		rewardDBInfoBundle.ViewItemInfo.AddRange(viewItemDbInfos);
		rewardDBInfoBundle.CharInfo.AddRange(charDbInfos);
		rewardDBInfoBundle.CostumeInfo.AddRange(costumeDbInfos);
		rewardDBInfoBundle.ItemAutoUpgradeInfo.AddRange(itemAutoUpgradeInfos);
		rewardDBInfoBundle.ItemAutoExchangeInfo.AddRange(itemAutoExchangeInfos);
		BuyGacha(uid, count);
		GachaBuyResponse gachaBuyResponse = new GachaBuyResponse();
		gachaBuyResponse.GetPoint = count;
		string value = "[{\"fixedId\":1,\"count\":6,\"applySortId\":-1},{\"fixedId\":1,\"type\":1,\"count\":0,\"applySortId\":-1},{\"fixedId\":1,\"type\":2,\"count\":1,\"applySortId\":-1},{\"fixedId\":1,\"type\":3,\"count\":5,\"applySortId\":-1}]";
		gachaBuyResponse.GachaFixedInfo.AddRange(JsonConvert.DeserializeObject<RepeatedField<GachaFixedDBInfo>>(value));
		gachaBuyResponse.RewardInfoBundle = rewardDBInfoBundle;
		return gachaBuyResponse;
	}

	private async Task<GachaBuyResponse> GachaBuyEquipment(int count, string uid)
	{
		long userId = long.Parse(uid);
		List<EquipmentTable> randomEquipmentData = EquipmentManager.GetEquipmentRandomList(count);
		List<EquipDBInfo> equipDbInfos = new List<EquipDBInfo>();
		List<ItemDBInfo> viewItemDbInfos = new List<ItemDBInfo>();
		for (int i = 0; i < randomEquipmentData.Count; i++)
		{
			EquipBaseInfo equipBaseInfo = new EquipBaseInfo();
			EquipInfoDao equipInfoDao = new EquipInfoDao
			{
				Uid = userId,
				Id = randomEquipmentData[i].Id,
				Rank = "[0, 0, 0]",
				SlotType = randomEquipmentData[i].SlotType
			};
			equipBaseInfo.Id = equipInfoDao.Id;
			equipBaseInfo.Rank.AddRange(new int[3]);
			RepeatedField<EquipOptionInfo> repeatedField = new RepeatedField<EquipOptionInfo>();
			foreach (int item2 in randomEquipmentData[i].MainOptionGroupId)
			{
				EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(item2);
				EquipOptionInfo item = new EquipOptionInfo
				{
					GroupId = randomEquipmentOptions.GroupId,
					Id = randomEquipmentOptions.Id
				};
				repeatedField.Add(item);
			}
			equipBaseInfo.MainOption.AddRange(repeatedField);
			equipInfoDao.MainOption = JsonConvert.SerializeObject(repeatedField);
			foreach (int item3 in randomEquipmentData[i].PrivateUniqueOptionGroupId)
			{
				EquipmentOptionTable randomEquipmentOptions2 = EquipmentManager.GetRandomEquipmentOptions(item3);
				EquipOptionInfo privateOption = new EquipOptionInfo
				{
					GroupId = randomEquipmentOptions2.GroupId,
					Id = randomEquipmentOptions2.Id
				};
				equipBaseInfo.PrivateOption = privateOption;
			}
			string text = JsonConvert.SerializeObject(equipBaseInfo.PrivateOption);
			if (text != "null")
			{
				equipInfoDao.PrivateOption = text;
			}
			int num = await _db.Insertable(equipInfoDao).ExecuteReturnIdentityAsync();
			equipDbInfos.Add(new EquipDBInfo
			{
				InvenIndex = num,
				BaseInfo = equipBaseInfo,
				SortId = i
			});
			viewItemDbInfos.Add(new ItemDBInfo
			{
				Type = 10,
				Count = 1,
				Id = equipInfoDao.Id
			});
		}
		BuyGacha(uid, count);
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		rewardDBInfoBundle.EquipInfo.AddRange(equipDbInfos);
		rewardDBInfoBundle.ViewItemInfo.AddRange(viewItemDbInfos);
		GachaBuyResponse gachaBuyResponse = new GachaBuyResponse();
		gachaBuyResponse.GetPoint = count;
		string value = "[{\"applySortId\":-1,\"count\":1,\"fixedId\":1},{\"applySortId\":-1,\"count\":90,\"fixedId\":1,\"type\":1},{\"applySortId\":-1,\"fixedId\":1,\"type\":2},{\"applySortId\":-1,\"fixedId\":1,\"type\":3}]";
		gachaBuyResponse.GachaFixedInfo.AddRange(JsonConvert.DeserializeObject<RepeatedField<GachaFixedDBInfo>>(value));
		gachaBuyResponse.RewardInfoBundle = rewardDBInfoBundle;
		return gachaBuyResponse;
	}

	private void BuyGacha(string uid, int count)
	{
		UserInfoDao userInfoDao = _db.Queryable<UserInfoDao>().Single((UserInfoDao x) => x.OwnerIndex == long.Parse(uid));
		int num = 200 * count;
		userInfoDao.FreeJewelry -= num;
		if (userInfoDao.FreeJewelry < 0)
		{
			userInfoDao.Jewelry += userInfoDao.FreeJewelry;
			userInfoDao.FreeJewelry = 0L;
		}
		_db.Updateable(userInfoDao).ExecuteCommand();
	}
}
