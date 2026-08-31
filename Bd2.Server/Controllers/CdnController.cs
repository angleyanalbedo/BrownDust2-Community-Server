using System.Linq;
using System.Threading.Tasks;
using Bd2.Server.Common.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bd2.Server.Controllers;

[ApiController]
public class CdnController : ControllerBase
{
	private readonly ILogger<CdnController> _logger;

	public CdnController(ILogger<CdnController> logger)
	{
		_logger = logger;
	}

	[HttpGet("/StandaloneWindows64/{*path}")]
	[HttpGet("/PC/{*path}")]
	[HttpGet("/media/{*path}")]
	public async Task Proxy()
	{
		var url = $"https://mt.bd2.pmang.cloud{Request.Path.Value}";
		_logger.LogInformation("CDN: {Path}", Request.Path.Value);
		var resp = await OfficialDns.GetAsync(url);
		Response.StatusCode = (int)resp.StatusCode;
		foreach (var h in resp.Headers)
			if (h.Key != "Transfer-Encoding")
				Response.Headers[h.Key] = h.Value.ToArray();
		foreach (var h in resp.Content.Headers)
			Response.Headers[h.Key] = h.Value.ToArray();
		await resp.Content.CopyToAsync(Response.Body);
	}
}