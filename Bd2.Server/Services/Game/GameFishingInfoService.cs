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

public class GameFishingInfoService : IGameFishingInfoService
{
	private readonly ILogger<GameFishingInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameFishingInfoService(ILogger<GameFishingInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult FishingItemInfo(string data, string uid)
	{
		long uidLong = long.Parse(uid);
		var response = new FishingItemInfoResponse();
		foreach (var fish in _db.Queryable<FishingCollectionInfoDao>().Where(x => x.Uid == uidLong).ToList())
			response.FishInfo.Add(new FishingFishDBInfo { Id = fish.FishId, Size = fish.MaxSize, TimeValue = fish.CreateTime });
		var fishing = _db.Queryable<FishingInfoDao>().First(x => x.Uid == uidLong);
		if (fishing != null && fishing.UseRodInvenIndex != 0)
		{
			var rod = _db.Queryable<ItemInfoDao>().First(x => x.Uid == uidLong && x.InvenIndex == fishing.UseRodInvenIndex);
			if (rod != null) response.RodInfo.Add(new FishingRodDBInfo { InvenIndex = rod.InvenIndex, Id = rod.Id, TimeValue = rod.TimeValue });
		}
		foreach (var item in _db.Queryable<ItemInfoDao>().Where(x => x.Uid == uidLong && x.Count > 0).ToList())
			response.ItemInfo.Add(new FishingItemDBInfo { InvenIndex = item.InvenIndex, Id = item.Id, Type = item.Type, Count = item.Count, TimeValue = item.TimeValue });
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FishingInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FishingInfoResponse();
		var dao = _db.Queryable<FishingInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.FishInfo = new FishingDBInfo
			{
				Exp = dao.Exp,
				Level = dao.Level,
				BoatLevel = dao.BoatLevel,
				BoatSkinId = dao.BoatSkinId,
				UseRodInvenIndex = dao.UseRodInvenIndex,
				MultiApResetTime = dao.MultiApResetTime
			};
			if (!string.IsNullOrEmpty(dao.MapId))
			{
				var mapIds = JsonConvert.DeserializeObject<List<int>>(dao.MapId);
				if (mapIds != null) response.MapId.Add(mapIds);
			}
			if (!string.IsNullOrEmpty(dao.BoatSkinIds))
			{
				var skinIds = JsonConvert.DeserializeObject<List<int>>(dao.BoatSkinIds);
				if (skinIds != null) response.BoatSkinId.Add(skinIds);
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FishingCollectionInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FishingCollectionInfoResponse();
		var list = _db.Queryable<FishingCollectionInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.CollectionInfo.Add(new FishingCollectionDBInfo
			{
				FishId = dao.FishId,
				MaxSize = dao.MaxSize,
				MinSize = dao.MinSize,
				CreateTime = dao.CreateTime
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FishingTrapInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FishingTrapInfoResponse();
		var list = _db.Queryable<FishingTrapInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.FishTrapInfo.Add(new FishingTrapDBInfo
			{
				FishId = dao.FishId,
				Size = dao.Size
			});
		}
		if (list.Count > 0)
		{
			var first = list[0];
			response.TrapRewardReceiptTime = first.TrapRewardReceiptTime;
			response.TotalAddExp = first.TotalAddExp;
			response.AfterLevel = first.AfterLevel;
			response.AfterExp = first.AfterExp;
		}
		return ResultUtil.CreateResult(response);
	}
}
