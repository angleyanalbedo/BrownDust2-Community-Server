using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class CharacterInfoController : ControllerBase
{
	private readonly IGameCharacterInfoService _service;

	public CharacterInfoController(IGameCharacterInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult CharInfo([FromBody] string data)
	{
		return _service.CharInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CostumeInfo([FromBody] string data)
	{
		return _service.CostumeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CharAwakeInfo([FromBody] string data)
	{
		return _service.CharAwakeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult AvatarInfo([FromBody] string data)
	{
		return _service.AvatarInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult PrestigeSkinInfo([FromBody] string data)
	{
		return _service.PrestigeSkinInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult SpineInteractionAchievementInfo([FromBody] string data)
	{
		return _service.SpineInteractionAchievementInfo(data, User.FindFirst("user").Value);
	}
}
