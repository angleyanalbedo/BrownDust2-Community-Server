using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class EventInfoController : ControllerBase
{
	private readonly IGameEventInfoService _service;

	public EventInfoController(IGameEventInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult CommunityRewardInfo([FromBody] string data)
	{
		return _service.CommunityRewardInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EventHubInfo([FromBody] string data)
	{
		return _service.EventHubInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EventExchangeInfo([FromBody] string data)
	{
		return _service.EventExchangeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EventScheduleInfo([FromBody] string data)
	{
		return _service.EventScheduleInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult ScheduleInfo([FromBody] string data)
	{
		return _service.ScheduleInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EventMissionInfo([FromBody] string data)
	{
		return _service.EventMissionInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MiniEventHubInfo([FromBody] string data)
	{
		return _service.MiniEventHubInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult DailyStoryInfo([FromBody] string data)
	{
		return _service.DailyStoryInfo(data, User.FindFirst("user").Value);
	}
}
