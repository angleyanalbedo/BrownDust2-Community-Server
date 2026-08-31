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

public class GameInventoryInfoService : IGameInventoryInfoService
{
	private readonly ILogger<GameInventoryInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameInventoryInfoService(ILogger<GameInventoryInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult RecipeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new RecipeInfoResponse();
		var list = _db.Queryable<RecipeInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.RecipeId.Add(dao.RecipeId);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MyRoomItemInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MyRoomItemInfoResponse();
		var itemList = _db.Queryable<MyRoomItemInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in itemList)
		{
			response.TrophyInfo.Add(new MyRoomTrophyDBInfo
			{
				InvenIndex = dao.InvenIndex,
				Id = dao.Id,
				ContentsType = dao.Type
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EquipPresetInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EquipPresetInfoResponse();
		var presetList = _db.Queryable<EquipPresetInfoDao>().Where(x => x.Uid == uidLong).ToList();
		var charGroups = presetList.GroupBy(x => x.CharInvenIndex);
		foreach (var charGroup in charGroups)
		{
			var charInfo = new EquipPresetCharInfo
			{
				CharInvenIndex = charGroup.Key
			};
			foreach (var dao in charGroup)
			{
				charInfo.PresetInfo.Add(new EquipPresetDBInfo
				{
					Slot = dao.Slot,
					PresetName = dao.PresetName ?? "",
					PresetResourceId = dao.PresetResourceId,
					PresetResourceColor = dao.PresetResourceColor
				});
			}
			response.CharInfo.Add(charInfo);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult ItemInfo(string data, string uid)
	{
		List<ItemInfoDao> source = (from x in _db.Queryable<ItemInfoDao>()
			where x.Uid == long.Parse(uid)
			select x).ToList();
		List<ItemSpecialInfoDao> source2 = (from x in _db.Queryable<ItemSpecialInfoDao>()
			where x.Uid == long.Parse(uid)
			select x).ToList();
		List<ItemDBInfo> values = _mapper.Map<List<ItemDBInfo>>(source);
		List<ItemDBInfo> values2 = _mapper.Map<List<ItemDBInfo>>(source2);
		ItemInfoResponse itemInfoResponse = new ItemInfoResponse();
		itemInfoResponse.ItemInfo.AddRange(values);
		itemInfoResponse.ItemInfo.AddRange(values2);
		return ResultUtil.CreateResult(itemInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult IdCardPresetInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new IdCardPresetInfoResponse();
		var list = _db.Queryable<IdCardPresetInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.PresetInfo.Add(new IdCardPresetInfo
			{
				Id = dao.PresetId
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult RootSortIdInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new RootSortIdInfoResponse();
		var list = _db.Queryable<RootSortIdInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.RootSortInfo.Add(new RootSortIdInfo
			{
				Type = dao.Type,
				Id = dao.Id,
				SortId = dao.SortId
			});
		}
		return ResultUtil.CreateResult(response);
	}
}
