using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class SocialInfoController : ControllerBase
{
	private readonly IGameSocialInfoService _service;

	public SocialInfoController(IGameSocialInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult CharPartnerInfo([FromBody] string data)
	{
		return _service.CharPartnerInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MyLikeInfo([FromBody] string data)
	{
		return _service.MyLikeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult GuildInitInfo([FromBody] string data)
	{
		return _service.GuildInitInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FriendInfoList([FromBody] string data)
	{
		return _service.FriendInfoList(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FriendshipInfo([FromBody] string data)
	{
		return _service.FriendshipInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult GuildRaidSeasonReward([FromBody] string data)
	{
		return _service.GuildRaidSeasonReward(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult RoomChatReportAndBlockInfo([FromBody] string data)
	{
		return _service.RoomChatReportAndBlockInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FriendshipSpecialEpisodeInfo([FromBody] string data)
	{
		return _service.FriendshipSpecialEpisodeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FriendshipGift([FromBody] string data) => _service.FriendshipGift(data, User.FindFirst("user").Value);

	[HttpPut]
	public GameActionResult FriendshipCounseling([FromBody] string data) => _service.FriendshipCounseling(data, User.FindFirst("user").Value);

	[HttpPut]
	public GameActionResult FriendshipSpecialEpisodeClear([FromBody] string data) => _service.FriendshipSpecialEpisodeClear(data, User.FindFirst("user").Value);
}
