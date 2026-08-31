using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class TalentController : ControllerBase
{
	private readonly ILogger<TalentController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	private readonly IGameTalentServer _gameTalentServer;

	public TalentController(ILogger<TalentController> logger, ISqlSugarClient db, IMapper mapper, IGameTalentServer gameTalentServer)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_gameTalentServer = gameTalentServer;
	}

	[HttpPut]
	public async Task<GameActionResult> TalentSkillUse([FromBody] string data)
	{
		TalentSkillUseRequest req = ProtoUtil.Deserialize<TalentSkillUseRequest>(data);
		return await _gameTalentServer.TalentSkillUse(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TalentSkillUpgrade([FromBody] string data)
	{
		TalentSkillUpgradeRequest req = ProtoUtil.Deserialize<TalentSkillUpgradeRequest>(data);
		return await _gameTalentServer.TalentSkillUpgrade(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipMaking([FromBody] string data)
	{
		return await _gameTalentServer.EquipMaking(ProtoUtil.Deserialize<EquipMakingRequest>(data), base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> Alchemy([FromBody] string data)
	{
		return await _gameTalentServer.Alchemy(ProtoUtil.Deserialize<AlchemyRequest>(data), base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> AlchemyBatch([FromBody] string data)
	{
		return await _gameTalentServer.AlchemyBatch(ProtoUtil.Deserialize<AlchemyBatchRequest>(data), base.User.FindFirst("user").Value);
	}
}
