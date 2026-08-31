using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using EasyTool;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Controllers.Game;

[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class UserController : ControllerBase
{
	private readonly ILogger<UserController> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IGameUserService _gameUserService;

	private readonly IMapper _mapper;

	public UserController(ILogger<UserController> logger, ISqlSugarClient db, IGameUserService gameUserService, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_gameUserService = gameUserService;
	}

	[HttpPut]
	public GameActionResult PersonalInfo([FromBody] string data)
	{
		return _gameUserService.PersonalInfo(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult TutorialInfo([FromBody] string data)
	{
		return _gameUserService.TutorialInfo(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult PresetInfo([FromBody] string data)
	{
		return _gameUserService.PresetInfo(data, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult AttendanceInfo()
	{
		string value = "{\"attendanceTime\":[\"1687564800000\",\"1687737600000\",\"1687910400000\",\"1687996800000\",\"1688083200000\",\"1688169600000\",\"1688169600000\",\"1688342400000\",\"1688342400000\",\"1688515200000\",\"1688774400000\",\"1689638400000\",\"1690070400000\",\"1690588800000\",\"1690934400000\",\"1691452800000\",\"1692316800000\",\"1692662400000\",\"1693440000000\",\"1694563200000\",\"1695427200000\",\"1695600000000\",\"1695945600000\",\"1696291200000\",\"1696550400000\",\"1696896000000\",\"1697241600000\",\"1697500800000\",\"1697846400000\",\"1698105600000\",\"1698451200000\",\"1698883200000\",\"1699401600000\",\"1699920000000\",\"1700265600000\",\"1700611200000\",\"1700956800000\",\"1701388800000\",\"1701820800000\",\"1702166400000\",\"1702598400000\",\"1703030400000\",\"1703548800000\",\"1703894400000\",\"1704153600000\",\"1704585600000\",\"1704931200000\",\"1705276800000\",\"1705536000000\",\"1705708800000\",\"1705795200000\",\"1705968000000\",\"1706054400000\",\"1706227200000\",\"1706313600000\",\"1706400000000\",\"1706572800000\",\"1706745600000\",\"1706832000000\",\"1707004800000\",\"1707091200000\",\"1707177600000\",\"1707523200000\",\"1707696000000\",\"1707782400000\",\"1707868800000\",\"1708041600000\",\"1708128000000\",\"1708300800000\",\"1708473600000\",\"1708646400000\",\"1708819200000\",\"1708905600000\",\"1709337600000\",\"1709510400000\",\"1709596800000\",\"1709769600000\",\"1710720000000\",\"1710979200000\",\"1711065600000\",\"1711152000000\",\"1711238400000\",\"1711324800000\",\"1711411200000\",\"1711497600000\",\"1711584000000\",\"1721952000000\",\"1722038400000\",\"1722124800000\",\"1722211200000\",\"1722297600000\"]}";
		AttendanceInfoResponse message = JsonConvert.DeserializeObject<AttendanceInfoResponse>(value);
		return ResultUtil.CreateResult(message.ToByteArray(), 0);
	}

	[HttpPut]
	public GameActionResult PictorialBookInfo()
	{
		PictorialBookInfoResponse pictorialBookInfoResponse = new PictorialBookInfoResponse();
		pictorialBookInfoResponse.PictorialbookInfo.Add(new PictorialBookDBInfo
		{
			Id = 4,
			GroupId = 2
		});
		pictorialBookInfoResponse.PictorialbookInfo.Add(new PictorialBookDBInfo
		{
			Id = 5,
			GroupId = 1
		});
		return ResultUtil.CreateResult(pictorialBookInfoResponse);
	}

	[HttpPut]
	public GameActionResult AllCharRefresh()
	{
		AllCharRefreshResponse allCharRefreshResponse = new AllCharRefreshResponse();
		allCharRefreshResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.HealthPercent,
			StatValue = 0.8
		});
		allCharRefreshResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.AttackPercent,
			StatValue = 0.8
		});
		allCharRefreshResponse.BuffStatInfo.Add(new PictorialBuffStatDBInfo
		{
			StatType = Define_CharStatOption.MagicPercent,
			StatValue = 0.8
		});
		return ResultUtil.CreateResult(allCharRefreshResponse.ToByteArray(), 165);
	}

	[HttpPut]
	public async Task<GameActionResult> PackPreviewInfo([FromBody] string data)
	{
		PackPreviewInfoRequest req = ProtoUtil.Deserialize<PackPreviewInfoRequest>(data);
		return await _gameUserService.PackPreviewInfo(req, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult MailHistoryInfo([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<MailHistoryInfoRequest>(data);
		return _gameUserService.MailHistoryInfo(request, base.User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult PopularCostumeInfo([FromBody] string data)
	{
		PopularCostumeInfoRequest popularCostumeInfoRequest = ProtoUtil.Deserialize<PopularCostumeInfoRequest>(data);
		PopularCostumeInfoResponse data2 = new PopularCostumeInfoResponse();
		if (popularCostumeInfoRequest.ContentType == 3)
		{
			data2 = PopularCostumeInfoResponse.Parser.ParseFrom(Convert.FromBase64String("Cg0IytwDEPtSGKRFIMBOCg0IiekDEPRRGOBEIIJPCg0I8okEEO1PGPZCIO1MCgsIZxDZThjaQSCmSwoNCPHXAxDuTBj/PiC7SAoNCNrfAxCnSBiUOiCOQgoMCNIIEORHGLI5ILVCCgwIsQkQpkMYmzkgnkMKCwhpENU9GOUxILQ5CgwInRgQozkY0DEg4DkKDQjO4wMQ9DMYsiwgyTMKDQiinAEQtzAY6ygg6S4KDAj4AxDNLxjNKSCOMAoMCKQGEMQsGPYkIOkoCgwIsgIQpiwYySYgxisKDQjP/AMQ+CsYoCIgpygKDQiBjQQQhSoY3CIg0ScKDAi2CRCwKRjbIiD6JgoMCLcJENUiGOQdILMlCg0I4oYEELMiGJYgIPskCg0I+d4DEJQgGJwcILYfCgwIrRsQ0B4Y2BsgrR8KDQihnAEQvRwY5hYg9RsKDQiFnQEQqBsYlRcg4BsKDAj2AxCFGxiyGCCeHAoNCPLXAxDdGRjaFCDxFwoNCOWNBBDRGRjXEyDQFAoNCPPXAxDmFxj8FCDBGAoMCK8CENUXGLkUIJAXCgwI7AcQ1hYY7hIggRQKDQjxiQQQ+xQY2BIglBYKDAiBGRCDFBjDECDzFAoMCK0CENATGIESIPYUCg0IotoDEJoTGMUOIL8QCg0IzvwDEJYSGL8NIIkRCg0I9t4DEMkQGLgOIIwRCgsIZRCODxjPCyCCDgoMCJIDEPYNGMMKIK8LCgwIkwMQ1A0YtAsgwwwKDQjW2AMQ7wwY8gkgiAwKDQjhhgQQ0wwYgQ0g1Q4KDAjCBRCwDBjqCiCWDAoMCOESEPQLGOcLIMAOCg0IntoDENMLGKQJINYKCgwIsAIQnQsYsQog7AsKDQi7iwQQrQoYvwcgkwgKDAj6AxDYCRjGCCDxCQoMCL0FEN4GGJQGIK4GCgwI6gcQ0gYY8AYg4wYKDQiKggQQzgYYlQUgswUKDQiu3QMQiAYY0wQgzAQKDQit3QMQ9gUYkAQgyAQKDQiGnQEQ7gUYzgUgzgYKDAiCGRDSBRjdBCC7BgoLCGoQlQUYqQQgxgUKDQjF1QMQ4gQYwwQgqwUKDQjV2AMQvgQY0AMgxQQKDAimBhCsBBi4BCCQBQoNCLqLBBC8AxiKAyD4AwoLCGYQrAMYqwIgkQMKDQid2gMQnAMY0wIgrAMKDAihBhCFAxj5AiC/AwoNCJXlAxCFAxi6AyDdAwoMCOYZEPgCGN0CIJUDCg0IgdsDEKUCGKwCIP0CCgwIzAEQkQIYjwIgwgIKDQjN4wMQ/AEY8wEgyAIKDAjJARDkARjcASC4AgoMCMoBENEBGN0BIPEBCgwIkQMQtAEY0QEg3AEKDAiWAxCBARiGASCUAQoFCNMIEHkKCQjLARBYGGIgdAoKCI3XAxBMGEAgYwoKCILbAxBLGEIgSQoJCLkXEEQYWSBxCgoI44YEEDYYLCBVCgkIzgEQHBgbIBsKCgjG1QMQHBgbICYKCgjJ3AMQGxgWICEKCgiO1wMQGhgdICoKCQj1AxAWGAwgDgoKCJnsAxAVGBkgHwoKCKXoAxAUGAogDQoJCOYSEBEYCSAPCgkIlQoQEBgSIBAKCgju6QMQChgKIAYKCgjaigQQChgLIAYKCQjpBxAGGAsgBwoJCM0IEAYYCiAJCgoIluUDEAUYBSALCgkI3QsQBBgDIAQKCgjR6gMQBBgBIAEKCgip7wMQBBgBIAEKCQiFBxADGAkgCQoKCKnWAxADGAMgDQoICLHkAxADIAMKCAhoEAIYAiADCgkI2QQQAhgBIAcKCgiF+wMQAhgFIAQKCgjp+wMQAhgBIAMKBgidjAQQAgoJCMEMEAEYAiACCggIutkDEAEYAgoKCMXuAxABGAQgBQoKCNaKBBABGAIgAwoKCJ6MBBABGAEgAgoHCNwEGAEgAQoHCPkKGAIgAQoICObbAxgBIAEKBgiy5AMgAQoICO3pAxgBIAEKBgjS6gMgBAoICKH6AxgCIAY="));
		}
		return ResultUtil.CreateResult(data2);
	}

}
