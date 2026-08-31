using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class EvilCastleController : ControllerBase
{
	private readonly IGameEvilCastleInfoService _service;

	public EvilCastleController(IGameEvilCastleInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult EvilCastleRogueLikeAllUserScoreInfo([FromBody] string data)
	{
		return _service.EvilCastleRogueLikeAllUserScoreInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleInfo([FromBody] string data)
	{
		return _service.EvilCastleInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleTowerInfo([FromBody] string data)
	{
		return _service.EvilCastleTowerInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleEnter([FromBody] string data)
	{
		return _service.EvilCastleEnter(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleRogueLikeInfo([FromBody] string data)
	{
		return _service.EvilCastleRogueLikeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleRewardInfo([FromBody] string data)
	{
		return _service.EvilCastleRewardInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EvilCastleDailyRewardState([FromBody] string data)
	{
		return _service.EvilCastleDailyRewardState(data, User.FindFirst("user").Value);
	}
}
