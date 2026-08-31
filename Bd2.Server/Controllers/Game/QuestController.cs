using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class QuestController : ControllerBase
{
	private readonly ILogger<QuestController> _logger;

	private readonly IGameQuestService _gameQuestService;

	public QuestController(ILogger<QuestController> logger, IGameQuestService gameQuestService)
	{
		_gameQuestService = gameQuestService;
		_logger = logger;
	}

	[HttpPut]
	public async Task<GameActionResult> QuestClear([FromBody] string data)
	{
		QuestClearRequest req = ProtoUtil.Deserialize<QuestClearRequest>(data);
		return await _gameQuestService.QuestClear(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> QuestUpdate([FromBody] string data)
	{
		QuestUpdateRequest req = ProtoUtil.Deserialize<QuestUpdateRequest>(data);
		return await _gameQuestService.QuestUpdate(req, base.User.FindFirst("user").Value);
	}
}
