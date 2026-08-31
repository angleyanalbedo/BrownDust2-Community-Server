using System;
using System.Linq;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Bd2.Server.iServices;
using Bd2.Server.Model;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Services.Game;

public class GameMasterTitleService : IGameMasterTitleService
{
	private readonly ILogger<GameMasterTitleService> _logger;
	private readonly ISqlSugarClient _db;

	public GameMasterTitleService(ISqlSugarClient db, ILogger<GameMasterTitleService> logger)
	{
		_db = db;
		_logger = logger;
	}

	public GameActionResult MasterTitleInfoUpdate(string data, string uid)
	{
		var uidLong = long.Parse(uid);
		var request = MasterTitleInfoUpdateRequest.Parser.ParseFrom(Convert.FromBase64String(data));

		var existing = _db.Queryable<MasterTitleInfoDao>().First(x => x.Uid == uidLong);
		if (existing != null)
		{
			existing.Seq = request.Seq;
			existing.Name = request.Name;
			existing.Month = request.Month;
			existing.Day = request.Day;
			_db.Updateable(existing).ExecuteCommand();
		}
		else
		{
			var dao = new MasterTitleInfoDao
			{
				Uid = uidLong,
				Seq = request.Seq,
				Name = request.Name,
				Month = request.Month,
				Day = request.Day
			};
			_db.Insertable(dao).ExecuteCommand();
		}

		return ResultUtil.CreateResult(new MasterTitleInfoUpdateResponse());
	}

	[BatchEndpoint]
	public GameActionResult MasterTitleInfo(string data, string uid)
	{
		var response = new MasterTitleInfoResponse();
		var dao = _db.Queryable<MasterTitleInfoDao>().First(x => x.Uid == long.Parse(uid));
		if (dao != null)
		{
			response.Name = dao.Name ?? "";
			response.Month = dao.Month;
			response.Day = dao.Day;
		}
		return ResultUtil.CreateResult(response);
	}
}
