using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class PvpInfoController : ControllerBase
{
	private readonly IGamePvpInfoService _service;

	public PvpInfoController(IGamePvpInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult PvpBattleUserInfo([FromBody] string data)
	{
		return _service.PvpBattleUserInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult ColosseumUserInfo([FromBody] string data)
	{
		return _service.ColosseumUserInfo(data, User.FindFirst("user").Value);
	}
}
