using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class ProgressInfoController : ControllerBase
{
	private readonly IGameProgressInfoService _service;

	public ProgressInfoController(IGameProgressInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult QuestMaxClearInfo([FromBody] string data)
	{
		return _service.QuestMaxClearInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult AchievementInfo([FromBody] string data)
	{
		return _service.AchievementInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult SeasonRewardInfo([FromBody] string data)
	{
		return _service.SeasonRewardInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult PassInfo([FromBody] string data)
	{
		return _service.PassInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MissionInfo([FromBody] string data)
	{
		return _service.MissionInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult NoticeInfo([FromBody] string data)
	{
		return _service.NoticeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MailInfo([FromBody] string data)
	{
		return _service.MailInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CashMailInfo([FromBody] string data)
	{
		return _service.CashMailInfo(data, User.FindFirst("user").Value);
	}
}
