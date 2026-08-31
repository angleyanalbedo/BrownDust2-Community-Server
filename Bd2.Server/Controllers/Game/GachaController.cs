using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class GachaController : ControllerBase
{
	private readonly ILogger<GachaController> _logger;

	private readonly IGameGachaService _gameGachaService;

	public GachaController(ILogger<GachaController> logger, IGameGachaService gameGachaService)
	{
		_gameGachaService = gameGachaService;
		_logger = logger;
	}

	[HttpPut]
	public async Task<GameActionResult> GachaInfo()
	{
		return await _gameGachaService.GachaInfo();
	}

	[HttpPut]
	public Task<GameActionResult> GachaBuy([FromBody] string data)
	{
		GachaBuyRequest gachaBuyRequest = ProtoUtil.Deserialize<GachaBuyRequest>(data);
		_logger.LogInformation("抽卡入参 {}", gachaBuyRequest);
		return _gameGachaService.GachaBuy(gachaBuyRequest, base.User.FindFirst("user").Value);
	}
}
