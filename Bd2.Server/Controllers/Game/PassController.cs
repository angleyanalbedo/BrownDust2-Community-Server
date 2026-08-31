using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public sealed class PassController : ControllerBase
{
	private readonly IGamePassService _service;

	public PassController(IGamePassService service) => _service = service;

	[HttpPut]
	public GameActionResult PassReward([FromBody] string data) => _service.PassReward(data, User.FindFirst("user")!.Value);

	[HttpPut]
	public GameActionResult PassBuy([FromBody] string data) => _service.PassBuy(data, User.FindFirst("user")!.Value);
}
