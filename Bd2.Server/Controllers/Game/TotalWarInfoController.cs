using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class TotalWarInfoController : ControllerBase
{
	private readonly IGameTotalWarInfoService _service;

	public TotalWarInfoController(IGameTotalWarInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult TotalWarRewardState([FromBody] string data)
	{
		return _service.TotalWarRewardState(data, User.FindFirst("user").Value);
	}
}
