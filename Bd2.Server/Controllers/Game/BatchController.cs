using System;
using System.Collections.Generic;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices;
using Bd2.Server.Model;
using Bd2.Server.Model.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class BatchController : ControllerBase
{
	private readonly ILogger<BatchController> _logger;
	private readonly IBatchService _batchService;

	public BatchController(ILogger<BatchController> logger, IBatchService batchService)
	{
		_logger = logger;
		_batchService = batchService;
	}

	[HttpPut]
	public List<Dictionary<string, object>> BatchRequest([FromBody] string data)
	{
		_logger.LogInformation("BatchRequest: received, data length={}", data?.Length ?? 0);
		string decrypted = AesUtils.AesDecrypt(data);
		_logger.LogInformation("BatchRequest: decrypted, length={}", decrypted?.Length ?? 0);
		List<BatchRequestModel> requests = JsonConvert.DeserializeObject<List<BatchRequestModel>>(decrypted);
		_logger.LogInformation("BatchRequest: parsed, count={}", requests?.Count ?? 0);

		var responses = new List<Dictionary<string, object>>();
		string uid = User.FindFirst("user").Value;
		int success = 0;
		int notImpl = 0;
		int failed = 0;
		var watch = System.Diagnostics.Stopwatch.StartNew();

		foreach (var request in requests)
		{
			_logger.LogInformation("BatchRequest: dispatch path={Path}", request.path);
			try
			{
				if (!_batchService.TryDispatch(request.path, request.requestData, uid, out var response))
				{
					_logger.LogWarning("BatchRequest: NOT IMPLEMENTED: {}", request.path);
					notImpl++;
					continue;
				}

				responses.Add(new Dictionary<string, object>
				{
					{ "path", request.path },
					{ "responseData", response }
				});
				success++;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "BatchRequest: method for path {} failed", request.path);
				failed++;
			}
		}

		watch.Stop();
		_logger.LogInformation("BatchRequest: total={}, success={}, notImpl={}, failed={}, elapsed={}ms", requests.Count, success, notImpl, failed, watch.ElapsedMilliseconds);
		return responses;
	}
}
