using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Cache;
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

public class GameEquipService : IGameEquipService
{
	private readonly ILogger<GameEquipService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	private readonly IActionService _actionService;

	public GameEquipService(ISqlSugarClient db, ILogger<GameEquipService> logger, IMapper mapper, IActionService actionService)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_actionService = actionService;
	}

	public async Task<GameActionResult> EquipInfo(string uid)
	{
		List<EquipInfoDao> dao = await (from it in _db.Queryable<EquipInfoDao>()
			where it.Uid == long.Parse(uid)
			select it).ToListAsync();
		EquipInfoResponse equipInfoResponse = new EquipInfoResponse();
		equipInfoResponse.EquipInfo.AddRange(EquipmentManager.ConvertEquipDbInfo(dao));
		return ResultUtil.CreateResult(equipInfoResponse);
	}

	public async Task<GameActionResult> EquipSmelting(long index)
	{
		EquipInfoDao equipInfoDao = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == index);
		EquipSmeltingResponse equipSmeltingResponse = new EquipSmeltingResponse();
		int[] source = JsonConvert.DeserializeObject<int[]>(equipInfoDao.Rank);
		int[] equipSmeltingRandom = RandomUtil.EquipSmeltingRandom();
		if (equipSmeltingRandom.Sum() > source.Sum())
		{
			equipSmeltingResponse.ResultType = Define_EquipUpgradeResultType.UpgradeSuccess;
			equipInfoDao.Rank = JsonConvert.SerializeObject(equipSmeltingRandom);
			await _db.Updateable(equipInfoDao).ExecuteCommandAsync();
		}
		else
		{
			equipSmeltingResponse.ResultType = Define_EquipUpgradeResultType.UpgradeFail;
		}
		equipSmeltingResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(equipInfoDao);
		equipSmeltingResponse.ResultGrade.AddRange(equipSmeltingRandom);
		return ResultUtil.CreateResult(equipSmeltingResponse);
	}

	public async Task<GameActionResult> EquipSequenceSmelting(EquipSequenceSmeltingRequest req, string uid)
	{
		EquipInfoDao equipInfoDao = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == req.InvenIndex);
		int[] array = JsonConvert.DeserializeObject<int[]>(equipInfoDao.Rank);
		EquipSequenceSmeltingResponse equipSequenceSmeltingResponse = new EquipSequenceSmeltingResponse();
		bool flag = false;
		for (int num = 0; num < req.SmeltingCount; num++)
		{
			equipSequenceSmeltingResponse.TryCount = num;
			int[] array2 = RandomUtil.EquipSmeltingRandom();
			if (array2.Sum() > array.Sum())
			{
				array = array2;
				flag = true;
				if (req.IsSuccessStop)
				{
					equipSequenceSmeltingResponse.ResultType = Define_EquipUpgradeResultType.UpgradeStopSuccess;
					break;
				}
			}
		}
		if (flag)
		{
			equipInfoDao.Rank = JsonConvert.SerializeObject(array);
			await _db.Updateable(equipInfoDao).ExecuteCommandAsync();
		}
		equipSequenceSmeltingResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(equipInfoDao);
		equipSequenceSmeltingResponse.ConsumeItemInfo.Add(new ItemDBInfo
		{
			Type = 4,
			Count = 200
		});
		return ResultUtil.CreateResult(equipSequenceSmeltingResponse);
	}

	public async Task<GameActionResult> EquipClear(EquipClearRequest equipClear)
	{
		await (from x in _db.Updateable<EquipInfoDao>().SetColumns((EquipInfoDao x) => x.UseChar == 0)
			where x.InvenIndex == equipClear.EquipIndex
			select x).ExecuteCommandAsync();
		CharInfoDao source = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == equipClear.CharIndex);
		CharDBInfo charInfo = _mapper.Map<CharDBInfo>(source);
		return ResultUtil.CreateResult(new EquipClearResponse
		{
			CharInfo = charInfo
		});
	}

	public async Task<GameActionResult> EquipUse(EquipUseRequest equipUse)
	{
		await (from x in _db.Updateable<EquipInfoDao>().SetColumns((EquipInfoDao x) => x.UseChar == equipUse.CharIndex)
			where x.InvenIndex == equipUse.EquipIndex
			select x).ExecuteCommandAsync();
		CharInfoDao source = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == equipUse.CharIndex);
		CharDBInfo charInfo = _mapper.Map<CharDBInfo>(source);
		return ResultUtil.CreateResult(new EquipUseResponse
		{
			CharInfo = charInfo
		});
	}

	public async Task<GameActionResult> EquipChange(EquipChangeRequest equipChange)
	{
		EquipInfoDao changeItem = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == equipChange.EquipIndex);
		changeItem.UseChar = equipChange.CharIndex;
		EquipInfoDao equipInfoDao = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.UseChar == equipChange.CharIndex && x.SlotType == changeItem.SlotType);
		equipInfoDao.UseChar = 0L;
		List<EquipInfoDao> list = new List<EquipInfoDao> { changeItem, equipInfoDao };
		await _db.Updateable(list).ExecuteCommandAsync();
		CharInfoDao source = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == equipChange.CharIndex);
		CharDBInfo charInfo = _mapper.Map<CharDBInfo>(source);
		return ResultUtil.CreateResult(new EquipChangeResponse
		{
			CharInfo = charInfo
		});
	}

	public async Task<GameActionResult> EquipBatchUse(EquipBatchUseRequest equipBatchUse)
	{
		List<long> charIds = new List<long>();
		foreach (EquipBatchUseInfo equipBatchUseInfo in equipBatchUse.EquipBatchInfo)
		{
			charIds.Add(equipBatchUseInfo.CharInvenIndex);
			await (from x in _db.Updateable<EquipInfoDao>().SetColumns((EquipInfoDao x) => x.UseChar == 0)
				where x.UseChar == equipBatchUseInfo.CharInvenIndex
				select x).ExecuteCommandAsync();
			List<long> longs = equipBatchUseInfo.EquipInvenIndex.Where((long x) => x != 0).ToList();
			await (from x in _db.Updateable<EquipInfoDao>().SetColumns((EquipInfoDao x) => x.UseChar == equipBatchUseInfo.CharInvenIndex)
				where longs.Contains(x.InvenIndex)
				select x).ExecuteCommandAsync();
		}
		List<CharInfoDao> source = await (from x in _db.Queryable<CharInfoDao>()
			where charIds.Contains(x.InvenIndex)
			select x).ToListAsync();
		List<CharDBInfo> values = _mapper.Map<List<CharDBInfo>>(source);
		EquipBatchUseResponse equipBatchUseResponse = new EquipBatchUseResponse();
		equipBatchUseResponse.CharInfo.AddRange(values);
		return ResultUtil.CreateResult(equipBatchUseResponse);
	}

	public async Task<GameActionResult> EquipUpgrade(EquipUpgradeRequest equipUpgrade, string uid)
	{
		EquipInfoDao equipInfoDao = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == equipUpgrade.InvenIndex);
		bool num = RandomUtil.EquipUpgradeRandom(equipInfoDao.Level);
		EquipUpgradeResponse equipUpgradeResponse = new EquipUpgradeResponse();
		if (num)
		{
			equipInfoDao.Level++;
			RepeatedField<int> subOptionGroupId = EquipmentManager.GetEquipmentById(equipInfoDao.Id).SubOptionGroupId;
			if (equipInfoDao.Level % 3 == 0)
			{
				List<EquipOptionInfo> list = new List<EquipOptionInfo>();
				if (equipInfoDao.SubOption != null)
				{
					list = JsonConvert.DeserializeObject<List<EquipOptionInfo>>(equipInfoDao.SubOption);
				}
				EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(subOptionGroupId[equipInfoDao.Level / 3 - 1]);
				list.Add(new EquipOptionInfo
				{
					Id = randomEquipmentOptions.Id,
					GroupId = randomEquipmentOptions.GroupId
				});
				equipInfoDao.SubOption = JsonConvert.SerializeObject(list);
				int[] array = JsonConvert.DeserializeObject<int[]>(equipInfoDao.Rank);
				array[equipInfoDao.Level / 3 - 1] = new Random().Next(1, 5);
				equipInfoDao.Rank = JsonConvert.SerializeObject(array);
			}
			await _db.Updateable(equipInfoDao).ExecuteCommandAsync();
			equipUpgradeResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(equipInfoDao);
		}
		else
		{
			equipUpgradeResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(equipInfoDao);
			equipUpgradeResponse.ResultType = Define_EquipUpgradeResultType.UpgradeFail;
		}
		return ResultUtil.CreateResult(equipUpgradeResponse);
	}

	public async Task<GameActionResult> EquipSequenceUpgrade(EquipSequenceUpgradeRequest req, string uid)
	{
		EquipSequenceUpgradeResponse equipSequenceSmeltingResponse = new EquipSequenceUpgradeResponse();
		EquipInfoDao equipInfoDao = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == req.InvenIndex);
		RepeatedField<int> subOptionGroupId = EquipmentManager.GetEquipmentById(equipInfoDao.Id).SubOptionGroupId;
		List<EquipOptionInfo> list = new List<EquipOptionInfo>();
		if (equipInfoDao.SubOption != null)
		{
			list = JsonConvert.DeserializeObject<List<EquipOptionInfo>>(equipInfoDao.SubOption);
		}
		int[] array = JsonConvert.DeserializeObject<int[]>(equipInfoDao.Rank);
		for (int num = 0; num < req.UpgradeCount; num++)
		{
			if (RandomUtil.EquipUpgradeRandom(equipInfoDao.Level))
			{
				equipInfoDao.Level++;
				if (equipInfoDao.Level % 3 == 0)
				{
					EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(subOptionGroupId[equipInfoDao.Level / 3 - 1]);
					list.Add(new EquipOptionInfo
					{
						Id = randomEquipmentOptions.Id,
						GroupId = randomEquipmentOptions.GroupId
					});
					array[equipInfoDao.Level / 3 - 1] = new Random().Next(1, 5);
				}
				equipSequenceSmeltingResponse.TryCount = num;
				if (equipInfoDao.Level == req.UpgradeTargetLevel)
				{
					equipSequenceSmeltingResponse.ResultType = Define_EquipUpgradeResultType.UpgradeStopTargetLevel;
					break;
				}
			}
		}
		equipInfoDao.SubOption = JsonConvert.SerializeObject(list);
		equipInfoDao.Rank = JsonConvert.SerializeObject(array);
		await _db.Updateable(equipInfoDao).ExecuteCommandAsync();
		equipSequenceSmeltingResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(equipInfoDao);
		equipSequenceSmeltingResponse.UpgradeUsedGold = 1;
		equipSequenceSmeltingResponse.ConsumeItemInfo.Add(new ItemDBInfo
		{
			Type = 4,
			Count = 1
		});
		return ResultUtil.CreateResult(equipSequenceSmeltingResponse);
	}

	public async Task<GameActionResult> EquipOptionReRoll(EquipOptionReRollRequest req, string uid)
	{
		EquipInfoDao obj = await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == req.EquipInvenIndex);
		List<EquipOptionInfo> list = JsonConvert.DeserializeObject<List<EquipOptionInfo>>(obj.MainOption);
		List<EquipOptionInfo> list2 = JsonConvert.DeserializeObject<List<EquipOptionInfo>>(obj.SubOption);
		if (!req.MainOptLock[1])
		{
			EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(list[1].GroupId);
			list[1].GroupId = randomEquipmentOptions.GroupId;
			list[1].Id = randomEquipmentOptions.Id;
		}
		for (int num = 0; num < req.SubOptLock.Count; num++)
		{
			if (!req.SubOptLock[num])
			{
				EquipmentOptionTable randomEquipmentOptions2 = EquipmentManager.GetRandomEquipmentOptions(list2[num].GroupId);
				list2[num].Id = randomEquipmentOptions2.Id;
				list2[num].GroupId = randomEquipmentOptions2.GroupId;
			}
		}
		EquipOptionReRollResponse equipOptionReRollResponse = new EquipOptionReRollResponse();
		equipOptionReRollResponse.SubOption.AddRange(list2);
		equipOptionReRollResponse.MainOption.AddRange(list);
		string value = JsonConvert.SerializeObject(list) + "|" + JsonConvert.SerializeObject(list2);
		EquipOptionReRollCache.CacheInsertAddMinutes(uid, value, 10);
		return ResultUtil.CreateResult(equipOptionReRollResponse);
	}

	public async Task<GameActionResult> EquipOptionReRollConfirm(EquipOptionReRollConfirmRequest req, string uid)
	{
		EquipOptionReRollConfirmResponse equipOptionReRollConfirmResponse = new EquipOptionReRollConfirmResponse();
		if (req.IsConfirm)
		{
			string text = (string)EquipOptionReRollCache.CacheValue(uid);
			string[] parts = text.Split('|');
			await (from x in _db.Updateable<EquipInfoDao>().SetColumns((EquipInfoDao x) => x.MainOption == parts[0]).SetColumns((EquipInfoDao x) => x.SubOption == parts[1])
				where x.InvenIndex == req.EquipInvenIndex
				select x).ExecuteCommandAsync();
			equipOptionReRollConfirmResponse.EquipInfo = EquipmentManager.ConvertEquipDbInfo(await _db.Queryable<EquipInfoDao>().SingleAsync((EquipInfoDao x) => x.InvenIndex == req.EquipInvenIndex));
		}
		else
		{
			EquipOptionReRollCache.CacheNull(uid);
		}
		return ResultUtil.CreateResult(equipOptionReRollConfirmResponse);
	}

	public async Task<GameActionResult> EquipBreak(EquipBreakRequest req, string uid)
	{
		await _db.Deleteable<EquipInfoDao>().In(req.InvenIndex.ToArray()).ExecuteCommandAsync();
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		List<ItemDBInfo> list = new List<ItemDBInfo>();
		list.Add(new ItemDBInfo
		{
			Type = 8,
			Count = 20 * req.InvenIndex.Count,
			Id = 10
		});
		list.Add(new ItemDBInfo
		{
			Type = 8,
			Count = 10 * req.InvenIndex.Count,
			Id = 16
		});
		list.Add(new ItemDBInfo
		{
			Type = 8,
			Count = 10 * req.InvenIndex.Count,
			Id = 17
		});
		rewardDBInfoBundle.ViewItemInfo.AddRange(list);
		foreach (ItemDBInfo item2 in list)
		{
			ItemDBInfo item = _actionService.SendItemToBag(item2.Id, item2.Type, item2.Count, uid);
			rewardDBInfoBundle.ItemInfo.Add(item);
		}
		return ResultUtil.CreateResult(new EquipBreakResponse
		{
			RewardInfoBundle = rewardDBInfoBundle
		});
	}
}
