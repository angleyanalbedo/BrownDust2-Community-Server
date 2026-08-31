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

public class GameTotalWarInfoService : IGameTotalWarInfoService
{
	private readonly ILogger<GameTotalWarInfoService> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IMapper _mapper;

	public GameTotalWarInfoService(ILogger<GameTotalWarInfoService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_mapper = mapper;
	}

	[BatchEndpoint]
	public GameActionResult TotalWarRewardState(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var response = new TotalWarRewardResponse();
		var dao = _db.Queryable<TotalWarRewardStateDao>().First(x => x.Uid == uidLong);
		if (dao != null && dao.IsRewardReceived == 1)
		{
			response.RewardInfoBundle = new RewardDBInfoBundle();
		}
		return ResultUtil.CreateResult(response);
	}
}
