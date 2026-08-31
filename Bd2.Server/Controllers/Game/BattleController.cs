using System;
using Bd2.Server.Common.Cache;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices;
using Bd2.Server.DAO.Game;
using Google.Protobuf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class BattleController : ControllerBase
{
	private readonly ILogger<BattleController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IActionService _actionService;

	public BattleController(ILogger<BattleController> logger, ISqlSugarClient db, IActionService actionService)
	{
		_db = db;
		_logger = logger;
		_actionService = actionService;
	}

	[HttpPut]
	public GameActionResult BattleEnter([FromBody] string data)
	{
		BattleEnterRequest battleEnterRequest = ProtoUtil.Deserialize<BattleEnterRequest>(data);
		BattleEnterResponse battleEnterResponse = new BattleEnterResponse();
		battleEnterResponse.BattleDeck = battleEnterRequest.BattleDeck;
		battleEnterResponse.EventScheduleInfo = new EventScheduleDBInfo
		{
			Id = 345,
			EventType = Define_EventType.EventWorldBuff,
			EventId = 5,
			StartDate = 1722470400000L,
			EndDate = 1753593599000L
		};
		battleEnterResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.HealthPercent,
			StatValue = 0.8
		});
		battleEnterResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.AttackPercent,
			StatValue = 0.8
		});
		battleEnterResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.MagicPercent,
			StatValue = 0.8
		});
		BattleDeckCache.CacheInsertAddMinutes(base.User.FindFirst("user").Value, battleEnterRequest, 60);
		return ResultUtil.CreateResult(battleEnterResponse.ToByteArray(), 52);
	}

	[HttpPut]
	public GameActionResult BattleStart([FromBody] string data)
	{
		BattleStartRequest battleStartRequest = ProtoUtil.Deserialize<BattleStartRequest>(data);
		BattleStartResponse message = new BattleStartResponse
		{
			BattleRandomSeed = new Random().Next(0, 1000000)
		};
		return ResultUtil.CreateResult(message.ToByteArray(), 14);
	}

	[HttpPut]
	public GameActionResult BattleEnd([FromBody] string data)
	{
		BattleEndRequest battleEndRequest = ProtoUtil.Deserialize<BattleEndRequest>(data);
		BattleEnterRequest battleEnterRequest = (BattleEnterRequest)BattleDeckCache.CacheValue(base.User.FindFirst("user").Value);
		BattleDeckCache.CacheNull(base.User.FindFirst("user").Value);
		BattleDeckTable battleDeckTable = BattleDeckManager.GetBattleDeckTable(battleEndRequest.PackId, battleEnterRequest.BattleDeck);
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		for (int i = 0; i < battleDeckTable.RewardId.Count; i++)
		{
			ItemDBInfo itemDBInfo = new ItemDBInfo();
			if (battleDeckTable.RewardType[i] <= 4)
			{
				_actionService.SendItemToUser(battleDeckTable.RewardId[i], battleDeckTable.RewardType[i], battleDeckTable.RewardCount[i], base.User.FindFirst("user").Value);
				itemDBInfo.Type = battleDeckTable.RewardType[i];
				itemDBInfo.Count = battleDeckTable.RewardCount[i];
			}
			else if (battleDeckTable.RewardType[i] == 9)
			{
				RandomBoxTable randomBoxTableByRandom = RewardManager.GetRandomBoxTableByRandom();
				itemDBInfo = _actionService.SendItemToBag(randomBoxTableByRandom.Id, battleDeckTable.RewardType[i], battleDeckTable.RewardCount[i], base.User.FindFirst("user").Value);
			}
			else
			{
				itemDBInfo = _actionService.SendItemToBag(battleDeckTable.RewardId[i], battleDeckTable.RewardType[i], battleDeckTable.RewardCount[i], base.User.FindFirst("user").Value);
			}
			rewardDBInfoBundle.ItemInfo.Add(itemDBInfo);
		}
		foreach (CharDBInfo charDbInfo in battleEndRequest.CharInfo)
		{
			CharInfoDao charInfoDao = _db.Queryable<CharInfoDao>().Single((CharInfoDao x) => x.InvenIndex == charDbInfo.InvenIndex);
			if (charDbInfo.Hp > charInfoDao.Hp)
			{
				charInfoDao.Hp = charDbInfo.Hp;
				_db.Updateable(charInfoDao).ExecuteCommand();
			}
		}
		BattleEndResponse battleEndResponse = new BattleEndResponse();
		battleEndResponse.BattleResult = battleEndRequest.BattleResult;
		battleEndResponse.CharInfo.AddRange(battleEndRequest.CharInfo);
		battleEndResponse.RewardBundle = rewardDBInfoBundle;
		return ResultUtil.CreateResult(battleEndResponse.ToByteArray(), 14);
	}

	[HttpPut]
	public GameActionResult BattleVerifyState([FromBody] string data)
	{
		BattleVerifyStateRequest battleVerifyStateRequest = ProtoUtil.Deserialize<BattleVerifyStateRequest>(data);
		BattleVerifyStateResponse battleVerifyStateResponse = new BattleVerifyStateResponse();
		battleVerifyStateResponse.State = 3;
		battleVerifyStateResponse.TeamType = Define_TeamType.TtBlue;
		return ResultUtil.CreateResult(battleVerifyStateResponse.ToByteArray(), 14);
	}

	[HttpPut]
	public GameActionResult FieldMonsterEvent([FromBody] string data)
	{
		FieldMonsterEventRequest fieldMonsterEventRequest = ProtoUtil.Deserialize<FieldMonsterEventRequest>(data);
		_logger.LogWarning("场景怪物事件 {}", fieldMonsterEventRequest);
		FieldMonsterEventResponse fieldMonsterEventResponse = new FieldMonsterEventResponse();
		fieldMonsterEventResponse.MonsterInfo = new MonsterDBInfo
		{
			MonsterId = 4001,
			RespawnTime = 1722643200000L,
			GroupId = 3,
			ActiveFlag = true
		};
		RandomBoxTable randomBoxTableByRandom = RewardManager.GetRandomBoxTableByRandom();
		ItemDBInfo item = _actionService.SendItemToBag(randomBoxTableByRandom.Id, 9, 1, base.User.FindFirst("user").Value);
		fieldMonsterEventResponse.ItemInfo.Add(item);
		return ResultUtil.CreateResult(fieldMonsterEventResponse.ToByteArray(), 14);
	}

	[HttpPut]
	public GameActionResult FieldObjectReward([FromBody] string data)
	{
		FieldObjectRewardRequest fieldObjectRewardRequest = ProtoUtil.Deserialize<FieldObjectRewardRequest>(data);
		long uid = long.Parse(base.User.FindFirst("user").Value);
		var state = _db.Queryable<FieldObjectStateDao>().First(x => x.Uid == uid && x.PackId == fieldObjectRewardRequest.PackId && x.GroupId == fieldObjectRewardRequest.FieldObjectGroupId && x.ObjectId == fieldObjectRewardRequest.FieldObjectId);
		if (state == null)
		{
			state = new FieldObjectStateDao { Uid = uid, PackId = fieldObjectRewardRequest.PackId, GroupId = fieldObjectRewardRequest.FieldObjectGroupId, ObjectId = fieldObjectRewardRequest.FieldObjectId };
		}
		if (state.IsRewardObtained == 1)
			return ResultUtil.CreateResult(new FieldObjectRewardResponse());
		state.IsRewardObtained = 1;
		_db.Storageable(state).WhereColumns(x => new { x.Uid, x.PackId, x.GroupId, x.ObjectId }).ExecuteCommand();
		FieldObjectRewardResponse fieldObjectRewardResponse = new FieldObjectRewardResponse();
		fieldObjectRewardResponse.MonsterInfo = new MonsterDBInfo
		{
			ActiveFlag = true
		};
		RewardDBInfoBundle rewardDBInfoBundle = new RewardDBInfoBundle();
		ItemDBInfo item = _actionService.SendItemToBag(13, 8, 1, base.User.FindFirst("user").Value);
		rewardDBInfoBundle.ItemInfo.Add(item);
		fieldObjectRewardResponse.RewardInfoBundle = rewardDBInfoBundle;
		return ResultUtil.CreateResult(fieldObjectRewardResponse);
	}
}
