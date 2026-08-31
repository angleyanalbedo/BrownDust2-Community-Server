using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Google.Protobuf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class WorldController : ControllerBase
{
	private static readonly ConcurrentDictionary<string, long> PausedAt = new();
	private readonly ILogger<WorldController> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IGameUserService _gameUserService;

	public WorldController(ILogger<WorldController> logger, ISqlSugarClient db, IGameUserService gameUserService)
	{
		_logger = logger;
		_db = db;
		_gameUserService = gameUserService;
	}

	[HttpPut]
	public GameActionResult SaveTotalBattlePower([FromBody] string data)
	{
		SaveTotalBattlePowerRequest saveTotalBattlePowerRequest = ProtoUtil.Deserialize<SaveTotalBattlePowerRequest>(data);
		SaveTotalBattlePowerResponse data2 = new SaveTotalBattlePowerResponse
		{
			HighestTotalBattlePower = saveTotalBattlePowerRequest.TotalBattlePower
		};
		return ResultUtil.CreateResult(data2);
	}

	[HttpPut]
	public GameActionResult TodayQuestInfo([FromBody] string data)
	{
		var uid = long.Parse(base.User.FindFirst("user").Value);
		var response = new TodayQuestInfoResponse();

		// 计算今日结束时间（UTC+8 23:59:59）
		var now = DateTimeOffset.UtcNow;
		var todayEnd = new DateTimeOffset(now.Year, now.Month, now.Day, 23, 59, 59, TimeSpan.FromHours(8));
		var secondsUntilEnd = (long)(todayEnd - now).TotalSeconds;
		if (secondsUntilEnd < 0) secondsUntilEnd = 0;
		response.TodayEndTime = secondsUntilEnd;

		// QuestInfoDao stores main-pack progress, not daily quests. Returning its
		// active quest here makes the client add a main quest as a daily quest and
		// then add it again from PackInGameInfo when the field is entered.
		// Daily quest data must come from a dedicated table; until that exists,
		// return an empty daily-quest list.
		_logger.LogInformation("TodayQuestInfo: uid={Uid}, no daily-quest data configured", uid);

		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult HuntingGroundInfo([FromBody] string data)
	{
		int[] array = new int[5] { 201, 202, 203, 204, 205 };
		HuntingGroundDBInfo huntingGroundInfo = new HuntingGroundDBInfo
		{
			CurrentId = 1,
			HighestId = 3
		};
		HuntingGroundInfoResponse data2 = new HuntingGroundInfoResponse
		{
			HuntingGroundInfo = huntingGroundInfo
		};
		return ResultUtil.CreateResult(data2);
	}

	[HttpPut]
	public GameActionResult HuntingGroundInfoList([FromBody] string data)
	{
		HuntingGroundInfoListRequest request = ProtoUtil.Deserialize<HuntingGroundInfoListRequest>(data);
		_logger.LogInformation("HuntingGroundInfoList: packId count={Count}", request.PackId.Count);
		HuntingGroundInfoListResponse huntingGroundInfoListResponse = new HuntingGroundInfoListResponse();
		foreach (int packId in request.PackId)
		{
			huntingGroundInfoListResponse.HuntingGroundInfo.Add(new HuntingGroundDBInfo
			{
				CurrentId = 1,
				HighestId = 3
			});
		}
		return ResultUtil.CreateResult(huntingGroundInfoListResponse);
	}

	[HttpPut]
	public async Task<GameActionResult> SaveUserPosition([FromBody] string data)
	{
		SaveUserPositionRequest position = ProtoUtil.Deserialize<SaveUserPositionRequest>(data);
		return await _gameUserService.SaveUserPosition(position, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> ActiveMap([FromBody] string data)
	{
		ActiveMapRequest map = ProtoUtil.Deserialize<ActiveMapRequest>(data);
		return await _gameUserService.ActiveMap(map, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult WaypointUse([FromBody] string data)
	{
		WaypointUseRequest waypointUseRequest = ProtoUtil.Deserialize<WaypointUseRequest>(data);
		_logger.LogInformation("WaypointUse: {}", waypointUseRequest);
		return ResultUtil.CreateResult(new WaypointUseResponse().ToByteArray(), 10);
	}

	[HttpPut]
	public GameActionResult AchievementUpdate([FromBody] string data)
	{
		AchievementUpdateRequest achievementUpdateRequest = ProtoUtil.Deserialize<AchievementUpdateRequest>(data);
		_logger.LogInformation("更新成就: {}", achievementUpdateRequest);
		return ResultUtil.CreateResult(new AchievementUpdateResponse().ToByteArray(), 11);
	}

	[HttpPut]
	public async Task<GameActionResult> WaypointSave([FromBody] string data)
	{
		WaypointSaveRequest req = ProtoUtil.Deserialize<WaypointSaveRequest>(data);
		return await _gameUserService.WaypointSave(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult FieldObjectPositionUpdate([FromBody] string data)
	{
		FieldObjectPositionUpdateRequest fieldObjectPositionUpdateRequest = ProtoUtil.Deserialize<FieldObjectPositionUpdateRequest>(data);
		long uid = long.Parse(base.User.FindFirst("user").Value);
		var position = fieldObjectPositionUpdateRequest.Position;
		if (position != null)
		{
			var state = new FieldObjectStateDao
			{
				Uid = uid,
				PackId = fieldObjectPositionUpdateRequest.PackId,
				GroupId = fieldObjectPositionUpdateRequest.GroupId,
				ObjectId = fieldObjectPositionUpdateRequest.ObjectId,
				MapId = position.MapId,
				X = position.X,
				Y = position.Y,
				Z = position.Z
			};
			_db.Storageable(state)
				.WhereColumns(x => new { x.Uid, x.PackId, x.GroupId, x.ObjectId })
				.ExecuteCommand();
		}
		return ResultUtil.CreateResult(new FieldObjectPositionUpdateResponse());
	}

	[HttpPut]
	public async Task<GameActionResult> MonsterInfo([FromBody] string data)
	{
		MonsterInfoRequest req = ProtoUtil.Deserialize<MonsterInfoRequest>(data);
		return await _gameUserService.MonsterInfo(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> FieldMonsterRegen([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<FieldMonsterRegenRequest>(data);
		var uid = long.Parse(base.User.FindFirst("user").Value);
		var user = await _db.Queryable<UserInfoDao>().SingleAsync(x => x.OwnerIndex == uid);
		var response = new FieldMonsterRegenResponse();
		if (user != null && user.LastPlayPackId > 0 && user.LastPlayPackId < 1010)
		{
			var monster = BattleDeckManager.GetMonsterInfoListByPackId(user.LastPlayPackId)
				.FirstOrDefault(x => x.MonsterId == request.MonsterId);
			if (monster != null)
			{
				monster.ActiveFlag = true;
				monster.RespawnTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
				monster.LifeEndTime = monster.RespawnTime;
				response.MonsterInfo = monster;
			}
		}
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public async Task<GameActionResult> TimePause([FromBody] string data)
	{
		TimePauseRequest timePauseRequest = ProtoUtil.Deserialize<TimePauseRequest>(data);
		string uid = base.User.FindFirst("user").Value;
		long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		int addSeconds = 0;
		if (!PausedAt.TryAdd(uid, now) && PausedAt.TryRemove(uid, out long pausedAt))
			addSeconds = (int)Math.Max(0, now - pausedAt);
		_logger.LogInformation("TimePause: actionType={ActionType}, addSeconds={AddSeconds}", timePauseRequest.ActionType, addSeconds);
		return await Task.FromResult(ResultUtil.CreateResult(new TimePauseResponse { AddSeconds = addSeconds }));
	}

	[HttpPut]
	public async Task<GameActionResult> HuntDispatch([FromBody] string data)
	{
		HuntDispatchRequest req = ProtoUtil.Deserialize<HuntDispatchRequest>(data);
		return await _gameUserService.HuntDispatch(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult ServerNowTime([FromBody] string data)
	{
		var response = new ServerNowTimeResponse
		{
			ServerTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
		};
		return ResultUtil.CreateResult(response);
	}
}
