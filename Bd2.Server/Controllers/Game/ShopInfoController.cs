using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class ShopInfoController : ControllerBase
{
	private readonly IGameShopInfoService _service;

	public ShopInfoController(IGameShopInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult CashShopInfo([FromBody] string data)
	{
		return _service.CashShopInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CharScoutInfo([FromBody] string data)
	{
		return _service.CharScoutInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CashBonusInfo([FromBody] string data)
	{
		return _service.CashBonusInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult AvatarShopWishListInfo([FromBody] string data)
	{
		return _service.AvatarShopWishListInfo(data, User.FindFirst("user").Value);
	}
}
