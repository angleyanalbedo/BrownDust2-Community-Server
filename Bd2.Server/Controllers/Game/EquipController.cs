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
public class EquipController : ControllerBase
{
	private readonly IGameEquipService _gameEquipService;

	private readonly ILogger<EquipController> _logger;

	public EquipController(IGameEquipService gameEquipService, ILogger<EquipController> logger)
	{
		_gameEquipService = gameEquipService;
		_logger = logger;
	}

	[HttpPut]
	public async Task<GameActionResult> EquipInfo()
	{
		return await _gameEquipService.EquipInfo(base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipSmelting([FromBody] string data)
	{
		EquipSmeltingRequest equipSmeltingRequest = ProtoUtil.Deserialize<EquipSmeltingRequest>(data);
		return await _gameEquipService.EquipSmelting(equipSmeltingRequest.InvenIndex);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipUse([FromBody] string data)
	{
		EquipUseRequest equipUse = ProtoUtil.Deserialize<EquipUseRequest>(data);
		return await _gameEquipService.EquipUse(equipUse);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipChange([FromBody] string data)
	{
		EquipChangeRequest equipChange = ProtoUtil.Deserialize<EquipChangeRequest>(data);
		return await _gameEquipService.EquipChange(equipChange);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipClear([FromBody] string data)
	{
		EquipClearRequest equipClear = ProtoUtil.Deserialize<EquipClearRequest>(data);
		return await _gameEquipService.EquipClear(equipClear);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipBatchUse([FromBody] string data)
	{
		EquipBatchUseRequest equipBatchUse = ProtoUtil.Deserialize<EquipBatchUseRequest>(data);
		return await _gameEquipService.EquipBatchUse(equipBatchUse);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipUpgrade([FromBody] string data)
	{
		EquipUpgradeRequest equipUpgrade = ProtoUtil.Deserialize<EquipUpgradeRequest>(data);
		return await _gameEquipService.EquipUpgrade(equipUpgrade, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipSequenceUpgrade([FromBody] string data)
	{
		EquipSequenceUpgradeRequest req = ProtoUtil.Deserialize<EquipSequenceUpgradeRequest>(data);
		return await _gameEquipService.EquipSequenceUpgrade(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipSequenceSmelting([FromBody] string data)
	{
		EquipSequenceSmeltingRequest req = ProtoUtil.Deserialize<EquipSequenceSmeltingRequest>(data);
		return await _gameEquipService.EquipSequenceSmelting(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipOptionReRoll([FromBody] string data)
	{
		EquipOptionReRollRequest req = ProtoUtil.Deserialize<EquipOptionReRollRequest>(data);
		return await _gameEquipService.EquipOptionReRoll(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipOptionReRollConfirm([FromBody] string data)
	{
		EquipOptionReRollConfirmRequest req = ProtoUtil.Deserialize<EquipOptionReRollConfirmRequest>(data);
		return await _gameEquipService.EquipOptionReRollConfirm(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> EquipBreak([FromBody] string data)
	{
		EquipBreakRequest req = ProtoUtil.Deserialize<EquipBreakRequest>(data);
		return await _gameEquipService.EquipBreak(req, base.User.FindFirst("user").Value);
	}
}
