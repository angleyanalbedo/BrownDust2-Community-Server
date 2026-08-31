using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using Google.Protobuf.Collections;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameQuestService : IGameQuestService
{
	private readonly ILogger<GameQuestService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	private readonly IActionService _actionService;

	private static readonly Dictionary<int, int[]> TempCharId = new Dictionary<int, int[]>
	{
		{
			2,
			new int[1] { 10030 }
		},
		{
			3,
			new int[2] { 10160, 10040 }
		},
		{
			4,
			new int[2] { 10050, 10060 }
		},
		{
			5,
			new int[2] { 10100, 10080 }
		},
		{
			6,
			new int[2] { 16040, 10070 }
		},
		{
			7,
			new int[1] { 10110 }
		},
		{
			8,
			new int[1] { 10120 }
		}
	};

	public GameQuestService(ILogger<GameQuestService> logger, ISqlSugarClient db, IMapper mapper, IActionService actionService)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_actionService = actionService;
	}

	public async Task<GameActionResult> QuestUpdate(QuestUpdateRequest req, string uid)
	{
		await Task.Yield();
		_logger.LogInformation("QuestUpdate {}", req);
		return ResultUtil.CreateResult(new QuestUpdateResponse
		{
			UpdateQuestId = req.QuestId
		});
	}

	public async Task<GameActionResult> QuestClear(QuestClearRequest req, string uid)
	{
		_logger.LogInformation("QuestClear {}", req);
		QuestTable1 questTable = QuestManager.GetQuestTable(req.PackId, req.QuestId);
		QuestInfoDao questInfoDao = await _db.Queryable<QuestInfoDao>().SingleAsync((QuestInfoDao x) => x.Uid == long.Parse(uid) && x.PackId == req.PackId);
		if (questInfoDao != null && !string.IsNullOrEmpty(questInfoDao.QuestClear))
		{
			List<int> clearedQuestIds = JsonConvert.DeserializeObject<List<int>>(questInfoDao.QuestClear) ?? new List<int>();
			if (clearedQuestIds.Contains(req.QuestId))
			{
				// The client removes the cleared quest and blindly appends QuestInfo.
				// Returning the next quest again would make PackManager.AddQuest add a
				// duplicate QuestDBInfo, which later crashes GameFieldDefaultUI.
				_logger.LogWarning("QuestClear: duplicate clear ignored, uid={Uid}, packId={PackId}, questId={QuestId}", uid, req.PackId, req.QuestId);
				return ResultUtil.CreateErrorResult(1);
			}
		}
		if (questInfoDao == null)
		{
			List<int> list = new List<int>();
			list.Add(req.QuestId);
			questInfoDao = new QuestInfoDao
			{
				Uid = long.Parse(uid),
				PackId = req.PackId,
				QuestId = questTable.NextQuestId,
				QuestClear = JsonConvert.SerializeObject(list)
			};
			await _db.Insertable(questInfoDao).ExecuteCommandAsync();
		}
		else
		{
			List<int> list2 = JsonConvert.DeserializeObject<List<int>>(questInfoDao.QuestClear);
			list2.Add(req.QuestId);
			questInfoDao.PackId = req.PackId;
			questInfoDao.QuestId = questTable.NextQuestId;
			questInfoDao.QuestClear = JsonConvert.SerializeObject(list2);
			await _db.Updateable(questInfoDao).ExecuteCommandAsync();
		}
		RewardDBInfoBundle rewardDbInfoBundle = GetRewardDbInfoBundle(questTable, uid);
		if (req.QuestId == 1 && TempCharId.ContainsKey(req.PackId))
		{
			int[] array = TempCharId[req.PackId];
			foreach (int id in array)
			{
				CharInfoDao charInfoDao = new CharInfoDao
				{
					Uid = long.Parse(uid),
					Id = id,
					Hp = 9999L,
					Level = 20,
					TalentLevel = 1,
					SolidarityReward = 1,
					ExpiryTime = -32400000L,
					UniqueCharId = id
				};
				charInfoDao.InvenIndex = await _db.Insertable(charInfoDao).ExecuteReturnBigIdentityAsync();
				rewardDbInfoBundle.CharInfo.Add(_mapper.Map<CharDBInfo>(charInfoDao));
				rewardDbInfoBundle.ViewItemInfo.Add(new ItemDBInfo
				{
					Id = id,
					Type = 6
				});
			}
		}
		QuestClearResponse questClearResponse = new QuestClearResponse
		{
			RewardInfoBundle = rewardDbInfoBundle,
			ClearQuestId = req.QuestId
		};
		if (questTable.NextQuestId != 0)
		{
			questClearResponse.QuestInfo = new QuestDBInfo
			{
				Id = questTable.NextQuestId
			};
		}
		else
		{
			questInfoDao.IsPackComplete = 1;
			await _db.Updateable(questInfoDao).ExecuteCommandAsync();
			if (req.PackId < 14)
			{
				questClearResponse.PackInfo.Add(new PackDBInfo
				{
					Id = questTable.PackId + 1
				});
				questClearResponse.QuestInfo = new QuestDBInfo
				{
					Id = 1
				};
			}
			else
			{
				questClearResponse.QuestInfo = new QuestDBInfo();
			}
		}
		foreach (DeckInfoDao item in await (from it in _db.Queryable<DeckInfoDao>()
			where it.Uid == long.Parse(uid)
			select it).ToListAsync())
		{
			questClearResponse.DeckInfo.Add(_mapper.Map<DeckDBInfo>(item));
		}
		return ResultUtil.CreateResult(questClearResponse);
	}

	public async Task FastCompletePack(long uid, int packId)
	{
		var quest = await _db.Queryable<QuestInfoDao>().SingleAsync(x => x.Uid == uid && x.PackId == packId);
		if (quest == null) return;
		var cleared = new List<int>();
		var next = 1;
		for (var i = 0; i < 99; i++)
		{
			var table = QuestManager.GetQuestTable(packId, next);
			if (table == null) break;
			cleared.Add(table.Id);
			if (table.NextQuestId == 0) break;
			next = table.NextQuestId;
		}
		quest.QuestClear = JsonConvert.SerializeObject(cleared.Distinct().ToList());
		quest.IsPackComplete = 1;
		await _db.Updateable(quest).ExecuteCommandAsync();
		if (packId < 14 && !await _db.Queryable<QuestInfoDao>().AnyAsync(x => x.Uid == uid && x.PackId == packId + 1))
			await _db.Insertable(new QuestInfoDao { Uid = uid, PackId = packId + 1, QuestId = 1, QuestClear = "[]", IsPackComplete = 0 }).ExecuteCommandAsync();
		if (packId == 1)
			await EnsureContentTicket(uid, Define_ContentOpenType.ContentUnlockGacha, 1);
	}

	private async Task EnsureContentTicket(long uid, Define_ContentOpenType type, int id)
	{
		var open = DesignDbHelper.LoadFromCommon("ContentOpenTable", ContentOpenTable.Parser)
			.FirstOrDefault(x => x.GroupId == (int)type && x.Id == id);
		if (open == null || open.TicketId == 0 || await _db.Queryable<ItemInfoDao>().AnyAsync(x => x.Uid == uid && x.Id == open.TicketId)) return;
        await _db.Insertable(new ItemSpecialInfoDao
        {
            Uid = uid,
            Id = open.TicketId,
            Type = (int)ItemType.ContentTicket,
            Count = 1,
            ExpiryTime = 0
        }).ExecuteCommandAsync();
		_logger.LogInformation("FastCompletePack: added content ticket {TicketId} for {ContentType} {ContentId}", open.TicketId, type, id);
	}

	private RewardDBInfoBundle GetRewardDbInfoBundle(QuestTable1 questTable, string uid)
	{
		long userId = long.Parse(uid);
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		List<CharDBInfo> list = new List<CharDBInfo>();
		List<CostumeDBInfo> list2 = new List<CostumeDBInfo>();
		List<ItemDBInfo> list3 = new List<ItemDBInfo>();
		List<ItemDBInfo> list4 = new List<ItemDBInfo>();
		List<EquipDBInfo> list5 = new List<EquipDBInfo>();
		List<ItemAutoUpgradeInfo> list6 = new List<ItemAutoUpgradeInfo>();
		List<ItemAutoExchangeInfo> list7 = new List<ItemAutoExchangeInfo>();
		int rewardCount = Math.Min(questTable.RewardId.Count, Math.Min(questTable.RewardType.Count, questTable.RewardCount.Count));
		for (int i = 0; i < rewardCount; i++)
		{
			bool flag;
			switch ((ItemType)questTable.RewardType[i])
			{
			case ItemType.Equip:
			{
				EquipmentTable equipmentById = EquipmentManager.GetEquipmentById(questTable.RewardId[i]);
				EquipBaseInfo equipBaseInfo = new EquipBaseInfo();
				EquipInfoDao equipInfoDao = new EquipInfoDao
				{
					Uid = userId,
					Id = questTable.RewardId[i],
					Rank = "[0, 0, 0]",
					SlotType = equipmentById.SlotType
				};
				equipBaseInfo.Id = equipInfoDao.Id;
				equipBaseInfo.Rank.AddRange(new int[3]);
				RepeatedField<EquipOptionInfo> repeatedField = new RepeatedField<EquipOptionInfo>();
				foreach (int item5 in equipmentById.MainOptionGroupId)
				{
					EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(item5);
					EquipOptionInfo item3 = new EquipOptionInfo
					{
						GroupId = randomEquipmentOptions.GroupId,
						Id = randomEquipmentOptions.Id
					};
					repeatedField.Add(item3);
				}
				equipBaseInfo.MainOption.AddRange(repeatedField);
				equipInfoDao.MainOption = JsonConvert.SerializeObject(repeatedField);
				foreach (int item6 in equipmentById.PrivateUniqueOptionGroupId)
				{
					EquipmentOptionTable randomEquipmentOptions2 = EquipmentManager.GetRandomEquipmentOptions(item6);
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
				int num = _db.Insertable(equipInfoDao).ExecuteReturnIdentity();
				list5.Add(new EquipDBInfo
				{
					InvenIndex = num,
					BaseInfo = equipBaseInfo,
					SortId = i
				});
				list3.Add(new ItemDBInfo
				{
					Type = 10,
					Count = 1,
					Id = equipInfoDao.Id
				});
				continue;
			}
			case ItemType.Costume:
			{
				CostumeTable costumeTable = CostumeManager.GetCostume(questTable.RewardId[i]);
				if (_db.Queryable<CharInfoDao>().Single((CharInfoDao x) => x.Uid == userId && x.UniqueCharId == costumeTable.UseUniqueCharId) == null)
				{
					CostumeInfoDao costumeInfoDao = new CostumeInfoDao
					{
						Uid = userId,
						Id = costumeTable.Id
                    };
					costumeInfoDao.InvenIndex = _db.Insertable(costumeInfoDao).ExecuteReturnIdentity();
					CharTable baseCharData = CharManager.GetBaseCharData(costumeTable.UseUniqueCharId);
					CharInfoDao charInfoDao = new CharInfoDao
					{
						InvenIndex = 0L,
						Uid = userId,
						Id = baseCharData.Id,
						Hp = (long)Math.Round(baseCharData.HealthValue),
						Level = 1,
						SolidarityReward = 1,
						TalentLevel = 1,
						ExpiryTime = -32400000L,
						UseCostume = costumeInfoDao.InvenIndex,
						ConnectPotentialCostume = costumeTable.SkillGroupId,
						UniqueCharId = baseCharData.UniqueCharId
					};
					charInfoDao.InvenIndex = _db.Insertable(charInfoDao).ExecuteReturnIdentity();
					costumeInfoDao.UseChar = charInfoDao.InvenIndex;
					_db.Updateable(costumeInfoDao).ExecuteCommand();
					CostumeDBInfo item = _mapper.Map<CostumeDBInfo>(costumeInfoDao);
					list2.Add(item);
					list.Add(_mapper.Map<CharDBInfo>(charInfoDao));
					list3.Add(new ItemDBInfo
					{
						Id = costumeInfoDao.Id,
						Type = 11,
						Count = 1
					});
					list3.Add(new ItemDBInfo
					{
						Id = charInfoDao.Id,
						Type = 6,
						Count = 1
					});
					continue;
				}
				CostumeInfoDao costumeInfoDao2 = _db.Queryable<CostumeInfoDao>().Single((CostumeInfoDao x) => x.Uid == userId && x.Id == costumeTable.Id);
				if (costumeInfoDao2 == null)
				{
					CostumeInfoDao costumeInfoDao3 = new CostumeInfoDao
					{
						Uid = userId,
						Id = costumeTable.Id
					};
					costumeInfoDao3.InvenIndex = _db.Insertable(costumeInfoDao3).ExecuteReturnIdentity();
					CostumeDBInfo costumeDBInfo = _mapper.Map<CostumeDBInfo>(costumeInfoDao3);
					costumeDBInfo.SortId = i;
					list2.Add(costumeDBInfo);
					list3.Add(new ItemDBInfo
					{
						Id = costumeInfoDao3.Id,
						Type = 11,
						Count = 1
					});
					list3.Add(new ItemDBInfo
					{
						Id = costumeTable.UseUniqueCharId,
						Type = 6,
						Count = 1
					});
				}
				else if (costumeInfoDao2.Level < costumeTable.MaxLevel)
				{
					costumeInfoDao2.Level++;
					_db.Updateable(costumeInfoDao2).ExecuteCommand();
					list6.Add(new ItemAutoUpgradeInfo
					{
						InvenIndex = costumeInfoDao2.InvenIndex,
						ItemType = 11,
						ItemId = costumeInfoDao2.Id,
						BeforeLevel = costumeInfoDao2.Level - 1,
						AfterLevel = costumeInfoDao2.Level
					});
					list3.Add(new ItemDBInfo
					{
						Id = costumeInfoDao2.Id,
						Type = 11,
						Count = 1
					});
					list3.Add(new ItemDBInfo
					{
						Id = costumeTable.UseUniqueCharId,
						Type = 6,
						Count = 1
					});
				}
				else if (costumeInfoDao2.Level == costumeTable.MaxLevel)
				{
					ItemDBInfo itemDBInfo = new ItemDBInfo
					{
						Type = 20,
						Count = 1
					};
					list3.Add(itemDBInfo);
					list4.Add(itemDBInfo);
					ItemAutoExchangeInfo item2 = new ItemAutoExchangeInfo
					{
						OriginalItemType = 11,
						OriginalItemId = costumeInfoDao2.Id,
						OriginalItemCount = 1,
						ExchangeItemType = itemDBInfo.Type,
						ExchangeItemCount = itemDBInfo.Count
					};
					list7.Add(item2);
				}
				continue;
			}
			case ItemType.FreeJewelry:
			case ItemType.Gold:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (flag)
			{
				_actionService.SendItemToUser(questTable.RewardId[i], questTable.RewardType[i], questTable.RewardCount[i], uid);
				list4.Add(new ItemDBInfo
				{
					Type = questTable.RewardType[i],
					Count = questTable.RewardCount[i]
				});
			}
			else
			{
				ItemDBInfo item4 = _actionService.SendItemToBag(questTable.RewardId[i], questTable.RewardType[i], questTable.RewardCount[i], uid);
				list4.Add(item4);
				list3.Add(item4);
			}
		}
		rewardDBInfoBundle.EquipInfo.AddRange(list5);
		rewardDBInfoBundle.ItemInfo.AddRange(list4);
		rewardDBInfoBundle.ViewItemInfo.AddRange(list3);
		rewardDBInfoBundle.CharInfo.AddRange(list);
		rewardDBInfoBundle.CostumeInfo.AddRange(list2);
		rewardDBInfoBundle.ItemAutoUpgradeInfo.AddRange(list6);
		rewardDBInfoBundle.ItemAutoExchangeInfo.AddRange(list7);
		return rewardDBInfoBundle;
	}
}
