using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
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
public class TotalWarController : ControllerBase
{
	private readonly ILogger<TotalWarController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IGameTotalWarService _gameTotalWarService;

	public TotalWarController(ILogger<TotalWarController> logger, ISqlSugarClient db, IGameTotalWarService gameTotalWarService)
	{
		_db = db;
		_logger = logger;
		_gameTotalWarService = gameTotalWarService;
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarInfo()
	{
		return await _gameTotalWarService.TotalWarInfo(base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarDeckPresetInfo()
	{
		return await _gameTotalWarService.TotalWarDeckPresetInfo(base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarDeckSave([FromBody] string data)
	{
		TotalWarDeckSaveRequest req = ProtoUtil.Deserialize<TotalWarDeckSaveRequest>(data);
		return await _gameTotalWarService.TotalWarDeckSave(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarDeckPresetSave([FromBody] string data)
	{
		TotalWarDeckPresetSaveRequest req = ProtoUtil.Deserialize<TotalWarDeckPresetSaveRequest>(data);
		return await _gameTotalWarService.TotalWarDeckPresetSave(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarDeckInfo()
	{
		return await _gameTotalWarService.TotalWarDeckInfo(base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarBattleStart([FromBody] string data)
	{
		return await _gameTotalWarService.TotalWarBattleStart(ProtoUtil.Deserialize<TotalWarBattleStartRequest>(data), base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TotalWarBattleEnd([FromBody] string data)
	{
		return await _gameTotalWarService.TotalWarBattleEnd(ProtoUtil.Deserialize<TotalWarBattleEndRequest>(data), base.User.FindFirst("user").Value);
	}
}
