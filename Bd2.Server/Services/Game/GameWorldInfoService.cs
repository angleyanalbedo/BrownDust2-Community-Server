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

public class GameWorldInfoService : IGameWorldInfoService
{
	private readonly ILogger<GameWorldInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameWorldInfoService(ILogger<GameWorldInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult PackInfo(string data, string uid)
	{
		List<QuestInfoDao> list = (from x in _db.Queryable<QuestInfoDao>()
			where x.Uid == long.Parse(uid)
			select x).ToList();
		PackInfoResponse packInfoResponse = new PackInfoResponse();
		foreach (IGrouping<int, QuestInfoDao> packGroup in list.GroupBy((QuestInfoDao x) => x.PackId))
		{
			if (packGroup.Count() > 1)
			{
				_logger.LogWarning("PackInfo: duplicate PackId={PackId} for uid={Uid}, rows={Rows}; using the latest row", packGroup.Key, uid, packGroup.Count());
			}
			QuestInfoDao item = packGroup.OrderByDescending((QuestInfoDao x) => x.Index).First();
			int count = JsonConvert.DeserializeObject<List<int>>(item.QuestClear).Count;
			packInfoResponse.PackInfo.Add(new PackDBInfo
			{
				Id = item.PackId,
				ClearQuestCount = count,
				IsPackComplete = (item.IsPackComplete == 1)
			});
		}
		if (packInfoResponse.PackInfo.Where((PackDBInfo x) => x.Id == 3).ToList().Count != 0)
		{
			int[] array = new int[6] { 3001, 3002, 3003, 3004, 3005, 3006 };
			foreach (int id in array)
			{
				if (packInfoResponse.PackInfo.All((PackDBInfo x) => x.Id != id))
				{
					packInfoResponse.PackInfo.Add(new PackDBInfo
					{
						Id = id
					});
				}
			}
		}
		return ResultUtil.CreateResult(packInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult FieldTrapInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FieldTrapInfoResponse();
		var list = _db.Queryable<FieldTrapInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.FieldTrapDbInfo.Add(new FieldTrapDBInfo
			{
				PackId = dao.PackId,
				MapId = dao.MapId,
				TrapId = dao.TrapId,
				State = dao.State
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult WaypointInfo(string data, string uid)
	{
		FieldTrapInfoRequest fieldTrapInfoRequest = ProtoUtil.Deserialize<FieldTrapInfoRequest>(data);
		WayPointInfoDao wayPointInfoDao = _db.Queryable<WayPointInfoDao>().Single((WayPointInfoDao it) => it.Uid == long.Parse(uid) && it.PackId == fieldTrapInfoRequest.PackId);
		WaypointInfoResponse waypointInfoResponse = new WaypointInfoResponse();
		if (wayPointInfoDao != null)
		{
			waypointInfoResponse.WaypointId.AddRange(JsonConvert.DeserializeObject<int[]>(wayPointInfoDao.PointId));
		}
		return ResultUtil.CreateResult(waypointInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult SkyWayScheduleInfo(string data, string uid)
	{
		var response = new SkyWayScheduleInfoResponse();
		var list = _db.Queryable<SkyWayScheduleConfigDao>().ToList();
		foreach (var dao in list)
		{
			var scheduleInfo = new SkyWayScheduleDBInfo
			{
				GroupId = dao.GroupId,
				BonusRate = dao.BonusRate
			};
			if (!string.IsNullOrEmpty(dao.Day))
			{
				var days = JsonConvert.DeserializeObject<List<int>>(dao.Day);
				if (days != null) scheduleInfo.Day.Add(days);
			}
			response.ScheduleInfo.Add(scheduleInfo);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FieldObjectInfo(string data, string uid)
	{
		var request = ProtoUtil.Deserialize<FieldObjectInfoRequest>(data);
		long uidLong = long.Parse(uid);
		var response = new FieldObjectInfoResponse();
		var states = _db.Queryable<FieldObjectStateDao>()
			.Where(x => x.Uid == uidLong && x.PackId == request.PackId).ToList();
		foreach (var state in states)
		{
			if (state.IsRewardObtained == 1)
				response.FieldRewardObtainInfo.Add(new FieldObjectDBInfo { Id = state.ObjectId });
			if (state.MapId != 0)
				response.FieldActionObjectInfo.Add(new FieldObjectDBInfo
				{
					Id = state.ObjectId,
					Position = new FieldObjectPositionDBInfo { MapId = state.MapId, X = (float)state.X, Y = (float)state.Y, Z = (float)state.Z }
				});
		}
		_logger.LogInformation("FieldObjectInfo: packId={PackId}, states={Count}, uid={Uid}", request.PackId, states.Count, uid);
		return ResultUtil.CreateResult(response.ToByteArray(), 28);
	}

	[BatchEndpoint]
	public GameActionResult SkyWayInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new SkyWayInfoResponse();
		var list = _db.Queryable<SkyWayInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.SkyWayInfo.Add(new SkyWayDBInfo
			{
				IsAuto = dao.IsAuto == 1,
				GroupId = dao.GroupId,
				CurrentId = dao.CurrentId,
				MaxClearLevel = dao.MaxClearLevel
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult PackInGameInfo(string data, string uid)
	{
		PackInGameInfoRequest packInGameInfoRequest = PackInGameInfoRequest.Parser.ParseFrom(Convert.FromBase64String(data));
		PackInGameInfoResponse packInGameInfoResponse = new PackInGameInfoResponse();
		PositionInfoDao positionInfoDao = _db.Queryable<PositionInfoDao>().Single((PositionInfoDao x) => x.Uid == long.Parse(uid) && x.PackId == packInGameInfoRequest.PackId);
		packInGameInfoResponse.Position = ((positionInfoDao == null) ? "{}" : positionInfoDao.Position);
		foreach (MapActiveInfoDao item in (from x in _db.Queryable<MapActiveInfoDao>()
			where x.Uid == long.Parse(uid) && x.PackId == packInGameInfoRequest.PackId
			select x).ToList())
		{
			MapActiveInfo mapActiveInfo = new MapActiveInfo
			{
				MapId = item.MapId
			};
			mapActiveInfo.ActiveInfo.AddRange(JsonConvert.DeserializeObject<string[]>(item.Active));
			packInGameInfoResponse.MapActiveInfo.Add(mapActiveInfo);
		}
		packInGameInfoResponse.HuntingGroundInfo = new HuntingGroundDBInfo();
		QuestInfoDao questInfoDao = _db.Queryable<QuestInfoDao>().Single((QuestInfoDao x) => x.PackId == packInGameInfoRequest.PackId && x.Uid == long.Parse(uid));
		if (questInfoDao == null)
		{
			packInGameInfoResponse.QuestInfo.Add(new QuestDBInfo
			{
				Id = 1
			});
		}
		else
		{
			packInGameInfoResponse.ClearQuestIds.AddRange(JsonConvert.DeserializeObject<int[]>(questInfoDao.QuestClear));
			if (questInfoDao.QuestId != 0)
			{
				packInGameInfoResponse.QuestInfo.Add(new QuestDBInfo
				{
					Id = questInfoDao.QuestId
				});
			}
		}
		_logger.LogInformation("PackInGameInfo: uid={Uid}, packId={PackId}, activeQuestIds=[{QuestIds}], clearQuestIds=[{ClearQuestIds}]",
			uid,
			packInGameInfoRequest.PackId,
			string.Join(",", packInGameInfoResponse.QuestInfo.Select(x => x.Id)),
			string.Join(",", packInGameInfoResponse.ClearQuestIds));
		(from it in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.LastPlayPackId == packInGameInfoRequest.PackId)
			where it.OwnerIndex == long.Parse(uid)
			select it).ExecuteCommand();
		if (packInGameInfoRequest.PackId < 1010)
		{
			List<MonsterDBInfo> monsterInfoListByPackId = BattleDeckManager.GetMonsterInfoListByPackId(packInGameInfoRequest.PackId);
			packInGameInfoResponse.MonsterInfo.AddRange(monsterInfoListByPackId);
		}
		packInGameInfoResponse.ReputationInfo.Add(new ReputationDBInfo
		{
			GroupId = 1,
			State = 1,
			ElapsedSeconds = 10086
		});
		return ResultUtil.CreateResult(packInGameInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult SaveFieldCharControlDeckType(string data, string uid)
	{
		var req = ProtoUtil.Deserialize<SaveFieldCharControlDeckTypeRequest>(data);
		_logger.LogInformation("SaveFieldCharControlDeckType: Seq={}, Type={}", req.Seq, req.FieldCharControlDeckType);
		return ResultUtil.CreateResult(new SaveFieldCharControlDeckTypeResponse());
	}

	[BatchEndpoint]
	public GameActionResult FieldDeckInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FieldDeckInfoResponse();
		var list = _db.Queryable<FieldDeckInfoDao>().Where(x => x.Uid == uidLong).ToList();
		if (list.Count > 0)
		{
			response.FieldDeckInfo.AddRange(_mapper.Map<List<FieldDeckDBInfo>>(list));
		}
		else
		{
			var firstChar = _db.Queryable<CharInfoDao>().First(x => x.Uid == uidLong);
			if (firstChar != null)
			{
				response.FieldDeckInfo.Add(new FieldDeckDBInfo
				{
					Sequence = 1,
					CharInvenIndex = firstChar.InvenIndex,
					CostumeInvenIndex = firstChar.UseCostume
				});
			}
			else
			{
				firstChar = _db.Queryable<CharInfoDao>().First();
                response.FieldDeckInfo.Add(new FieldDeckDBInfo
                {
                    Sequence = 1,
                    CharInvenIndex = firstChar.InvenIndex,
                    CostumeInvenIndex = firstChar.UseCostume
                });
            }
		}
		return ResultUtil.CreateResult(response);
        }

	[BatchEndpoint]
	public GameActionResult FieldEventSpawnInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FieldEventSpawnInfoResponse();
		var dao = _db.Queryable<FieldEventSpawnInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.CurrentProgress = new FieldEventSpawnProgressInfo
			{
				StartTime = dao.StartTime,
				EventScheduleId = dao.EventScheduleId,
				SpawnEventId = dao.SpawnEventId,
				GroupId = dao.GroupId
			};
			if (!string.IsNullOrEmpty(dao.CaughtInfo))
			{
				var caughtList = JsonConvert.DeserializeObject<List<FieldEventSpawnCaughtInfo>>(dao.CaughtInfo);
				if (caughtList != null)
				{
					response.CurrentProgress.CaughtInfo.AddRange(caughtList);
				}
			}
			response.DailyNormalCount = dao.DailyNormalCount;
			response.DailySpecialCount = dao.DailySpecialCount;
		}
		return ResultUtil.CreateResult(response);
	}
}
