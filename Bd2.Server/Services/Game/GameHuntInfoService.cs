using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;

namespace Bd2.Server.Services.Game;

public class GameHuntInfoService : IGameHuntInfoService
{
	private readonly ILogger<GameHuntInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameHuntInfoService(ILogger<GameHuntInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult DispatchInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new DispatchInfoResponse();
		var dispatchList = _db.Queryable<DispatchInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in dispatchList)
		{
			response.DispatchInfo.Add(new DispatchDBInfo
			{
				Id = dao.DispatchId,
				EndTime = dao.StartTime
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MonsterHuntDeckInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MonsterHuntDeckInfoResponse();
		var deckList = _db.Queryable<MonsterHuntDeckInfoDao>().Where(x => x.Uid == uidLong).ToList();
		var grouped = deckList.GroupBy(x => x.Slot);
		foreach (var group in grouped)
		{
			var deckInfo = new MonsterHuntDeckDBInfo { Team = group.Key };
			foreach (var dao in group.OrderBy(x => x.CharInvenIndex))
			{
				deckInfo.DeckInfo.Add(new DeckDBInfo
				{
					CharInvenIndex = dao.CharInvenIndex,
					Sequence = group.ToList().IndexOf(dao)
				});
			}
			response.MonsterHuntDeckInfo.Add(deckInfo);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult HuntDispatchInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new HuntDispatchInfoResponse();
		var dispatchList = _db.Queryable<HuntDispatchInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in dispatchList)
		{
			response.HuntDispatchInfo.Add(new HuntDispatchDBInfo
			{
				HuntDispatchId = dao.DispatchId,
				StartTime = dao.StartTime
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MonsterHuntScheduleInfo(string data, string uid)
	{
		var response = new MonsterHuntScheduleInfoResponse();
		var config = _db.Queryable<MonsterHuntScheduleConfigDao>().First();
		if (config != null)
		{
			response.StartRegularSeason = config.StartRegularSeason;
			response.MonsterHuntScheduleInfo = new MonsterHuntScheduleInfo
			{
				SeasonInfo = new SeasonInfo
				{
					Season = config.Season,
					StartTime = config.SeasonStartTime,
					EndTime = config.SeasonEndTime
				},
				MonsterHuntId = config.MonsterHuntId,
				InfoOpenDay = config.InfoOpenDay,
				CalculateEndDate = config.CalculateEndDate
			};
		}
		var histories = _db.Queryable<MonsterHuntScheduleHistoryDao>().ToList();
		foreach (var history in histories)
		{
			response.SeasonHistory.Add(new MonsterHuntScheduleHistory
			{
				Season = history.Season,
				MonsterHuntId = history.MonsterHuntId
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MonsterHuntUserInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MonsterHuntUserInfoResponse();
		var dao = _db.Queryable<MonsterHuntUserInfoDao>().First(x => x.Uid == uidLong);
		var schedule = _db.Queryable<MonsterHuntScheduleConfigDao>().First();
		if (dao != null || schedule != null)
		{
			response.MonsterHuntUserInfo = new MonsterHuntUserDBInfo
			{
				Season = dao?.Season ?? schedule!.Season,
				MonsterHuntId = schedule?.MonsterHuntId ?? 0,
				Level = Math.Max(1, dao?.Rank ?? 1),
				StartHp = 0,
				HighestFirstTurnDamage = 0,
				HighestHp = dao?.MaxScore ?? 0,
				HighestHpDate = 0,
				CurrentLevelHighestDamage = dao?.Score ?? 0,
				DailyHighestDamage = 0,
				SeasonReward = false
			};
			response.Rank = Math.Max(1, dao?.Rank ?? 1);
		}
		return ResultUtil.CreateResult(response);
	}
}
