using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Google.Protobuf;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;

namespace Bd2.Server.Services.Game;

/// <summary>Pass rewards and premium-state writes. Design rewards always come from common_v1.db.</summary>
public sealed class GamePassService : IGamePassService
{
	private readonly ISqlSugarClient _db;
	private readonly IActionService _actionService;
	private readonly ILogger<GamePassService> _logger;

	public GamePassService(ISqlSugarClient db, IActionService actionService, ILogger<GamePassService> logger)
	{
		_db = db;
		_actionService = actionService;
		_logger = logger;
	}

	public GameActionResult PassReward(string data, string uid)
	{
		var request = ProtoUtil.Deserialize<PassRewardRequest>(data);
		var uidLong = long.Parse(uid);
		var pass = DesignDbHelper.LoadFromCommon("PassTable", PassTable.Parser)
			.FirstOrDefault(x => x.Id == request.PassId);
		if (pass == null)
			return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = new RewardDBInfoBundle() });

		var passInfo = _db.Queryable<PassInfoDao>().First(x => x.Uid == uidLong && x.PassId == request.PassId);
		if (passInfo == null)
			return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = new RewardDBInfoBundle() });

		var levels = DesignDbHelper.LoadFromCommon("PassLevelTable", PassLevelTable.Parser)
			.Where(x => x.GroupId == pass.PassLevelGroupId)
			.OrderBy(x => x.Id)
			.ToList();
		var currentLevel = Math.Max(0, passInfo.Level);
		var selected = request.IsAll
			? levels.Where(x => x.Id <= currentLevel).ToList()
			: levels.Where(x => x.Id == request.Id).ToList();
		if (selected.Count == 0)
			return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = new RewardDBInfoBundle() });

		if (request.RewardType == Define_PassRewardType.SprPremium1 && passInfo.IsPremium != 1)
			return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = new RewardDBInfoBundle() });
		if (request.RewardType == Define_PassRewardType.SprPremium2)
			return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = new RewardDBInfoBundle() });

		var received = ParseIds(request.RewardType == Define_PassRewardType.SprBasic
			? passInfo.NormalRewardReceived
			: passInfo.PremiumRewardReceived);
		var bundle = new RewardDBInfoBundle();
		foreach (var level in selected)
		{
			if (received.Contains(level.Id))
				continue;
			var rewardId = request.RewardType == Define_PassRewardType.SprBasic ? level.BasicRewardId : level.Pass1RewardId;
			var rewardType = request.RewardType == Define_PassRewardType.SprBasic ? level.BasicRewardType : level.Pass1RewardType;
			var rewardCount = request.RewardType == Define_PassRewardType.SprBasic ? level.BasicRewardCount : level.Pass1RewardCount;
			if (rewardId == 0 || rewardCount <= 0)
				continue;
			var item = rewardType <= (int)ItemType.Gold
				? _actionService.SendItemToUser(rewardId, rewardType, rewardCount, uid)
				: _actionService.SendItemToBag(rewardId, rewardType, rewardCount, uid);
			if (item != null && item.Count > 0)
				bundle.ItemInfo.Add(item);
			received.Add(level.Id);
		}

		var serialized = JsonConvert.SerializeObject(received.OrderBy(x => x).ToList());
		if (request.RewardType == Define_PassRewardType.SprBasic)
			passInfo.NormalRewardReceived = serialized;
		else
			passInfo.PremiumRewardReceived = serialized;
		_db.Updateable(passInfo).ExecuteCommand();
		_logger.LogInformation("PassReward: uid={Uid}, passId={PassId}, type={Type}, count={Count}", uid, request.PassId, request.RewardType, received.Count);
		return ResultUtil.CreateResult(new PassRewardResponse { RewardInfoBundle = bundle });
	}

	public GameActionResult PassBuy(string data, string uid)
	{
		var request = ProtoUtil.Deserialize<PassBuyRequest>(data);
		var uidLong = long.Parse(uid);
		if (request.PassBuyType != Define_PassBuyType.PbPremium1 && request.PassBuyType != Define_PassBuyType.PbPremium2)
			return ResultUtil.CreateResult(new PassBuyResponse());
		var row = _db.Queryable<PassInfoDao>().First(x => x.Uid == uidLong && x.PassId == request.PassId);
		if (row == null)
			return ResultUtil.CreateResult(new PassBuyResponse());
		row.IsPremium = 1;
		_db.Updateable(row).ExecuteCommand();
		_logger.LogInformation("PassBuy: premium unlocked, uid={Uid}, passId={PassId}, type={Type}", uid, request.PassId, request.PassBuyType);
		return ResultUtil.CreateResult(new PassBuyResponse { Exp = row.Exp });
	}

	private static HashSet<int> ParseIds(string? value)
	{
		if (string.IsNullOrWhiteSpace(value))
			return new HashSet<int>();
		try { return (JsonConvert.DeserializeObject<List<int>>(value) ?? new List<int>()).ToHashSet(); }
		catch (JsonException) { return new HashSet<int>(); }
	}
}
