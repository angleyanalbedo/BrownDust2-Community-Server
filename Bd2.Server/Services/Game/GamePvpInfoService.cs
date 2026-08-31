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

public class GamePvpInfoService : IGamePvpInfoService
{
	private readonly ILogger<GamePvpInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GamePvpInfoService(ILogger<GamePvpInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult PvpBattleUserInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new PvpBattleUserInfoResponse();
		var dao = _db.Queryable<PvpBattleUserInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.BaseInfo = new PvpBattleUserBaseInfo
			{
				Vp = dao.Vp,
				Rank = dao.Rank,
				WinCount = dao.WinCount,
				LoseCount = dao.LoseCount
			};
			response.IsSeasonReward = dao.IsSeasonReward == 1;
			response.PvpTableChangeSeason = dao.PvpTableChangeSeason;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult ColosseumUserInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new ColosseumUserInfoResponse();
		var dao = _db.Queryable<ColosseumUserInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.Season = dao.Season;
			response.RegularSeason = dao.RegularSeason;
			response.RankTableChangeSeason = dao.RankTableChangeSeason;
			response.BaseInfo = new ColosseumUserBaseInfo
			{
				Vp = dao.Vp,
				Rank = dao.Rank,
				WinCount = dao.WinCount,
				LoseCount = dao.LoseCount,
				TopPercent = dao.TopPercent
			};
			response.IsSeasonReward = dao.IsSeasonReward == 1;
			response.ApBuyCount = dao.ApBuyCount;
		}
		return ResultUtil.CreateResult(response);
	}
}
