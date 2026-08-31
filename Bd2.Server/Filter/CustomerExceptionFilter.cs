using System.Threading.Tasks;
using Bd2.Server.Common.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Bd2.Server.Filter;

public class CustomerExceptionFilter : IAsyncExceptionFilter, IFilterMetadata
{
	private readonly ILogger<CustomerExceptionFilter> _logger;

	public CustomerExceptionFilter(ILogger<CustomerExceptionFilter> logger)
	{
		_logger = logger;
	}

	public Task OnExceptionAsync(ExceptionContext context)
	{
		if (!context.ExceptionHandled)
		{
			context.Result = new ContentResult
			{
				StatusCode = 200,
				ContentType = "application/json;charset=utf-8",
				Content = JsonConvert.SerializeObject(ResultUtil.CreateErrorResult(-2))
			};
		}
		_logger.LogError(context.Exception, "{}", context.Exception.Message);
		context.ExceptionHandled = true;
		return Task.CompletedTask;
	}
}
