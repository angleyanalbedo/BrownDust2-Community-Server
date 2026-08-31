using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class WorldInfoController : ControllerBase
{
	private readonly IGameWorldInfoService _service;

	public WorldInfoController(IGameWorldInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult PackInfo([FromBody] string data)
	{
		return _service.PackInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FieldTrapInfo([FromBody] string data)
	{
		return _service.FieldTrapInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult WaypointInfo([FromBody] string data)
	{
		return _service.WaypointInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult SkyWayScheduleInfo([FromBody] string data)
	{
		return _service.SkyWayScheduleInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FieldObjectInfo([FromBody] string data)
	{
		return _service.FieldObjectInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult SkyWayInfo([FromBody] string data)
	{
		return _service.SkyWayInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult PackInGameInfo([FromBody] string data)
	{
		return _service.PackInGameInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FieldDeckInfo([FromBody] string data)
	{
		return _service.FieldDeckInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FieldEventSpawnInfo([FromBody] string data)
	{
		return _service.FieldEventSpawnInfo(data, User.FindFirst("user").Value);
	}
}
