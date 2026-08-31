using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameTotalWarService : IGameTotalWarService
{
	private readonly ILogger<GameTotalWarService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public GameTotalWarService(ILogger<GameTotalWarService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
	}

	public async Task<GameActionResult> TotalWarInfo(string uid)
	{
		TotalWarRankDao totalWarRankDao = await _db.Queryable<TotalWarRankDao>().SingleAsync((TotalWarRankDao x) => x.Uid == long.Parse(uid));
		TotalWarInfoResponse totalWarInfoResponse = new TotalWarInfoResponse();
		if (totalWarRankDao != null)
		{
			totalWarInfoResponse.ScoreInfo.AddRange(JsonConvert.DeserializeObject<List<BattleDamageDBInfo>>(totalWarRankDao.ScoreData));
			List<TotalWarRankDao> list = await _db.Queryable<TotalWarRankDao>().OrderBy((TotalWarRankDao x) => x.Score, OrderByType.Desc).IgnoreColumns((TotalWarRankDao x) => x.ScoreData)
				.ToListAsync();
			int num = list.FindIndex((TotalWarRankDao obj) => obj.Uid == long.Parse(uid)) + 1;
			totalWarInfoResponse.TopPercent = Math.Round((double)num / (double)list.Count * 100.0, 2);
			totalWarInfoResponse.TopRankerScore = list[0].Score;
		}
		else
		{
			TotalWarRankDao totalWarRankDao2 = await _db.Queryable<TotalWarRankDao>().OrderBy((TotalWarRankDao x) => x.Score, OrderByType.Desc).FirstAsync();
			if (totalWarRankDao2 != null)
			{
				totalWarInfoResponse.TopRankerScore = totalWarRankDao2.Score;
			}
		}
		return ResultUtil.CreateResult(totalWarInfoResponse);
	}

	public async Task<GameActionResult> TotalWarDeckPresetInfo(string uid)
	{
		List<TotalWarDeckPresetInfoDao> obj = await (from x in _db.Queryable<TotalWarDeckPresetInfoDao>()
			where x.Uid == long.Parse(uid)
			select x).ToListAsync();
		TotalWarDeckPresetInfoResponse totalWarDeckPresetInfoResponse = new TotalWarDeckPresetInfoResponse();
		foreach (TotalWarDeckPresetInfoDao item in obj)
		{
			TotalWarDeckPresetDBInfo totalWarDeckPresetDBInfo = new TotalWarDeckPresetDBInfo
			{
				Slot = item.Slot,
				PresetName = item.PresetName
			};
			totalWarDeckPresetDBInfo.DeckInfo.AddRange(JsonConvert.DeserializeObject<List<TotalWarDeckDBInfo>>(item.DeckInfo));
			totalWarDeckPresetInfoResponse.PresetInfo.Add(totalWarDeckPresetDBInfo);
		}
		return ResultUtil.CreateResult(totalWarDeckPresetInfoResponse);
	}

	public async Task<GameActionResult> TotalWarDeckPresetSave(TotalWarDeckPresetSaveRequest req, string uid)
	{
		TotalWarDeckPresetInfoDao totalWarDeckPresetInfoDao = await _db.Queryable<TotalWarDeckPresetInfoDao>().SingleAsync((TotalWarDeckPresetInfoDao x) => x.Uid == long.Parse(uid) && x.Slot == req.PresetInfo.Slot);
		if (totalWarDeckPresetInfoDao == null)
		{
			TotalWarDeckPresetInfoDao insertObj = new TotalWarDeckPresetInfoDao
			{
				Uid = long.Parse(uid),
				Slot = req.PresetInfo.Slot,
				PresetName = req.PresetInfo.PresetName,
				DeckInfo = JsonConvert.SerializeObject(req.PresetInfo.DeckInfo)
			};
			await _db.Insertable(insertObj).ExecuteCommandAsync();
		}
		else
		{
			totalWarDeckPresetInfoDao.PresetName = req.PresetInfo.PresetName;
			totalWarDeckPresetInfoDao.DeckInfo = JsonConvert.SerializeObject(req.PresetInfo.DeckInfo);
			await _db.Updateable(totalWarDeckPresetInfoDao).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new TotalWarDeckPresetSaveResponse());
	}

	public async Task<GameActionResult> TotalWarDeckInfo(string uid)
	{
		TotalWarDeckInfoDao totalWarDeckInfoDao = await _db.Queryable<TotalWarDeckInfoDao>().SingleAsync((TotalWarDeckInfoDao x) => x.Uid == long.Parse(uid));
		TotalWarDeckInfoResponse totalWarDeckInfoResponse = new TotalWarDeckInfoResponse();
		if (totalWarDeckInfoDao != null)
		{
			List<TotalWarDeckDBInfo> values = JsonConvert.DeserializeObject<List<TotalWarDeckDBInfo>>(totalWarDeckInfoDao.DeckInfo);
			totalWarDeckInfoResponse.DeckInfo.AddRange(values);
		}
		return ResultUtil.CreateResult(totalWarDeckInfoResponse);
	}

	public async Task<GameActionResult> TotalWarDeckSave(TotalWarDeckSaveRequest req, string uid)
	{
		TotalWarDeckInfoDao totalWarDeckInfoDao = await _db.Queryable<TotalWarDeckInfoDao>().SingleAsync((TotalWarDeckInfoDao x) => x.Uid == long.Parse(uid));
		if (totalWarDeckInfoDao == null)
		{
			TotalWarDeckInfoDao insertObj = new TotalWarDeckInfoDao
			{
				Uid = long.Parse(uid),
				DeckInfo = JsonConvert.SerializeObject(req.DeckInfo)
			};
			await _db.Insertable(insertObj).ExecuteCommandAsync();
		}
		else
		{
			totalWarDeckInfoDao.DeckInfo = JsonConvert.SerializeObject(req.DeckInfo);
			await _db.Updateable(totalWarDeckInfoDao).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new TotalWarDeckSaveResponse());
	}

	public async Task<GameActionResult> TotalWarBattleStart(TotalWarBattleStartRequest req, string uid)
	{
		await Task.CompletedTask;
		return ResultUtil.CreateResult(new TotalWarBattleStartResponse
		{
			BattleRandomSeed = new Random().Next(0, 1000000),
			EventScheduleInfo = new EventScheduleDBInfo
			{
				Id = 362,
				EventType = Define_EventType.EventWorldBuff,
				EventId = 1,
				EventSubId = 0,
				StartDate = 1723593600000L,
				EndDate = 1734889599000L
			}
		});
	}

	public async Task<GameActionResult> TotalWarBattleEnd(TotalWarBattleEndRequest req, string uid)
	{
		long score = req.ScoreInfo.Sum((BattleDamageDBInfo battleDamageDbInfo) => battleDamageDbInfo.Value);
		TotalWarRankDao totalWarRankDao = await _db.Queryable<TotalWarRankDao>().SingleAsync((TotalWarRankDao x) => x.Uid == long.Parse(uid));
		if (totalWarRankDao == null)
		{
			totalWarRankDao = new TotalWarRankDao
			{
				Uid = long.Parse(uid),
				ScoreData = JsonConvert.SerializeObject(req.ScoreInfo),
				Score = score
			};
			await _db.Insertable(totalWarRankDao).ExecuteCommandAsync();
		}
		else if (score > totalWarRankDao.Score)
		{
			totalWarRankDao.Score = score;
			totalWarRankDao.ScoreData = JsonConvert.SerializeObject(req.ScoreInfo);
			await _db.Updateable(totalWarRankDao).ExecuteCommandAsync();
		}
		List<TotalWarRankDao> list = await _db.Queryable<TotalWarRankDao>().OrderBy((TotalWarRankDao x) => x.Score, OrderByType.Desc).IgnoreColumns((TotalWarRankDao x) => x.ScoreData)
			.ToListAsync();
		int num = list.FindIndex((TotalWarRankDao obj) => obj.Uid == long.Parse(uid)) + 1;
		TotalWarBattleEndResponse totalWarBattleEndResponse = new TotalWarBattleEndResponse();
		totalWarBattleEndResponse.ScoreInfo.AddRange(req.ScoreInfo);
		totalWarBattleEndResponse.TopPercent = Math.Round((double)num / (double)list.Count * 100.0, 2);
		return ResultUtil.CreateResult(totalWarBattleEndResponse);
	}
}
