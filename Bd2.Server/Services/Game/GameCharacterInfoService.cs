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

public class GameCharacterInfoService : IGameCharacterInfoService
{
	private readonly ILogger<GameCharacterInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameCharacterInfoService(ILogger<GameCharacterInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult CharInfo(string data, string uid)
	{
		List<CharInfoDao> source = (from x in _db.Queryable<CharInfoDao>()
			where x.Uid == (long)int.Parse(uid)
			select x).ToList();
		List<CharDBInfo> values = _mapper.Map<List<CharDBInfo>>(source);
		CharInfoResponse charInfoResponse = new CharInfoResponse();
		charInfoResponse.CharInfo.AddRange(values);
		return ResultUtil.CreateResult(charInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult CostumeInfo(string data, string uid)
	{
		List<CostumeInfoDao> source = (from x in _db.Queryable<CostumeInfoDao>()
			where x.Uid == (long)int.Parse(uid)
			select x).ToList();
		List<CostumeDBInfo> values = _mapper.Map<List<CostumeDBInfo>>(source);
		CostumeInfoResponse costumeInfoResponse = new CostumeInfoResponse();
		costumeInfoResponse.CostumeInfo.AddRange(values);
		return ResultUtil.CreateResult(costumeInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult CharAwakeInfo(string data, string uid)
	{
		List<CharAwakeInfoDao> list = (from x in _db.Queryable<CharAwakeInfoDao>()
			where x.OwnerIndex == long.Parse(uid)
			select x).ToList();
		CharAwakeInfoResponse charAwakeInfoResponse = new CharAwakeInfoResponse();
		foreach (CharAwakeInfoDao item in list)
		{
			charAwakeInfoResponse.CharAwakeInfo.Add(new CharAwakeDBInfo
			{
				UniqueCharId = item.UniqueCharId,
				ImprintSlot1Level = item.ImprintSlot1Level,
				ImprintSlot2Level = item.ImprintSlot2Level,
				ImprintSlot3Level = item.ImprintSlot3Level,
				IsAwake = (item.IsAwake == 1),
				OwnerIndex = item.OwnerIndex
			});
		}
		return ResultUtil.CreateResult(charAwakeInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult AvatarInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new AvatarInfoResponse();
		var dao = _db.Queryable<AvatarInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.AvatarUseInfo = new AvatarUseDBInfo
			{
				UseCharId = dao.UseCharId,
				UseHairId = dao.UseHairId,
				UseHairAccessoryId = dao.UseHairAccessoryId,
				UseFaceAccessoryId = dao.UseFaceAccessoryId,
				UseCostumeId = dao.UseCostumeId,
				UseBodyAccessoryId = dao.UseBodyAccessoryId,
				UseHandAccessoryId = dao.UseHandAccessoryId,
				UsePetId = dao.UsePetId,
				UseMountId = dao.UseMountId,
				UseEffectId = dao.UseEffectId,
				Date = dao.Date
			};
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult PrestigeSkinInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new PrestigeSkinInfoResponse();
		var list = _db.Queryable<PrestigeSkinInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.PrestigeSkinInfo.Add(new PrestigeSkinDBInfo
			{
				CostumeId = dao.CostumeId,
				CostumeDesignId = dao.CostumeDesignId,
				IsSet = dao.IsSet == 1
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult SpineInteractionAchievementInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new SpineInteractionAchievementInfoResponse();
		var list = _db.Queryable<SpineInteractionAchievementInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.SpineInteractionAchievementInfo.Add(new SpineInteractionAchievementDBInfo
			{
				InteractionGroupId = dao.InteractionGroupId,
				GroupId = dao.GroupId
			});
		}
		return ResultUtil.CreateResult(response);
	}
}
