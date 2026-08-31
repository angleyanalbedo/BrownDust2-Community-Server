using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class FishingInfoController : ControllerBase
{
	private readonly IGameFishingInfoService _service;

	public FishingInfoController(IGameFishingInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult FishingItemInfo([FromBody] string data)
	{
		return _service.FishingItemInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FishingInfo([FromBody] string data)
	{
		return _service.FishingInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FishingCollectionInfo([FromBody] string data)
	{
		return _service.FishingCollectionInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FishingTrapInfo([FromBody] string data)
	{
		return _service.FishingTrapInfo(data, User.FindFirst("user").Value);
	}
}
