using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SqlSugar;

namespace Bd2.Server.Common.DB;

public class BaseDBConfig
{
	public static readonly List<ConnectionConfig> AllConfigs = new List<ConnectionConfig>();

	public static List<ConnectionConfig> ValidConfig = new List<ConnectionConfig>();

	public static ConnectionConfig MainConfig;

	public static ConnectionConfig LogConfig;

	public static bool IsMulti => ValidConfig.Count > 1;

	public static (List<MutiDBOperate> allDbs, List<MutiDBOperate> slaveDbs) MutiConnectionString => MutiInitConn();

	public static (List<MutiDBOperate>, List<MutiDBOperate>) MutiInitConn()
	{
		List<MutiDBOperate> list = (from i in AppSettings.app<MutiDBOperate>(new string[1] { "DBS" })
			where i.Enabled
			select i).ToList();
		string mainDbId = AppSettings.app("MainDB").ToString();
		MutiDBOperate mutiDBOperate = list.Single((MutiDBOperate d) => d.ConnId == mainDbId);
		list.Remove(mutiDBOperate);
		list.Insert(0, mutiDBOperate);
		foreach (MutiDBOperate item in list)
		{
			SpecialDbString(item);
		}
		return (list, mutiDBOperate.Slaves);
	}

	private static string DifDBConnOfSecurity(params string[] conn)
	{
		foreach (string path in conn)
		{
			try
			{
				if (File.Exists(path))
				{
					return File.ReadAllText(path).Trim();
				}
			}
			catch (Exception)
			{
			}
		}
		return conn[^1];
	}

	private static MutiDBOperate SpecialDbString(MutiDBOperate mutiDBOperate)
	{
		if (mutiDBOperate.DbType == DataBaseType.Sqlite)
		{
			mutiDBOperate.Connection = "DataSource=" + Path.Combine(Environment.CurrentDirectory, mutiDBOperate.Connection);
		}
		else if (mutiDBOperate.DbType == DataBaseType.SqlServer)
		{
			mutiDBOperate.Connection = DifDBConnOfSecurity("db-credentials.txt", mutiDBOperate.Connection);
		}
		else if (mutiDBOperate.DbType == DataBaseType.MySql)
		{
			mutiDBOperate.Connection = DifDBConnOfSecurity("db-credentials.txt", mutiDBOperate.Connection);
		}
		else if (mutiDBOperate.DbType == DataBaseType.Oracle)
		{
			mutiDBOperate.Connection = DifDBConnOfSecurity("db-credentials.txt", mutiDBOperate.Connection);
		}
		return mutiDBOperate;
	}
}
