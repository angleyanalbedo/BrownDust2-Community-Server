using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class HuntInfoController : ControllerBase
{
	private readonly IGameHuntInfoService _service;

	public HuntInfoController(IGameHuntInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult DispatchInfo([FromBody] string data)
	{
		return _service.DispatchInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MonsterHuntDeckInfo([FromBody] string data)
	{
		return _service.MonsterHuntDeckInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult HuntDispatchInfo([FromBody] string data)
	{
		return _service.HuntDispatchInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MonsterHuntScheduleInfo([FromBody] string data)
	{
		return _service.MonsterHuntScheduleInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MonsterHuntUserInfo([FromBody] string data)
	{
		return _service.MonsterHuntUserInfo(data, User.FindFirst("user").Value);
	}
}
