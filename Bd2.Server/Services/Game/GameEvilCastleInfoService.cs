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

public class GameEvilCastleInfoService : IGameEvilCastleInfoService
{
	private readonly ILogger<GameEvilCastleInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameEvilCastleInfoService(ILogger<GameEvilCastleInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleRogueLikeAllUserScoreInfo(string data, string uid)
	{
		var totalScore = _db.Queryable<EvilCastleRogueLikeInfoDao>().Sum(x => x.Obsidian);
		return ResultUtil.CreateResult(new EvilCastleRogueLikeAllUserScoreInfoResponse
		{
			AllUserTotalScore = totalScore
		});
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EvilCastleInfoResponse();
		var list = _db.Queryable<EvilCastleInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.EvilCastleInfo.Add(new EvilCastleDBInfo
			{
				Rank = dao.Rank,
				StageIndex = dao.StageIndex,
				Retry = dao.Retry,
				Point = dao.Point,
				SeasonHighestPoint = dao.SeasonHighestPoint,
				IsRewarded = dao.IsRewarded == 1,
				StageClearTime = dao.StageClearTime
			});
			response.Season = dao.Season;
			response.RegularSeason = dao.RegularSeason;
		}
		if (list.Count > 0)
		{
			var first = list[0];
			response.EvilCastleTotalInfo = new EvilCastleTotalDBInfo
			{
				Rank = first.TotalRank,
				Point = first.TotalPoint,
				IsRewarded = first.TotalIsRewarded == 1
			};
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleTowerInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EvilCastleTowerInfoResponse();
		var list = _db.Queryable<EvilCastleTowerInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			var towerInfo = new EvilCastleTowerDBInfo
			{
				Id = dao.TowerId,
				BattleMode = dao.BattleMode
			};
			if (!string.IsNullOrEmpty(dao.BattleChallengeIndex))
			{
				var indices = JsonConvert.DeserializeObject<List<int>>(dao.BattleChallengeIndex);
				if (indices != null)
				{
					towerInfo.BattleChallengeIndex.Add(indices);
				}
			}
			response.Info.Add(towerInfo);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleEnter(string data, string uid)
	{
		var request = ProtoUtil.Deserialize<EvilCastleEnterRequest>(data);
		long uidLong = long.Parse(uid);
		var response = new EvilCastleEnterResponse();
		response.CharInfo.AddRange(_mapper.Map<List<CharDBInfo>>(_db.Queryable<CharInfoDao>().Where(x => x.Uid == uidLong).ToList()));
		response.DeckInfo.AddRange(_mapper.Map<List<DeckDBInfo>>(_db.Queryable<DeckInfoDao>().Where(x => x.Uid == uidLong).ToList()));
		if (request.PackId > 0 && request.PackId < 1010)
			response.MonsterInfo.AddRange(BattleDeckManager.GetMonsterInfoListByPackId(request.PackId));
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleRogueLikeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EvilCastleRogueLikeInfoResponse();
		var dao = _db.Queryable<EvilCastleRogueLikeInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.StateInfo = new EvilCastleRogueLikeStateInfo
			{
				Floor = dao.Floor,
				Room = dao.Room,
				State = dao.State
			};
			response.Level = dao.Level;
			response.ReRoll = dao.ReRoll;
			response.GroupId = dao.GroupId;
			response.Id = dao.RogueLikeId;
			response.BattleLevel = dao.BattleLevel;
			response.MaxTryLevel = dao.MaxTryLevel;
			response.Obsidian = dao.Obsidian;
			response.RogueLikeGold = dao.RogueLikeGold;
			response.Season = dao.Season;
			response.RegularSeason = dao.RegularSeason;
			response.SeasonReward = dao.IsSeasonReward == 1;
			response.MaxRewardLevel = dao.MaxRewardLevel;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleRewardInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EvilCastleRewardInfoResponse();
		var list = _db.Queryable<EvilCastleInfoDao>().Where(x => x.Uid == uidLong && x.IsRewarded == 1).ToList();
		foreach (var dao in list)
		{
			response.EndSeasonInfo.Add(new EvilCastleEndSeasonDBInfo
			{
				Rank = dao.Rank,
				StageIndex = dao.StageIndex,
				Point = dao.Point,
				IsRewarded = dao.IsRewarded == 1
			});
		}
		if (list.Count > 0)
		{
			var first = list[0];
			response.EndSeasonTotalInfo = new EvilCastleEndSeasonTotalDBInfo
			{
				Rank = first.TotalRank,
				Point = first.TotalPoint,
				IsRewarded = first.TotalIsRewarded == 1
			};
		}
		response.RewardInfoBundle = new RewardDBInfoBundle();
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EvilCastleDailyRewardState(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EvilCastleDailyRewardStateResponse();
		var dao = _db.Queryable<EvilCastleDailyRewardStateDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.IsObtainableDailyReward = dao.IsObtainableDailyReward == 1;
		}
		return ResultUtil.CreateResult(response);
	}
}
