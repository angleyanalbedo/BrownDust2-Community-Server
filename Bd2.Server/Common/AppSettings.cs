using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Bd2.Server.Common;

public class AppSettings
{
	public static IConfiguration Configuration { get; set; }

	private static string contentPath { get; set; }

	public AppSettings(string contentPath)
	{
		string path = "appsettings.json";
		Configuration = new ConfigurationBuilder().SetBasePath(contentPath).Add(new JsonConfigurationSource
		{
			Path = path,
			Optional = false,
			ReloadOnChange = true
		}).Build();
	}

	public AppSettings(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public static string app(params string[] sections)
	{
		try
		{
			if (sections.Any())
			{
				return Configuration[string.Join(":", sections)];
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static List<T> app<T>(params string[] sections)
	{
		List<T> list = new List<T>();
		Configuration.Bind(string.Join(":", sections), list);
		return list;
	}

	public static string GetValue(string sectionsPath)
	{
		try
		{
			return Configuration[sectionsPath];
		}
		catch (Exception)
		{
		}
		return "";
	}
}
