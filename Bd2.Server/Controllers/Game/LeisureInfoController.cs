using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class LeisureInfoController : ControllerBase
{
	private readonly IGameLeisureInfoService _service;

	public LeisureInfoController(IGameLeisureInfoService service)
	{
		_service = service;
	}

	[HttpPut]
	public GameActionResult CafeteriaInfo([FromBody] string data)
	{
		return _service.CafeteriaInfo(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult CafeteriaLevelUp([FromBody] string data)
	{
		return _service.CafeteriaLevelUp(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult CafeteriaManageItemAdd([FromBody] string data)
	{
		return _service.CafeteriaManageItemAdd(data, User.FindFirst("user").Value);
	}

	[HttpPut] public GameActionResult CafeteriaIntroductionStoryReward([FromBody] string data) => _service.CafeteriaIntroductionStoryReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaCumulativeReward([FromBody] string data) => _service.CafeteriaCumulativeReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaSpawnReset([FromBody] string data) => _service.CafeteriaSpawnReset(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaSpawnResetCheat([FromBody] string data) => _service.CafeteriaSpawnResetCheat(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaDailyConnectionCostumeRefresh([FromBody] string data) => _service.CafeteriaDailyConnectionCostumeRefresh(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRegularCostumeNoteInfo([FromBody] string data) => _service.CafeteriaRegularCostumeNoteInfo(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRegularCostumeNoteReward([FromBody] string data) => _service.CafeteriaRegularCostumeNoteReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRegularCostumeNoteAllReward([FromBody] string data) => _service.CafeteriaRegularCostumeNoteAllReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRegularCostumeInteractionReward([FromBody] string data) => _service.CafeteriaRegularCostumeInteractionReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRegularCostumeInteractionAllReward([FromBody] string data) => _service.CafeteriaRegularCostumeInteractionAllReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRewardReceiptTimeUpdateUsingCheat([FromBody] string data) => _service.CafeteriaRewardReceiptTimeUpdateUsingCheat(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaEventNpcInteractionReward([FromBody] string data) => _service.CafeteriaEventNpcInteractionReward(data, User.FindFirst("user").Value);
	[HttpPut] public GameActionResult CafeteriaRareNpcInteractionReward([FromBody] string data) => _service.CafeteriaRareNpcInteractionReward(data, User.FindFirst("user").Value);
	[HttpPut]
	public GameActionResult MiniGameHubInfo([FromBody] string data)
	{
		return _service.MiniGameHubInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult DatingInfo([FromBody] string data)
	{
		return _service.DatingInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult LifeInfo([FromBody] string data)
	{
		return _service.LifeInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult CharVoteInfo([FromBody] string data)
	{
		return _service.CharVoteInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult MiniGameDefenseInfo([FromBody] string data)
	{
		return _service.MiniGameDefenseInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult FireWorksInfo([FromBody] string data)
	{
		return _service.FireWorksInfo(data, User.FindFirst("user").Value);
	}
	[HttpPut]
	public GameActionResult LifeUserInfo([FromBody] string data)
	{
		return _service.LifeUserInfo(data, User.FindFirst("user").Value);
	}
}
