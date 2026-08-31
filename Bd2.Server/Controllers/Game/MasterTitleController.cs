using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class MasterTitleController : ControllerBase
{
	private readonly IGameMasterTitleService _masterTitleService;

	public MasterTitleController(IGameMasterTitleService masterTitleService)
	{
		_masterTitleService = masterTitleService;
	}

	[HttpPut]
	public GameActionResult MasterTitleInfo([FromBody] string data)
	{
		return _masterTitleService.MasterTitleInfo(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult MasterTitleInfoUpdate([FromBody] string data)
	{
		var decrypted = AesUtils.AesDecrypt(data);
		return _masterTitleService.MasterTitleInfoUpdate(decrypted, base.User.FindFirst("user").Value);
	}
}
