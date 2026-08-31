using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class DeckInfoController : ControllerBase
{
	private readonly IGameDeckInfoService _service;

	public DeckInfoController(IGameDeckInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult DeckInfo([FromBody] string data)
	{
		return _service.DeckInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult DeckCostumeSettingInfo([FromBody] string data)
	{
		return _service.DeckCostumeSettingInfo(data, User.FindFirst("user").Value);
	}
}
