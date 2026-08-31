using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

/// <summary>Provides post-login account and client-status information.</summary>
[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class UserStatusController : ControllerBase
{
	private readonly IGameUserService _gameUserService;

	public UserStatusController(IGameUserService gameUserService)
	{
		_gameUserService = gameUserService;
	}

	[HttpPut]
	public GameActionResult BalanceVersionCheck()
	{
		return ResultUtil.CreateResult(new BalanceVersionCheckResponse());
	}

	[HttpPut]
	public GameActionResult LoginEvent()
	{
		return ResultUtil.CreateResult(new LoginEventResponse());
	}

	[HttpPut]
	public async Task<GameActionResult> NoticeDetailInfo([FromBody] string data)
	{
		NoticeDetailInfoRequest request = ProtoUtil.Deserialize<NoticeDetailInfoRequest>(data);
		return await _gameUserService.NoticeDetailInfo(request.NoticeId);
	}

	[HttpPut]
	public async Task<GameActionResult> ChargeCostInfo()
	{
		return await _gameUserService.ChargeCostInfo(User.FindFirst("user").Value);
	}
}
