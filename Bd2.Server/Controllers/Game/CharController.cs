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

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class CharController : ControllerBase
{
	private readonly ILogger<UserController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IGameCharService _gameCharService;

	public CharController(ILogger<UserController> logger, ISqlSugarClient db, IGameCharService gameCharService)
	{
		_db = db;
		_logger = logger;
		_gameCharService = gameCharService;
	}

	[HttpPut]
	public async Task<GameActionResult> CharLevelUp([FromBody] string data)
	{
		CharLevelUpRequest charLevelUp = ProtoUtil.Deserialize<CharLevelUpRequest>(data);
		return await _gameCharService.CharLevelUp(charLevelUp, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CharClassUp([FromBody] string data)
	{
		CharClassUpRequest charClassUp = ProtoUtil.Deserialize<CharClassUpRequest>(data);
		return await _gameCharService.CharClassUp(charClassUp, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CostumeNodeActivation([FromBody] string data)
	{
		CostumeNodeActivationRequest open = ProtoUtil.Deserialize<CostumeNodeActivationRequest>(data);
		return await _gameCharService.CostumeNodeActivation(open, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CostumeUse([FromBody] string data)
	{
		CostumeUseRequest use = ProtoUtil.Deserialize<CostumeUseRequest>(data);
		return await _gameCharService.CostumeUse(use, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CostumePotentialConnect([FromBody] string data)
	{
		CostumePotentialConnectRequest req = ProtoUtil.Deserialize<CostumePotentialConnectRequest>(data);
		return await _gameCharService.CostumePotentialConnect(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CharImprintLevelUp([FromBody] string data)
	{
		CharImprintLevelUpRequest charImprintLevelUpRequest = ProtoUtil.Deserialize<CharImprintLevelUpRequest>(data);
		_logger.LogInformation("刻印:{}", charImprintLevelUpRequest);
		return await _gameCharService.CharImprintLevelUp(charImprintLevelUpRequest, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> CharAwakeActive([FromBody] string data)
	{
		await Task.CompletedTask;
		CharAwakeActiveRequest charAwakeActiveRequest = ProtoUtil.Deserialize<CharAwakeActiveRequest>(data);
		_logger.LogInformation("觉醒:{}", charAwakeActiveRequest);
		return await _gameCharService.CharAwakeActive(charAwakeActiveRequest, base.User.FindFirst("user").Value);
	}
}
