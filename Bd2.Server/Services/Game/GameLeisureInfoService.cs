using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using AutoMapper;
using Bd2.Server.Common.DB;
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

public class GameLeisureInfoService : IGameLeisureInfoService
{
	private readonly ILogger<GameLeisureInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameLeisureInfoService(ILogger<GameLeisureInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CafeteriaInfoResponse();
		var dao = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == uidLong);
		if (dao == null)
		{
			// CafeteriaInfoResponse.CafeteriaInfo 为客户端初始化餐厅状态的必要字段。
			// 新玩家没有记录时创建最小合法运行时状态，而不是返回 null。
			var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			dao = new CafeteriaInfoDao
			{
				Uid = uidLong,
				Level = 1,
				RewardReceiptTime = now,
				SpawnTime = now,
				OngoingManageId = 0,
				DailyConnectionCostumeId = 0,
				CanGetPhoneNumber = 0,
				DailyNpcRewardCurrencyCount = 0,
				DailyRegularCostumeId = "[]",
				RewardedDailyRegularCostumeId = "[]"
			};
			dao.Index = _db.Insertable(dao).ExecuteReturnIdentity();
			_logger.LogInformation("CafeteriaInfo initialized: uid={Uid}, index={Index}", uidLong, dao.Index);
		}

		response.CafeteriaInfo = new CafeteriaDBInfo
		{
			Level = dao.Level,
			RewardReceiptTime = dao.RewardReceiptTime,
			SpawnTime = dao.SpawnTime,
			OngoingManageId = dao.OngoingManageId,
			DailyConnectionCostumeId = dao.DailyConnectionCostumeId,
			CanGetPhoneNumber = dao.CanGetPhoneNumber == 1,
			DailyNpcRewardCurrencyCount = dao.DailyNpcRewardCurrencyCount
		};
		AddDistinct(response.CafeteriaInfo.DailyRegularCostumeId, ParseIds(dao.DailyRegularCostumeId));
		AddDistinct(response.CafeteriaInfo.RewardedDailyRegularCostumeId, ParseIds(dao.RewardedDailyRegularCostumeId));

		var facilityRows = _db.Queryable<CafeteriaFacilityInfoDao>()
			.Where(x => x.Uid == uidLong)
			.ToList();
		foreach (var facility in facilityRows.GroupBy(x => x.FacilityId).Select(x => x.First()))
			response.FacilityInfo.Add(new CafeteriaFacilityDBInfo { FacilityId = facility.FacilityId });

		var managerRows = _db.Queryable<CafeteriaPartTimeManagerInfoDao>()
			.Where(x => x.Uid == uidLong)
			.ToList();
		foreach (var manager in managerRows.GroupBy(x => x.PartTimeManagerId).Select(x => x.First()))
			response.PartTimeManagerInfo.Add(new CafeteriaPartTimeManagerDBInfo { PartTimeManagerId = manager.PartTimeManagerId });

		_logger.LogInformation("CafeteriaInfo: uid={Uid}, level={Level}, facilities={Facilities}, managers={Managers}",
			uidLong, dao.Level, facilityRows.Count, managerRows.Count);
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaLevelUp(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var dao = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == uidLong);
		if (dao == null)
		{
			CafeteriaInfo(data, uid);
			dao = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == uidLong);
		}

		dao.Level = Math.Max(1, dao.Level + 1);
		_db.Updateable(dao).ExecuteCommand();

		// CafeteriaLevelUpResponse.NewCafeteriaInfo is field 1 and uses
		// CafeteriaDBInfo, so this wire-compatible response can use the
		// existing generated CafeteriaInfoResponse type until the missing
		// generated LevelUp Proto is added.
		var response = new CafeteriaInfoResponse
		{
			CafeteriaInfo = new CafeteriaDBInfo
			{
				Level = dao.Level,
				RewardReceiptTime = dao.RewardReceiptTime,
				SpawnTime = dao.SpawnTime,
				OngoingManageId = dao.OngoingManageId,
				DailyConnectionCostumeId = dao.DailyConnectionCostumeId,
				CanGetPhoneNumber = dao.CanGetPhoneNumber == 1,
				DailyNpcRewardCurrencyCount = dao.DailyNpcRewardCurrencyCount
			}
		};
		_logger.LogInformation("CafeteriaLevelUp: uid={Uid}, level={Level}", uidLong, dao.Level);
		return ResultUtil.CreateResult(response);
	}

	/// <summary>
	/// Adds the next cafeteria item for the player's current level.
	/// CafeteriaManageItemAddResponse is not present in the generated server
	/// Proto set; its wire layout was confirmed from the client dump:
	/// field 1 = NextManageId, field 2 = AddedFacilityInfo,
	/// field 3 = AddedPartTimeManagerInfo.
	/// </summary>
	[BatchEndpoint]
	public GameActionResult CafeteriaManageItemAdd(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var cafeteria = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == uidLong);
		if (cafeteria == null)
		{
			CafeteriaInfo(data, uid);
			cafeteria = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == uidLong);
		}

		var next = LoadNextCafeteriaManage(cafeteria.Level, cafeteria.OngoingManageId);
		if (next == null)
		{
			_logger.LogWarning("CafeteriaManageItemAdd: no design row for uid={Uid}, level={Level}, current={Current}",
				uidLong, cafeteria.Level, cafeteria.OngoingManageId);
			return ResultUtil.CreateResult(BuildCafeteriaManageItemAddResponse(cafeteria.OngoingManageId, 0, 0), 0);
		}

		var facilityId = next.Value.FacilityId;
		var managerId = next.Value.PartTimeManagerId;
		if (facilityId > 0 && !_db.Queryable<CafeteriaFacilityInfoDao>()
			.Any(x => x.Uid == uidLong && x.FacilityId == facilityId))
		{
			_db.Insertable(new CafeteriaFacilityInfoDao { Uid = uidLong, FacilityId = facilityId }).ExecuteCommand();
		}
		if (managerId > 0 && !_db.Queryable<CafeteriaPartTimeManagerInfoDao>()
			.Any(x => x.Uid == uidLong && x.PartTimeManagerId == managerId))
		{
			_db.Insertable(new CafeteriaPartTimeManagerInfoDao { Uid = uidLong, PartTimeManagerId = managerId }).ExecuteCommand();
		}

		cafeteria.OngoingManageId = next.Value.Id;
		_db.Updateable(cafeteria).ExecuteCommand();
		_logger.LogInformation("CafeteriaManageItemAdd: uid={Uid}, level={Level}, manageId={ManageId}, facility={Facility}, manager={Manager}",
			uidLong, cafeteria.Level, next.Value.Id, facilityId, managerId);
		return ResultUtil.CreateResult(BuildCafeteriaManageItemAddResponse(next.Value.Id, facilityId, managerId), 0);
	}

	private static (int Id, int FacilityId, int PartTimeManagerId)? LoadNextCafeteriaManage(int level, int currentId)
	{
		var path = DesignDbHelper.GetCommonDbPath();
		if (!File.Exists(path)) return null;
		using var connection = new SQLiteConnection($"Data Source={path};Version=3;Read Only=True;");
		connection.Open();
		using var command = new SQLiteCommand(
			"SELECT id, facilityId, parttimeId FROM [CafeteriaManageTable] WHERE groupId = @groupId AND id > @id ORDER BY id LIMIT 1",
			connection);
		command.Parameters.AddWithValue("@groupId", level);
		command.Parameters.AddWithValue("@id", currentId);
		using var reader = command.ExecuteReader();
		if (!reader.Read()) return null;
		return (Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["facilityId"]), Convert.ToInt32(reader["parttimeId"]));
	}

	private static byte[] BuildCafeteriaManageItemAddResponse(int nextManageId, int facilityId, int partTimeManagerId)
	{
		using var stream = new MemoryStream();
		using var output = new CodedOutputStream(stream);
		if (nextManageId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(nextManageId);
		}
		if (facilityId > 0)
		{
			output.WriteRawTag(18);
			output.WriteMessage(new CafeteriaFacilityDBInfo { FacilityId = facilityId });
		}
		if (partTimeManagerId > 0)
		{
			output.WriteRawTag(26);
			output.WriteMessage(new CafeteriaPartTimeManagerDBInfo { PartTimeManagerId = partTimeManagerId });
		}
		output.Flush();
		return stream.ToArray();
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaIntroductionStoryReward(string data, string uid)
	{
		return ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle()), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaCumulativeReward(string data, string uid)
	{
		var cafeteria = EnsureCafeteria(uid);
		cafeteria.RewardReceiptTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		_db.Updateable(cafeteria).ExecuteCommand();
		return ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle(), 2, cafeteria.RewardReceiptTime), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaSpawnReset(string data, string uid) => BuildSpawnResetResult(uid);

	[BatchEndpoint]
	public GameActionResult CafeteriaSpawnResetCheat(string data, string uid) => BuildSpawnResetResult(uid);

	[BatchEndpoint]
	public GameActionResult CafeteriaDailyConnectionCostumeRefresh(string data, string uid)
	{
		var cafeteria = EnsureCafeteria(uid);
		cafeteria.DailyConnectionCostumeId = 0;
		cafeteria.CanGetPhoneNumber = 0;
		_db.Updateable(cafeteria).ExecuteCommand();
		return ResultUtil.CreateResult(BuildScalarResponse(1, 0, 2, false), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRegularCostumeNoteInfo(string data, string uid)
	{
		var bytes = new MemoryStream();
		using (var output = new CodedOutputStream(bytes))
		{
			foreach (var note in GetCostumeNotes(uid))
			{
				output.WriteRawTag(10);
				WriteMessageBytes(output, BuildNoteBytes(note.CostumeId, note.ServeCount, note.IsReceivedReward == 1));
			}
			output.Flush();
		}
		return ResultUtil.CreateResult(bytes.ToArray(), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRegularCostumeNoteReward(string data, string uid)
	{
		var costumeId = ReadProtoInt(data, 2);
		if (costumeId <= 0) return ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle()), 0);
		var note = EnsureNote(uid, costumeId);
		note.IsReceivedReward = 1;
		_db.Updateable(note).ExecuteCommand();
		return ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle()), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRegularCostumeNoteAllReward(string data, string uid)
	{
		var notes = GetCostumeNotes(uid);
		foreach (var note in notes) note.IsReceivedReward = 1;
		if (notes.Count > 0) _db.Updateable(notes).ExecuteCommand();
		var stream = new MemoryStream();
		using (var output = new CodedOutputStream(stream))
		{
			WriteEmptyReward(output, 1);
			foreach (var note in notes) { output.WriteRawTag(16); output.WriteInt32(note.CostumeId); }
			output.Flush();
		}
		return ResultUtil.CreateResult(stream.ToArray(), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRegularCostumeInteractionReward(string data, string uid)
	{
		var costumeId = ReadProtoInt(data, 2);
		if (costumeId <= 0) return ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle()), 0);
		var note = EnsureNote(uid, costumeId);
		note.ServeCount++;
		_db.Updateable(note).ExecuteCommand();
		return ResultUtil.CreateResult(BuildInteractionResponse(note), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRegularCostumeInteractionAllReward(string data, string uid)
	{
		var notes = GetCostumeNotes(uid);
		foreach (var note in notes) note.ServeCount++;
		if (notes.Count > 0) _db.Updateable(notes).ExecuteCommand();
		var stream = new MemoryStream();
		using (var output = new CodedOutputStream(stream))
		{
			WriteEmptyReward(output, 2);
			foreach (var note in notes)
			{
				output.WriteRawTag(10); output.WriteInt32(note.CostumeId);
				output.WriteRawTag(26); WriteMessageBytes(output, BuildNoteBytes(note.CostumeId, note.ServeCount, note.IsReceivedReward == 1));
			}
			output.Flush();
		}
		return ResultUtil.CreateResult(stream.ToArray(), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaRewardReceiptTimeUpdateUsingCheat(string data, string uid)
	{
		var cafeteria = EnsureCafeteria(uid);
		var minutes = Math.Max(0, ReadProtoInt(data, 2));
		cafeteria.RewardReceiptTime = Math.Max(0, cafeteria.RewardReceiptTime - minutes * 60_000L);
		_db.Updateable(cafeteria).ExecuteCommand();
		return ResultUtil.CreateResult(BuildScalarResponse(1, cafeteria.RewardReceiptTime), 0);
	}

	[BatchEndpoint]
	public GameActionResult CafeteriaEventNpcInteractionReward(string data, string uid) =>
		ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle(), 2, 0), 0);

	[BatchEndpoint]
	public GameActionResult CafeteriaRareNpcInteractionReward(string data, string uid) =>
		ResultUtil.CreateResult(BuildRewardResponse(1, new RewardDBInfoBundle()), 0);

	private GameActionResult BuildSpawnResetResult(string uid)
	{
		var cafeteria = EnsureCafeteria(uid);
		cafeteria.SpawnTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		cafeteria.DailyRegularCostumeId = "[]";
		cafeteria.RewardedDailyRegularCostumeId = "[]";
		cafeteria.DailyNpcRewardCurrencyCount = 0;
		_db.Updateable(cafeteria).ExecuteCommand();
		return ResultUtil.CreateResult(BuildSpawnResponse(cafeteria), 0);
	}

	private CafeteriaInfoDao EnsureCafeteria(string uid)
	{
		var id = long.Parse(uid);
		var row = _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == id);
		if (row != null) return row;
		CafeteriaInfo("", uid);
		return _db.Queryable<CafeteriaInfoDao>().First(x => x.Uid == id);
	}

	private List<CafeteriaRegularCostumeNoteInfoDao> GetCostumeNotes(string uid)
	{
		var id = long.Parse(uid);
		var owned = _db.Queryable<CostumeInfoDao>().Where(x => x.Uid == id).ToList().Select(x => x.Id).Distinct().ToList();
		var notes = _db.Queryable<CafeteriaRegularCostumeNoteInfoDao>().Where(x => x.Uid == id).ToList();
		foreach (var costumeId in owned.Where(x => !notes.Any(n => n.CostumeId == x)))
		{
			var note = new CafeteriaRegularCostumeNoteInfoDao { Uid = id, CostumeId = costumeId, ServeCount = 0, IsReceivedReward = 0 };
			note.Index = _db.Insertable(note).ExecuteReturnIdentity();
			notes.Add(note);
		}
		return notes.GroupBy(x => x.CostumeId).Select(x => x.First()).ToList();
	}

	private CafeteriaRegularCostumeNoteInfoDao EnsureNote(string uid, int costumeId)
	{
		var id = long.Parse(uid);
		var note = _db.Queryable<CafeteriaRegularCostumeNoteInfoDao>().First(x => x.Uid == id && x.CostumeId == costumeId);
		if (note != null) return note;
		note = new CafeteriaRegularCostumeNoteInfoDao { Uid = id, CostumeId = costumeId };
		note.Index = _db.Insertable(note).ExecuteReturnIdentity();
		return note;
	}

	private static byte[] BuildInteractionResponse(CafeteriaRegularCostumeNoteInfoDao note)
	{
		var stream = new MemoryStream();
		using var output = new CodedOutputStream(stream);
		WriteEmptyReward(output, 1);
		output.WriteRawTag(18); WriteMessageBytes(output, BuildNoteBytes(note.CostumeId, note.ServeCount, note.IsReceivedReward == 1));
		output.Flush(); return stream.ToArray();
	}

	private static byte[] BuildNoteBytes(int costumeId, int serveCount, bool received)
	{
		var stream = new MemoryStream();
		using var output = new CodedOutputStream(stream);
		if (costumeId != 0) { output.WriteRawTag(8); output.WriteInt32(costumeId); }
		if (serveCount != 0) { output.WriteRawTag(16); output.WriteInt32(serveCount); }
		if (received) { output.WriteRawTag(24); output.WriteBool(true); }
		output.Flush(); return stream.ToArray();
	}

	private static void WriteMessageBytes(CodedOutputStream output, byte[] message)
	{
		output.WriteBytes(ByteString.CopyFrom(message));
	}

	private static byte[] BuildRewardResponse(int rewardField, RewardDBInfoBundle reward, int timeField = 0, long time = 0)
	{
		var stream = new MemoryStream();
		using var output = new CodedOutputStream(stream);
		WriteEmptyReward(output, rewardField);
		if (timeField != 0) { output.WriteRawTag((byte)(timeField * 8)); output.WriteInt64(time); }
		output.Flush(); return stream.ToArray();
	}

	private static void WriteEmptyReward(CodedOutputStream output, int field) { output.WriteRawTag((byte)(field * 8 + 2)); output.WriteLength(0); }

	private static byte[] BuildScalarResponse(int field1, long value1, int field2 = 0, bool value2 = false)
	{
		var stream = new MemoryStream(); using var output = new CodedOutputStream(stream);
		output.WriteRawTag((byte)(field1 * 8)); output.WriteInt64(value1);
		if (field2 != 0) { output.WriteRawTag((byte)(field2 * 8)); output.WriteBool(value2); }
		output.Flush(); return stream.ToArray();
	}

	private static byte[] BuildSpawnResponse(CafeteriaInfoDao cafeteria)
	{
		var stream = new MemoryStream(); using var output = new CodedOutputStream(stream);
		output.WriteRawTag(8); output.WriteInt32(cafeteria.DailyConnectionCostumeId);
		output.WriteRawTag(16); output.WriteBool(cafeteria.CanGetPhoneNumber == 1);
		output.WriteRawTag(40); output.WriteInt32(cafeteria.DailyNpcRewardCurrencyCount);
		output.Flush(); return stream.ToArray();
	}

	private static int ReadProtoInt(string data, int fieldNumber)
	{
		try
		{
			var plaintext = AesUtils.AesDecrypt(data);
			using var input = new CodedInputStream(Convert.FromBase64String(plaintext));
			uint wanted = (uint)(fieldNumber * 8);
			uint tag;
			while ((tag = input.ReadTag()) != 0) { if (tag == wanted) return input.ReadInt32(); input.SkipLastField(); }
		}
		catch (Exception ex) { Console.Error.WriteLine($"[Cafeteria] request parse failed: {ex.GetType().Name}: {ex.Message}"); }
		return 0;
	}

	private static List<int> ParseIds(string value)
	{
		try { return string.IsNullOrWhiteSpace(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value) ?? new List<int>(); }
		catch { return new List<int>(); }
	}

	private static void AddDistinct(RepeatedField<int> target, IEnumerable<int> values)
	{
		foreach (var value in values.Where(x => x > 0).Distinct()) if (!target.Contains(value)) target.Add(value);
	}

	[BatchEndpoint]
	public GameActionResult MiniGameHubInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MiniGameHubInfoResponse();
		var list = _db.Queryable<MiniGameHubInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.MiniGameHubInfo.Add(new MiniGameHubDBInfo
			{
				Slot = dao.Slot,
				EventUid = dao.EventUid,
				ProgressType = dao.ProgressType
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult DatingInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new DatingInfoResponse();
		var list = _db.Queryable<DatingInfoDao>().Where(x => x.Uid == uidLong)
			.OrderByDescending(x => x.Index).ToList()
			.GroupBy(x => x.GroupId).Select(x => x.First()).ToList();
		foreach (var dao in list)
		{
			response.EpisodeInfo.Add(new DatingEpisodeDBInfo
			{
				GroupId = dao.GroupId,
				DatingPoint = dao.DatingPoint,
				LastClearId = dao.LastClearId,
				LastMessageGroupId = dao.LastMessageGroupId,
				LastMessageId = dao.LastMessageId,
				LastMessageUpdateTime = dao.LastMessageUpdateTime
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult LifeInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new LifeInfoResponse();
		var dao = _db.Queryable<LifeUserInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.LifeUserInfo = new LifeUserDBInfo
			{
				LifeCoin = dao.LifeCoin,
				LifeWorldId = dao.LifeWorldId
			};
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult CharVoteInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new CharVoteInfoResponse();
		var dao = _db.Queryable<CharVoteInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.CurrentRound = dao.CurrentRound;
			response.NextDailyResetTime = dao.NextDailyResetTime;
			response.IsDailyReset = dao.IsDailyReset == 1;
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult MiniGameDefenseInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new MiniGameDefenseInfoResponse();
		var dao = _db.Queryable<MiniGameDefenseInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.EventScheduleId = dao.EventScheduleId;
			if (!string.IsNullOrEmpty(dao.RewardInfo))
			{
				var rewards = JsonConvert.DeserializeObject<List<int>>(dao.RewardInfo);
				if (rewards != null) response.RewardInfo.Add(rewards);
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult FireWorksInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new FireWorksInfoResponse();
		var list = _db.Queryable<FireWorksInfoDao>().Where(x => x.Uid == uidLong).ToList();
		foreach (var dao in list)
		{
			response.RewardedGroupId.Add(dao.RewardedGroupId);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult LifeUserInfo(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new LifeUserInfoResponse();
		var dao = _db.Queryable<LifeUserInfoDao>().First(x => x.Uid == uidLong);
		if (dao != null)
		{
			response.LifeUserInfo = new LifeUserDBInfo
			{
				LifeCoin = dao.LifeCoin,
				LifeWorldId = dao.LifeWorldId
			};
		}
		return ResultUtil.CreateResult(response);
	}
}
