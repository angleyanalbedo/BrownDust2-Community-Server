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

public class GameEventInfoService : IGameEventInfoService
{
	private readonly ILogger<GameEventInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameEventInfoService(ILogger<GameEventInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult CommunityRewardInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CommunityRewardInfoResponse();
		var list = _db.Queryable<CommunityRewardInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.CommunityRewardInfo.Add(new CommunityRewardDBInfo
			{
				Type = dao.Type,
				SubType = dao.SubType
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EventHubInfo(string data, string uid)
	{
		var response = new EventHubInfoResponse();
		var hubs = _db.Queryable<EventHubConfigDao>().ToList();
		var settings = _db.Queryable<EventHubSettingConfigDao>().ToList();
		foreach (var hub in hubs)
		{
			var hubInfo = new EventHubDBInfo
			{
				Uid = hub.Uid,
				HubId = hub.HubId,
				StartTime = hub.StartTime,
				PlayEndTime = hub.PlayEndTime,
				EndTime = hub.EndTime
			};
			var hubSettings = settings.Where(s => s.HubUid == hub.Uid).ToList();
			foreach (var setting in hubSettings)
			{
				var settingInfo = new EventHubSettingDBInfo
				{
					Slot = setting.Slot,
					HubContentType = setting.HubContentType
				};
				if (!string.IsNullOrEmpty(setting.EventUids))
				{
					var eventUids = JsonConvert.DeserializeObject<List<int>>(setting.EventUids);
					if (eventUids != null) settingInfo.EventUid.Add(eventUids);
				}
				hubInfo.SettingInfo.Add(settingInfo);
			}
			response.EventHubInfo.Add(hubInfo);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EventExchangeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EventExchangeInfoResponse();
		var list = _db.Queryable<EventExchangeInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.EventExchangeInfo.Add(new EventExchangeDBInfo
			{
				EventUid = dao.EventUid,
				GroupId = dao.GroupId,
				Page = dao.Page,
				KeyCount = dao.KeyCount
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult EventScheduleInfo(string data, string uid)
	{
		var response = new EventScheduleInfoResponse();
		var list = _db.Queryable<EventScheduleConfigDao>().ToList();
		foreach (var dao in list)
		{
			response.EventScheduleInfo.Add(new EventScheduleDBInfo
			{
				Id = dao.Id,
				EventType = (Define_EventType)dao.EventType,
				EventId = dao.EventId,
				EventSubId = dao.EventSubId,
				StartDate = dao.StartDate,
				EndDate = dao.EndDate
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult ScheduleInfo(string data, string uid)
	{
		ScheduleInfoResponse scheduleInfoResponse = new ScheduleInfoResponse
		{
			ScheduleCalculateMileSeconds = 32400000
		};
		foreach (ScheduleDBInfo item in _db.Queryable<ScheduleInfoDao>().ToList().Select((ScheduleInfoDao scheduleInfoDao) => new ScheduleDBInfo
		{
			ContentId = scheduleInfoDao.Id,
			CurrentSeason = new SeasonInfo
			{
				Season = scheduleInfoDao.CurrentSeason,
				StartTime = scheduleInfoDao.CurrentStartTime,
				EndTime = scheduleInfoDao.CurrentEndTime
			},
			NextSeason = new SeasonInfo
			{
				Season = scheduleInfoDao.NextSeason,
				StartTime = scheduleInfoDao.NextStartTime,
				EndTime = scheduleInfoDao.NextEndTime
			}
		}))
		{
			scheduleInfoResponse.ScheduleInfo.Add(item);
		}
		return ResultUtil.CreateResult(scheduleInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult EventMissionInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new EventMissionInfoResponse();
		var missionList = _db.Queryable<EventMissionInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in missionList)
		{
			response.MissionInfo.Add(new EventMissionDBInfo
			{
				EventId = dao.EventUid,
				GroupId = dao.GroupId,
				Value = dao.Value,
				IsComplete = dao.IsComplete == 1
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MiniEventHubInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MiniEventHubInfoResponse();
		var hubList = _db.Queryable<MiniEventHubInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var hubDao in hubList)
		{
			var hub = new MiniEventHubDBInfo
			{
				Uid = hubDao.HubUid,
				HubId = hubDao.HubId,
				StartTime = hubDao.StartTime,
				PlayEndTime = hubDao.PlayEndTime,
				EndTime = hubDao.EndTime
			};
			var slotList = _db.Queryable<MiniEventHubSlotInfoDao>().Where(x => x.HubIndex == hubDao.Index).ToList();
			foreach (var slotDao in slotList)
			{
				hub.SlotInfo.Add(new MiniEventHubSlotDBInfo
				{
					Id = slotDao.Id,
					HubContentType = slotDao.HubContentType,
					HubContentId = slotDao.HubContentId,
					EventUid = slotDao.EventUid,
					StartTime = slotDao.StartTime,
					EndTime = slotDao.EndTime
				});
			}
			response.MiniEventHubInfo.Add(hub);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult DailyStoryInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new DailyStoryInfoResponse();
		var dao = _db.Queryable<DailyStoryInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null && !string.IsNullOrEmpty(dao.Info))
		{
			response.Info.AddRange(JsonConvert.DeserializeObject<int[]>(dao.Info));
		}
		return ResultUtil.CreateResult(response);
	}
}
