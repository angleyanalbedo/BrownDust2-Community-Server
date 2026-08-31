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

public class GameDeckInfoService : IGameDeckInfoService
{
	private readonly ILogger<GameDeckInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameDeckInfoService(ILogger<GameDeckInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult DeckInfo(string data, string uid)
	{
		DeckInfoResponse deckInfoResponse = new DeckInfoResponse();
		foreach (DeckInfoDao item in (from it in _db.Queryable<DeckInfoDao>()
			where it.Uid == long.Parse(uid)
			select it).ToList())
		{
			deckInfoResponse.DeckInfo.Add(_mapper.Map<DeckDBInfo>(item));
		}
		deckInfoResponse.TalentSlotInfo.AddRange(new int[4]);
		return ResultUtil.CreateResult(deckInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult DeckCostumeSettingInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new DeckCostumeSettingInfoResponse();
		var list = _db.Queryable<DeckCostumeSettingInfoDao>().Where(x => x.Uid == uidLong).ToList();
		var groups = list.GroupBy(x => x.CharInvenIndex);
		foreach (var group in groups)
		{
			var setting = new DeckCostumeSettingDBInfo
			{
				CharInvenIndex = group.Key
			};
			foreach (var dao in group)
			{
				setting.CostumeSeq.Add(new DeckCostumeSettingSeqInfo
				{
					CostumeInvenIndex = dao.CostumeInvenIndex,
					BurstLevel = dao.BurstLevel
				});
			}
			response.CostumeSettingInfo.Add(setting);
		}
		return ResultUtil.CreateResult(response);
	}
}
