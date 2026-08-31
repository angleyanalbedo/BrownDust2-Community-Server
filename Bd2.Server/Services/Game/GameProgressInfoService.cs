using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
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

public class GameProgressInfoService : IGameProgressInfoService
{
	private readonly ILogger<GameProgressInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameProgressInfoService(ILogger<GameProgressInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult QuestMaxClearInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new QuestMaxClearInfoResponse();
		var questList = _db.Queryable<QuestInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var quest in questList)
		{
			if (string.IsNullOrEmpty(quest.QuestClear))
			{
				continue;
			}
			var clearIds = JsonConvert.DeserializeObject<List<int>>(quest.QuestClear);
			if (clearIds != null && clearIds.Count > 0)
			{
				response.MaxClearInfo.Add(new QuestMaxClearDBInfo
				{
					PackId = quest.PackId,
					MaxClearId = clearIds.Max()
				});
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult AchievementInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new AchievementInfoResponse();
		var list = _db.Queryable<AchievementInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.AchievementInfo.Add(new AchievementDBInfo
			{
				GroupId = dao.GroupId,
				Value = dao.Value,
				MaxClearId = dao.MaxClearId
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult SeasonRewardInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new SeasonRewardInfoResponse();
		var rewardList = _db.Queryable<SeasonRewardInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in rewardList)
		{
			response.RewardInfo.Add(new SeasonRewardDBInfo
			{
				PackId = dao.PackId,
				Season = dao.Season,
				IsRewardReceived = dao.IsRewardReceived == 1
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult PassInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new PassInfoResponse();
		var passList = _db.Queryable<PassInfoDao>().Where(x => x.Uid == uidLong).ToList();
		var passTables = DesignDbHelper.LoadFromCommon("PassTable", PassTable.Parser);
		var levelTables = DesignDbHelper.LoadFromCommon("PassLevelTable", PassLevelTable.Parser);
		foreach (var dao in passList)
		{
			response.PassInfo.Add(new PassDBInfo
			{
				Id = dao.PassId,
				Exp = dao.Exp,
				ActivePremium1 = dao.IsPremium == 1
			});

			var pass = passTables.FirstOrDefault(x => x.Id == dao.PassId);
			if (pass == null)
			{
				_logger.LogWarning("PassInfo: design pass not found, passId={PassId}", dao.PassId);
				continue;
			}

			var normalReceived = ParseRewardIds(dao.NormalRewardReceived);
			var premiumReceived = ParseRewardIds(dao.PremiumRewardReceived);
			foreach (var level in levelTables.Where(x => x.GroupId == pass.PassLevelGroupId).OrderBy(x => x.Id))
			{
				if (level.BasicRewardId != 0 || level.Pass1RewardId != 0)
				{
					response.PassRewardInfo.Add(new PassRewardDBInfo
					{
						PassId = dao.PassId,
						Id = level.Id,
						Basic = level.BasicRewardId != 0 && normalReceived.Contains(level.Id),
						Premium1 = premiumReceived.Contains(level.Id)
					});
				}
			}
		}
		return ResultUtil.CreateResult(response);
	}

	private static HashSet<int> ParseRewardIds(string? value)
	{
		if (string.IsNullOrWhiteSpace(value))
			return new HashSet<int>();
		try
		{
			return (JsonConvert.DeserializeObject<List<int>>(value) ?? new List<int>()).ToHashSet();
		}
		catch (JsonException)
		{
			return new HashSet<int>();
		}
	}

	[BatchEndpoint]
	public GameActionResult MissionInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MissionInfoResponse();
		var missionList = _db.Queryable<MissionInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in missionList)
		{
			response.MissionInfo.Add(new MissionDBInfo
			{
				GroupId = dao.GroupId,
				Value = dao.Value,
				IsComplete = dao.IsComplete == 1
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult NoticeInfo(string data, string uid)
	{
		List<NoticeInfoDao> source = _db.Queryable<NoticeInfoDao>().ToList();
		List<NoticeDBInfo> values = _mapper.Map<List<NoticeDBInfo>>(source);
		NoticeInfoResponse noticeInfoResponse = new NoticeInfoResponse();
		noticeInfoResponse.NoticeInfo.AddRange(values);
		string text = Convert.ToBase64String(noticeInfoResponse.ToByteArray());
		return new GameActionResult
		{
			packetCode = 0,
			length = text.Length,
			data = text
		};
	}

	[BatchEndpoint]
	public GameActionResult MailInfo(string data, string uid)
	{
		MailInfoRequest mailInfoRequest = new MailInfoRequest();

		mailInfoRequest = MailInfoRequest.Parser.ParseFrom(Convert.FromBase64String(data));

		_logger.LogInformation("邮件 {}", mailInfoRequest);
		List<MailDBInfo> list = new List<MailDBInfo>();
		foreach (MailInfoDao item in (from x in _db.Queryable<MailInfoDao>()
			where x.Uid == (long)int.Parse(uid) && x.InvenIndex > mailInfoRequest.StartInvenIndex && x.IsOpen == 0
			select x).ToList())
		{
			MailDBInfo mailDBInfo = new MailDBInfo
			{
				InvenIndex = item.InvenIndex,
				Type = item.Type,
				MailId = item.MailId,
				RewardExpireTime = item.RewardExpireTime,
				IsOpen = (item.IsOpen == 1),
				OpenTime = item.OpenTime,
				CreateTime = item.CreateTime,
				HistoryDeleteTime = item.HistoryDeleteTime,
				IsCash = (item.IsCash == 1)
			};
			if (item.SenderText != null)
			{
				mailDBInfo.SenderText = item.SenderText;
			}
			if (item.MessageText != null)
			{
				mailDBInfo.MessageText = item.MessageText;
			}
			if (item.TitleText != null)
			{
				mailDBInfo.TitleText = item.TitleText;
			}
			mailDBInfo.ItemId.Add(item.ItemId);
			mailDBInfo.ItemCount.Add(item.ItemCount);
			mailDBInfo.ItemType.Add(item.ItemType);
			list.Add(mailDBInfo);
		}
		MailInfoResponse mailInfoResponse = new MailInfoResponse();
		mailInfoResponse.MailInfo.AddRange(list);
		mailInfoResponse.TotalCount = list.Count;
		return ResultUtil.CreateResult(mailInfoResponse);
	}

	[BatchEndpoint]
	public GameActionResult CashMailInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CashMailInfoResponse();
		var mailList = _db.Queryable<CashMailInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in mailList)
		{
			response.MailInfo.Add(new MailDBInfo
			{
				InvenIndex = dao.InvenIndex,
				MailId = dao.MailId,
				Type = dao.Type,
				IsOpen = dao.IsOpen == 1,
				CreateTime = dao.CreateTime
			});
		}
		response.TotalCount = mailList.Count;
		if (mailList.Count > 0)
		{
			response.MaxInvenIndex = mailList.Max(x => x.InvenIndex);
		}
		return ResultUtil.CreateResult(response);
	}
}
