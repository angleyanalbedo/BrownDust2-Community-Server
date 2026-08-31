using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Bd2.Server.Config;

public class TextInputFormatter : InputFormatter
{
	public TextInputFormatter()
	{
		((Collection<string>)base.SupportedMediaTypes).Add("text/plain");
		((Collection<string>)base.SupportedMediaTypes).Add("multipart/form-data");
		((Collection<string>)base.SupportedMediaTypes).Add("application/octet-stream");
		((Collection<string>)base.SupportedMediaTypes).Add("application/x-www-form-urlencoded");
		((Collection<string>)base.SupportedMediaTypes).Add("*/*");
	}

	public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
	{
		HttpRequest request = context.HttpContext.Request;
		using var ms = new MemoryStream();
		await request.Body.CopyToAsync(ms);
		string body = Encoding.UTF8.GetString(ms.ToArray());
		return await InputFormatterResult.SuccessAsync(body);
	}

	protected override bool CanReadType(Type type)
	{
		return type == typeof(string);
	}
}