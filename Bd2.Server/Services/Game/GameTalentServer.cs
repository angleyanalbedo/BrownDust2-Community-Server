using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using EasyTool;
using Google.Protobuf.Collections;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameTalentServer : IGameTalentServer
{
	private readonly ILogger<GameTalentServer> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	private readonly IActionService _actionService;

	public GameTalentServer(ISqlSugarClient db, ILogger<GameTalentServer> logger, IMapper mapper, IActionService actionService)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_actionService = actionService;
	}

	public async Task<GameActionResult> TalentSkillUse(TalentSkillUseRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.InvenIndex);
		TalentTable talent = TalentManager.GetTalent(CharManager.GetCharData(charInfoDao.Id).TalentId);
		TalentGrowthTable talentGrowth = TalentManager.GetTalentGrowth(talent.GrowthGroupId, charInfoDao.TalentLevel);
		TalentSkillTable talentSkill = TalentManager.GetTalentSkill(talent.TalentSkillGroupId, charInfoDao.TalentLevel);
		float num = talentSkill.ValueList[1];
		TalentSkillDBInfo talentSkillInfo = new TalentSkillDBInfo
		{
			GroupId = talentSkill.GroupId,
			EndTime = TimestampUtil.ConvertToTimestamp(DateTime.Now.AddSeconds(num))
		};
		TalentSkillUseResponse talentSkillUseResponse = new TalentSkillUseResponse
		{
			TalentSkillInfo = talentSkillInfo,
			IsSuccess = true
		};
		int num2 = charInfoDao.TalentExp + talentSkill.GetExp;
		if (num2 >= talentGrowth.NeedExp)
		{
			talentSkillUseResponse.AddTalentExp = talentGrowth.NeedExp - charInfoDao.TalentExp;
			charInfoDao.TalentExp = talentGrowth.NeedExp;
		}
		else
		{
			charInfoDao.TalentExp = num2;
			talentSkillUseResponse.AddTalentExp = talentSkill.GetExp;
		}
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(talentSkillUseResponse);
	}

	public async Task<GameActionResult> TalentSkillUpgrade(TalentSkillUpgradeRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.InvenIndex);
		charInfoDao.TalentLevel++;
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new TalentSkillUpgradeResponse());
	}

	public async Task<GameActionResult> EquipMaking(EquipMakingRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.InvenIndex);
		TalentTable talent = TalentManager.GetTalent(CharManager.GetCharData(charInfoDao.Id).TalentId);
		List<TalentGrowthTable> list = new List<TalentGrowthTable>();
		for (int num = 1; num <= charInfoDao.TalentLevel; num++)
		{
			list.Add(TalentManager.GetTalentGrowth(talent.GrowthGroupId, num));
		}
		int needExp = list.Sum((TalentGrowthTable x) => x.NeedExp);
		TalentSkillTable talentSkillTable = TalentManager.GetTalentSkill(talent.TalentSkillGroupId, charInfoDao.TalentLevel);
		List<EquipmentTable> randomEquipmentList = Bd2.Server.Common.Utils.RandomUtil.GetRandomEquipmentList(RewardManager.GetRewardGroupTableByRandomBoxId(EquipmentManager.GetEquipmentMakingTableById(req.MakingId).ResultItemId), req.MakingCount);
		List<EquipDBInfo> equipDbInfos = new List<EquipDBInfo>();
		foreach (EquipmentTable item2 in randomEquipmentList)
		{
			EquipBaseInfo equipBaseInfo = new EquipBaseInfo();
			EquipInfoDao equipInfoDao = new EquipInfoDao
			{
				Uid = long.Parse(uid),
				Id = item2.Id,
				Rank = "[0, 0, 0]",
				SlotType = item2.SlotType
			};
			equipBaseInfo.Id = equipInfoDao.Id;
			equipBaseInfo.Rank.AddRange(new int[3]);
			RepeatedField<EquipOptionInfo> repeatedField = new RepeatedField<EquipOptionInfo>();
			foreach (int item3 in item2.MainOptionGroupId)
			{
				EquipmentOptionTable randomEquipmentOptions = EquipmentManager.GetRandomEquipmentOptions(item3);
				EquipOptionInfo item = new EquipOptionInfo
				{
					GroupId = randomEquipmentOptions.GroupId,
					Id = randomEquipmentOptions.Id
				};
				repeatedField.Add(item);
			}
			equipBaseInfo.MainOption.AddRange(repeatedField);
			equipInfoDao.MainOption = JsonConvert.SerializeObject(repeatedField);
			foreach (int item4 in item2.PrivateUniqueOptionGroupId)
			{
				EquipmentOptionTable randomEquipmentOptions2 = EquipmentManager.GetRandomEquipmentOptions(item4);
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
			int num2 = await _db.Insertable(equipInfoDao).ExecuteReturnIdentityAsync();
			equipDbInfos.Add(new EquipDBInfo
			{
				InvenIndex = num2,
				BaseInfo = equipBaseInfo
			});
		}
		BuyItem(req.ItemInfo.ToList());
		EquipMakingResponse equipMakingResponse = new EquipMakingResponse();
		int num3 = charInfoDao.TalentExp + talentSkillTable.GetExp * req.MakingCount;
		if (num3 >= needExp)
		{
			equipMakingResponse.AddTalentExp = needExp - charInfoDao.TalentExp;
			charInfoDao.TalentExp = needExp;
		}
		else
		{
			charInfoDao.TalentExp = num3;
			equipMakingResponse.AddTalentExp = talentSkillTable.GetExp * req.MakingCount;
		}
		equipMakingResponse.EquipInfo.AddRange(equipDbInfos);
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(equipMakingResponse);
	}

	public async Task<GameActionResult> Alchemy(AlchemyRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.InvenIndex);
		TalentTable talent = TalentManager.GetTalent(CharManager.GetCharData(charInfoDao.Id).TalentId);
		List<TalentGrowthTable> list = new List<TalentGrowthTable>();
		for (int num = 1; num <= charInfoDao.TalentLevel; num++)
		{
			list.Add(TalentManager.GetTalentGrowth(talent.GrowthGroupId, num));
		}
		int num2 = list.Sum((TalentGrowthTable x) => x.NeedExp);
		TalentSkillTable talentSkill = TalentManager.GetTalentSkill(talent.TalentSkillGroupId, charInfoDao.TalentLevel);
		AlchemyTable alchemyTableById = TalentManager.GetAlchemyTableById(req.AlchemyId);
		ItemDBInfo item = _actionService.SendItemToBag(alchemyTableById.ResultItemId, alchemyTableById.ResultItemType, alchemyTableById.ResultItemCount * req.AlchemyCount, uid);
		BuyItem(req.ItemInfo.ToList());
		AlchemyResponse alchemyResponse = new AlchemyResponse();
		int num3 = charInfoDao.TalentExp + talentSkill.GetExp * req.AlchemyCount;
		if (num3 >= num2)
		{
			alchemyResponse.AddTalentExp = num2 - charInfoDao.TalentExp;
			charInfoDao.TalentExp = num2;
		}
		else
		{
			charInfoDao.TalentExp = num3;
			alchemyResponse.AddTalentExp = talentSkill.GetExp * req.AlchemyCount;
		}
		alchemyResponse.ItemInfo.Add(item);
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(alchemyResponse);
	}

	public async Task<GameActionResult> AlchemyBatch(AlchemyBatchRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.InvenIndex);
		TalentTable talent = TalentManager.GetTalent(CharManager.GetCharData(charInfoDao.Id).TalentId);
		List<TalentGrowthTable> list = new List<TalentGrowthTable>();
		for (int num = 1; num <= charInfoDao.TalentLevel; num++)
		{
			list.Add(TalentManager.GetTalentGrowth(talent.GrowthGroupId, num));
		}
		int num2 = list.Sum((TalentGrowthTable x) => x.NeedExp);
		TalentSkillTable talentSkill = TalentManager.GetTalentSkill(talent.TalentSkillGroupId, charInfoDao.TalentLevel);
		AlchemyTable alchemyTable = TalentManager.GetAlchemyTableById(req.AlchemyId);
		ItemDBInfo item = _actionService.SendItemToBag(alchemyTable.ResultItemId, alchemyTable.ResultItemType, alchemyTable.ResultItemCount * req.AlchemyCount, uid);
		BuyItem(req.ItemInfo.ToList());
		AlchemyBatchResponse alchemyBatchResponse = new AlchemyBatchResponse();
		int num3 = charInfoDao.TalentExp + talentSkill.GetExp * req.AlchemyCount;
		if (num3 >= num2)
		{
			alchemyBatchResponse.AddTalentExp = num2 - charInfoDao.TalentExp;
			charInfoDao.TalentExp = num2;
		}
		else
		{
			charInfoDao.TalentExp = num3;
			alchemyBatchResponse.AddTalentExp = talentSkill.GetExp * req.AlchemyCount;
		}
		alchemyBatchResponse.ItemInfo.Add(item);
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(alchemyBatchResponse);
	}

	private void BuyItem(List<ItemDBInfo> items)
	{
		foreach (ItemDBInfo item in items)
		{
			(from x in _db.Updateable<ItemInfoDao>().SetColumns((ItemInfoDao x) => x.Count == x.Count - item.Count)
				where x.InvenIndex == item.InvenIndex
				select x).ExecuteCommand();
		}
	}
}
