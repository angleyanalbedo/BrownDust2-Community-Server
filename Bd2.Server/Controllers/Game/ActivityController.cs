using System;
using System.Threading.Tasks;
using System.Linq;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.Model;
using Google.Protobuf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class ActivityController : ControllerBase
{
	private readonly ISqlSugarClient _db;

	public ActivityController(ISqlSugarClient db)
	{
		_db = db;
	}

	[HttpPut]
	public GameActionResult Attendance()
	{
		AttendanceInfoResponse attendanceInfoResponse = new AttendanceInfoResponse();
		attendanceInfoResponse.AttendanceTime.Add(8L);
		attendanceInfoResponse.AttendanceTime.Add(1L);
		attendanceInfoResponse.AttendanceTime.Add(16L);
		attendanceInfoResponse.AttendanceTime.Add(1L);
		attendanceInfoResponse.AttendanceTime.Add(24L);
		attendanceInfoResponse.AttendanceTime.Add(1L);
		attendanceInfoResponse.AttendanceTime.Add(8L);
		attendanceInfoResponse.AttendanceTime.Add(463L);
		attendanceInfoResponse.AttendanceTime.Add(16L);
		attendanceInfoResponse.AttendanceTime.Add(30L);
		attendanceInfoResponse.AttendanceTime.Add(24L);
		attendanceInfoResponse.AttendanceTime.Add(1L);
		return ResultUtil.CreateResult(attendanceInfoResponse);
	}

	[HttpPut]
	public GameActionResult EventRewardHistory()
	{
		string text = "Cg0IARADGgcBAgMEBQYHCgAKAAoACgAKAAoACgAKAAoACgAKAAoACgAKAAoACgAKAAoACgwIxQMQHRoFAQIDBAUKAAoACgAKAAoACgAKAAoA";
		return new GameActionResult
		{
			packetCode = 0,
			length = text.Length,
			data = AesUtils.AesEncrypt(text)
		};
	}

	[HttpPut]
	public GameActionResult PackEventStoryInfo()
	{
		PackEventStoryInfoResponse message = new PackEventStoryInfoResponse();
		return ResultUtil.CreateResult(message.ToByteArray(), 220);
	}

	[HttpPut]
	public GameActionResult PackEventBattleInfo()
	{
		PackEventBattleInfoResponse message = new PackEventBattleInfoResponse();
		return ResultUtil.CreateResult(message.ToByteArray(), 220);
	}

	[HttpPut]
	public GameActionResult MiniGameRunInfo([FromBody] string data)
	{
		var uid = long.Parse(base.User.FindFirst("user").Value);
		var response = new MiniGameRunInfoResponse();
		var list = _db.Queryable<MiniGameHubInfoDao>().Where(x => x.Uid == uid).ToList();
		foreach (var dao in list)
		{
			response.Info.Add(new MiniGameDBInfo
			{
				EventScheduleId = dao.EventUid,
				LastRewardPoint = 0,
				BestRecordValue = dao.ProgressType,
				IsPossibleQuickReward = false,
				WorldBestRecordOwnerIndex = 0,
				WorldBestRecordUserId = "",
				WorldBestRecordValue = 0,
				WorldBestRecordPlayInfo = ""
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult PackJamEvent([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<PackJamEventRequest>(data);
		var response = new PackJamEventResponse();
		var table = Bd2.Server.Common.DB.DesignDbHelper.LoadFromCommon("PackJamEventTable", PackJamEventTable.Parser)
			.FirstOrDefault(x => x.Id == request.PackId);
		if (table != null && table.RewardId != 0)
			response.PackEventReward = new ItemDBInfo { Id = table.RewardId, Type = table.RewardType, Count = table.RewardCount };
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public async Task<GameActionResult> MiniGameFieldInfo([FromBody] string data)
	{
		long uid = long.Parse(base.User.FindFirst("user").Value);
		var response = new MiniGameBingoInfoResponse();
		var rows = await _db.Queryable<MiniGameHubInfoDao>().Where(x => x.Uid == uid).ToListAsync();
		foreach (var row in rows.Where(x => x.EventUid != 0))
			response.MiniGameBingoInfo.Add(new MiniGameBingoDBInfo { EventScheduleId = row.EventUid });
		return ResultUtil.CreateResult(response);
	}
}
