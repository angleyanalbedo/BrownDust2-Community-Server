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

public class GameShopInfoService : IGameShopInfoService
{
	private readonly ILogger<GameShopInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameShopInfoService(ILogger<GameShopInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult CashShopInfo(string data, string uid)
	{
		var response = new CashShopInfoResponse();
		var list = _db.Queryable<CashShopConfigDao>().ToList();
		foreach (var dao in list)
		{
			response.ProductInfo.Add(new CashProductDBInfo
			{
				GroupId = dao.GroupId,
				Id = dao.ProductId,
				SaleGroup = dao.SaleGroup,
				StartTime = dao.StartTime,
				EndTime = dao.EndTime,
				EndDelayMinutes = dao.EndDelayMinutes
			});
			response.DailyResetTime = dao.DailyResetTime;
			response.WeeklyResetTime = dao.WeeklyResetTime;
			response.MonthlyResetTime = dao.MonthlyResetTime;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult CharScoutInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CharScoutInfoResponse();
		var dao = _db.Queryable<CharScoutInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			if (!string.IsNullOrEmpty(dao.AppearCharIds))
			{
				var charIds = JsonConvert.DeserializeObject<List<int>>(dao.AppearCharIds);
				if (charIds != null) response.AppearCharId.Add(charIds);
			}
			response.UseResetCount = dao.UseResetCount;
			response.NextAutoResetTime = dao.NextAutoResetTime;
			if (!string.IsNullOrEmpty(dao.ScoutCompleteCharIds))
			{
				var completeIds = JsonConvert.DeserializeObject<List<int>>(dao.ScoutCompleteCharIds);
				if (completeIds != null) response.ScoutCompleteCharId.Add(completeIds);
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult CashBonusInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CashBonusInfoResponse();
		var list = _db.Queryable<CashBonusInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			var info = new CashBonusDBInfo
			{
				GroupId = dao.GroupId,
				ContentsGroupId = dao.ContentsGroupId,
				BuyCount = dao.BuyCount
			};
			if (!string.IsNullOrEmpty(dao.RewardedId))
			{
				info.RewardedId.AddRange(JsonConvert.DeserializeObject<int[]>(dao.RewardedId));
			}
			response.BonusInfo.Add(info);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult AvatarShopWishListInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new AvatarShopWishListInfoResponse();
		var list = _db.Queryable<AvatarShopWishListInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.ShopId.Add(dao.ShopId);
		}
		return ResultUtil.CreateResult(response);
	}
}
