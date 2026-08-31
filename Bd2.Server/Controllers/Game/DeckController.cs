using System.Collections.Generic;
using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class DeckController : ControllerBase
{
	private readonly ILogger<DeckController> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IGameUserService _gameUserService;
	private readonly IGameWorldInfoService _worldInfoService;

	public DeckController(ILogger<DeckController> logger, ISqlSugarClient db, IGameUserService gameUserService, IGameWorldInfoService worldInfoService)
	{
		_logger = logger;
		_db = db;
		_gameUserService = gameUserService;
		_worldInfoService = worldInfoService;
	}

	[HttpPut]
	public async Task<GameActionResult> DeckSave([FromBody] string data)
	{
		DeckSaveRequest deck = ProtoUtil.Deserialize<DeckSaveRequest>(data);
		#if DEBUG
		_logger.LogInformation("DeckSave data is :{}", data);
		#endif
		return await _gameUserService.DeckSave(deck, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> FieldDeckSave([FromBody] string data)
	{
		var req = ProtoUtil.Deserialize<FieldDeckSaveRequest>(data);
		var uid = long.Parse(base.User.FindFirst("user").Value);
		await _db.Deleteable<FieldDeckInfoDao>().Where(x => x.Uid == uid).ExecuteCommandAsync();
		var list = new List<FieldDeckInfoDao>();
		foreach (var item in req.FieldDeckInfo)
		{
			list.Add(new FieldDeckInfoDao
			{
				Uid = uid,
				Sequence = item.Sequence,
				CharInvenIndex = item.CharInvenIndex,
				CostumeInvenIndex = item.CostumeInvenIndex
			});
		}
		if (list.Count > 0)
		{
			await _db.Insertable(list).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new FieldDeckSaveResponse());
	}

	[HttpPut]
	public GameActionResult SaveFieldCharControlDeckType([FromBody] string data)
	{
		return _worldInfoService.SaveFieldCharControlDeckType(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> PresetInfoChange([FromBody] string data)
	{
		PresetInfoChangeRequest req = ProtoUtil.Deserialize<PresetInfoChangeRequest>(data);
		return await _gameUserService.PresetInfoChange(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> PresetSave([FromBody] string data)
	{
		PresetSaveRequest req = ProtoUtil.Deserialize<PresetSaveRequest>(data);
		return await _gameUserService.PresetSave(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> PresetDelete([FromBody] string data)
	{
		PresetDeleteRequest req = ProtoUtil.Deserialize<PresetDeleteRequest>(data);
		return await _gameUserService.PresetDelete(req, base.User.FindFirst("user").Value);
	}
}
