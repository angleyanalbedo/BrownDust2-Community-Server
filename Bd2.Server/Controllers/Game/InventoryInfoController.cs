using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class InventoryInfoController : ControllerBase
{
	private readonly IGameInventoryInfoService _service;

	public InventoryInfoController(IGameInventoryInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult RecipeInfo([FromBody] string data)
	{
		return _service.RecipeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MyRoomItemInfo([FromBody] string data)
	{
		return _service.MyRoomItemInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult EquipPresetInfo([FromBody] string data)
	{
		return _service.EquipPresetInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult ItemInfo([FromBody] string data)
	{
		return _service.ItemInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult IdCardPresetInfo([FromBody] string data)
	{
		return _service.IdCardPresetInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult RootSortIdInfo([FromBody] string data)
	{
		return _service.RootSortIdInfo(data, User.FindFirst("user").Value);
	}
}
