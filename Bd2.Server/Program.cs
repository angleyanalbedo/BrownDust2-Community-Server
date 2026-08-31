using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Autofac.Extensions.DependencyInjection;
using Bd2.Server.Config;
using Bd2.Server.Filter;
using Bd2.Server.Common;
using Bd2.Server.Common.Utils;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Bd2.Server;

public class Program
{
	public static void Main(string[] args)
	{
		WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);

		// HTTPS on 443
		var pfxPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "site.pfx");
		if (System.IO.File.Exists(pfxPath))
		{
			webApplicationBuilder.WebHost.ConfigureKestrel(serverOptions =>
			{
				serverOptions.Listen(IPAddress.Any, 443, listenOptions =>
				{
					listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
					listenOptions.UseHttps(pfxPath, "bd2");
				});
				serverOptions.Listen(IPAddress.Any, 5000, listenOptions =>
				{
					listenOptions.Protocols = HttpProtocols.Http1;
				});
			});
		}
		webApplicationBuilder.Logging.ClearProviders();
		webApplicationBuilder.Logging.AddConsole();
		webApplicationBuilder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
		webApplicationBuilder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(webApplicationBuilder.Environment.ContentRootPath, "keys")));
		webApplicationBuilder.Services.AddControllers(delegate(MvcOptions options)
		{
			options.InputFormatters.Add(new TextInputFormatter());
			options.Filters.Add<CustomerExceptionFilter>();
		});
		webApplicationBuilder.Services.AddRazorPages();
		webApplicationBuilder.Services.AddAuthentication("AdminCookie")
			.AddCookie("AdminCookie", options =>
			{
				options.LoginPath = "/Admin/Login";
				options.AccessDeniedPath = "/Admin/Login";
				options.Cookie.Name = "AdminAuth";
				options.ExpireTimeSpan = TimeSpan.FromHours(24);
			});
		webApplicationBuilder.Services.AddEndpointsApiExplorer();
		webApplicationBuilder.Services.AddSwaggerGen();
		webApplicationBuilder.Services.AddAutoMapperConfig();
		webApplicationBuilder.Services.AddSingleton(new AppSettings(webApplicationBuilder.Configuration));
		webApplicationBuilder.Services.AddJwtSetup();
		webApplicationBuilder.Services.AddSqlsugarSetup();
		webApplicationBuilder.Services.RegisterApiServices();
		webApplicationBuilder.Services.AddHostedService<EquipmentOptionService>();
		WebApplication webApplication = webApplicationBuilder.Build();
		if (webApplication.Environment.IsDevelopment())
		{
			webApplication.UseSwagger();
			webApplication.UseSwaggerUI();
		}
		webApplication.Use(async (context, next) =>
		{
			var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
			logger.LogInformation("=> {Method} {Path}", context.Request.Method, context.Request.Path);
			await next();
			if (context.Response.StatusCode == 404 && context.Request.Path.StartsWithSegments("/Game"))
			{
				logger.LogWarning("NOT IMPLEMENTED: {Method} {Path}", context.Request.Method, context.Request.Path);
				context.Response.StatusCode = 200;
				context.Response.ContentType = "application/json;charset=utf-8";
				var result = ResultUtil.CreateErrorResult(-3);
				result.errorMessage = "接口未实现";
				var json = JsonConvert.SerializeObject(result);
				await context.Response.WriteAsync(json);
			}
		});

		webApplication.UseAuthentication();
		webApplication.UseAuthorization();
		webApplication.UseDefaultFiles();
		webApplication.UseStaticFiles(new StaticFileOptions
		{
			ServeUnknownFileTypes = true,
			DefaultContentType = "binary/octet-stream"
		});
		webApplication.MapControllers();
		webApplication.MapRazorPages();

		webApplication.Run();
	}
}
