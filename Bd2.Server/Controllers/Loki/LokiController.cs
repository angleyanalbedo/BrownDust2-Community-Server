using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.DAO.Game;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Loki;

[ApiController]
[Route("[controller]")]
public class LokiController : ControllerBase
{
	private readonly ILogger<LokiController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public LokiController(ILogger<LokiController> logger, ISqlSugarClient db, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
	}

	[HttpPost("~/loki/api/v1/push")]
	[HttpPost("push")]
	public ActionResult<object> PushLog()
	{
		return new ContentResult
		{
			StatusCode = 204
		};
	}

	[HttpPost("[Action]")]
	public string Post()
	{
		string value = base.User.FindFirst("user").Value;
		_logger.LogInformation(value);
		return "ok";
	}

	[HttpGet("test")]
	public async Task<string> Test()
	{
		await Task.CompletedTask;
		foreach (EquipInfoDao item in await _db.Queryable<EquipInfoDao>().ToListAsync())
		{
			EquipmentTable equipmentById = EquipmentManager.GetEquipmentById(item.Id);
			item.SlotType = equipmentById.SlotType;
			_logger.LogInformation("变更：{}", equipmentById.SlotType);
			await _db.Updateable(item).ExecuteCommandAsync();
		}
		return "ok";
	}
}
