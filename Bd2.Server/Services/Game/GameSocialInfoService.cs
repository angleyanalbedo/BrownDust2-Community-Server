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

public class GameSocialInfoService : IGameSocialInfoService
{
	private readonly ILogger<GameSocialInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameSocialInfoService(ILogger<GameSocialInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult CharPartnerInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CharPartnerInfoResponse();
		var partnerList = _db.Queryable<CharPartnerInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in partnerList)
		{
			response.CharPartnerInfo.Add(new CharPartnerDBInfo
			{
				MainUniqueId = dao.MainUniqueId,
				SubUniqueId = dao.SubUniqueId,
				Point = dao.Point,
				Reward = dao.Reward
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MyLikeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MyLikeInfoResponse();
		var like = _db.Queryable<MyLikeInfoDao>().First(x => x.Uid == uidLong);
		if (like != null)
		{
			response.TargetOwnerIndex = like.TargetUid;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult GuildInitInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new GuildInitInfoResponse();
		var dao = _db.Queryable<GuildUserInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.IsReward = dao.IsReward == 1;
			response.RaidPlayInfo = new GuildRaidPlayDBInfo
			{
				BossScore = dao.RaidBossScore,
				TotalScore = dao.RaidTotalScore,
				TopPercent = dao.RaidTopPercent,
				IsPlayRaidToday = dao.IsPlayRaidToday == 1,
				IsNormalBattlePlay = dao.IsNormalBattlePlay == 1
			};
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FriendInfoList(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FriendInfoListResponse();
		var friendList = _db.Queryable<FriendInfoListDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in friendList)
		{
			var friendInfo = new FriendDBInfo
			{
				OwnerIndex = dao.FriendUid,
				Date = dao.FriendDate
			};
			var friendUser = _db.Queryable<UserInfoDao>().First(x => x.OwnerIndex == dao.FriendUid);
			if (friendUser != null)
			{
				friendInfo.UserId = friendUser.UserId ?? "";
				friendInfo.PortraitCostumeId = friendUser.PortraitCostumeId;
			}
			switch (dao.FriendType)
			{
				case 0:
					response.FriendInfo.Add(friendInfo);
					break;
				case 1:
					response.FriendRecv.Add(friendInfo);
					break;
				case 2:
					response.FriendSend.Add(friendInfo);
					break;
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FriendshipInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FriendshipInfoResponse();

		var friendshipList = _db.Queryable<FriendshipInfoDao>().Where(x => x.Uid == uidLong)
			.OrderByDescending(x => x.Index).ToList()
			.GroupBy(x => x.FriendshipCostumeId).Select(x => x.First()).ToList();
		foreach (var dao in friendshipList)
		{
			response.FriendshipInfo.Add(new FriendshipDBInfo
			{
				FriendshipCostumeId = dao.FriendshipCostumeId,
				Level = dao.Level,
				Exp = dao.Exp,
				LastCounselingDate = dao.LastCounselingDate
			});
		}

		var counselingList = _db.Queryable<CounselingInfoDao>().Where(x => x.Uid == uidLong)
			.OrderByDescending(x => x.Index).ToList()
			.GroupBy(x => x.FriendshipCostumeId).Select(x => x.First()).ToList();
		foreach (var dao in counselingList)
		{
			var info = new CounselingDBInfo
			{
				FriendshipCostumeId = dao.FriendshipCostumeId
			};
			if (!string.IsNullOrEmpty(dao.CounselingSessionId))
			{
				try
				{
					var sessions = JsonConvert.DeserializeObject<int[]>(dao.CounselingSessionId);
					if (sessions != null) info.CounselingSessionId.AddRange(sessions.Distinct());
				}
				catch (JsonException) { }
			}
			response.CounselingInfo.Add(info);
		}

		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult GuildRaidSeasonReward(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new GuildRaidSeasonRewardResponse();
		var dao = _db.Queryable<GuildRaidSeasonRewardDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.IsReceivedReward = dao.IsReceivedReward == 1;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult RoomChatReportAndBlockInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new RoomChatReportAndBlockInfoResponse();
		var list = _db.Queryable<RoomChatBlockInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.ChatBlockInfo.Add(new RoomChatBlockDBInfo
			{
				TargetOwnerIndex = dao.TargetOwnerIndex,
				TargetUserId = dao.TargetUserId ?? "",
				BlockDate = dao.BlockDate
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FriendshipSpecialEpisodeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FriendshipSpecialEpisodeInfoResponse();
		var list = _db.Queryable<FriendshipSpecialEpisodeInfoDao>().Where(x => x.Uid == uidLong)
			.OrderByDescending(x => x.Index).ToList()
			.GroupBy(x => new { x.GroupId, x.EpisodeId }).Select(x => x.First()).ToList();
		foreach (var dao in list)
		{
			response.Info.Add(new FriendshipSpecialEpisodeDBInfo
			{
				GroupId = dao.GroupId,
				Id = dao.EpisodeId
			});
		}
		return ResultUtil.CreateResult(response);
	}

	public GameActionResult FriendshipGift(string data, string uid)
	{
		var req = ProtoUtil.Deserialize<FriendshipGiftRequest>(data);
		var uidLong = long.Parse(uid);
		foreach (var item in req.ItemInfo)
		{
			if (item.Count <= 0) continue;
			var row = _db.Queryable<ItemInfoDao>().First(x => x.Uid == uidLong && x.InvenIndex == item.InvenIndex);
			if (row == null || row.Id != item.Id || row.Count < item.Count)
				return ResultUtil.CreateResult(new FriendshipGiftResponse { RewardInfoBundle = new RewardDBInfoBundle() });
			_db.Updateable<ItemInfoDao>().SetColumns(x => x.Count == x.Count - item.Count)
				.Where(x => x.Uid == uidLong && x.InvenIndex == item.InvenIndex && x.Count >= item.Count).ExecuteCommand();
		}
		var friendship = GetOrCreateFriendship(uidLong, req.CostumeId);
		var response = new FriendshipGiftResponse { RewardInfoBundle = new RewardDBInfoBundle(), FriendshipInfo = ToProto(friendship), GainedExp = 0 };
		return ResultUtil.CreateResult(response);
	}

	public GameActionResult FriendshipCounseling(string data, string uid)
	{
		var req = ProtoUtil.Deserialize<FriendshipCounselingRequest>(data);
		var uidLong = long.Parse(uid);
		var friendship = GetOrCreateFriendship(uidLong, req.CostumeId);
		friendship.Exp += 1;
		_db.Updateable(friendship).ExecuteCommand();
		var counseling = _db.Queryable<CounselingInfoDao>().First(x => x.Uid == uidLong && x.FriendshipCostumeId == req.CostumeId);
		if (counseling == null) { counseling = new CounselingInfoDao { Uid = uidLong, FriendshipCostumeId = req.CostumeId, CounselingSessionId = "[]" }; _db.Insertable(counseling).ExecuteCommand(); }
		var sessions = JsonConvert.DeserializeObject<List<int>>(counseling.CounselingSessionId ?? "[]") ?? new();
		if (!req.IsQuick && !sessions.Contains(req.SessionId)) { sessions.Add(req.SessionId); counseling.CounselingSessionId = JsonConvert.SerializeObject(sessions); _db.Updateable(counseling).ExecuteCommand(); }
		return ResultUtil.CreateResult(new FriendshipCounselingResponse { RewardInfoBundle = new RewardDBInfoBundle(), FriendshipInfo = ToProto(friendship), IsCorrect = true, GainedExp = 1 });
	}

	public GameActionResult FriendshipSpecialEpisodeClear(string data, string uid)
	{
		var req = ProtoUtil.Deserialize<FriendshipSpecialEpisodeClearRequest>(data);
		var uidLong = long.Parse(uid);
		if (!_db.Queryable<FriendshipSpecialEpisodeInfoDao>().Any(x => x.Uid == uidLong && x.GroupId == req.GroupId && x.EpisodeId == req.Id))
			_db.Insertable(new FriendshipSpecialEpisodeInfoDao { Uid = uidLong, GroupId = req.GroupId, EpisodeId = req.Id }).ExecuteCommand();
		return ResultUtil.CreateResult(new FriendshipSpecialEpisodeClearResponse { RewardInfoBundle = new RewardDBInfoBundle(), ClearInfo = new FriendshipSpecialEpisodeDBInfo { GroupId = req.GroupId, Id = req.Id } });
	}

	private FriendshipInfoDao GetOrCreateFriendship(long uid, int costumeId)
	{
		var row = _db.Queryable<FriendshipInfoDao>().First(x => x.Uid == uid && x.FriendshipCostumeId == costumeId);
		if (row != null) return row;
		row = new FriendshipInfoDao { Uid = uid, FriendshipCostumeId = costumeId, Level = 1, Exp = 0, LastCounselingDate = 0 };
		_db.Insertable(row).ExecuteCommand();
		return row;
	}

	private static FriendshipDBInfo ToProto(FriendshipInfoDao x) => new() { FriendshipCostumeId = x.FriendshipCostumeId, Level = x.Level, Exp = x.Exp, LastCounselingDate = x.LastCounselingDate };
}
