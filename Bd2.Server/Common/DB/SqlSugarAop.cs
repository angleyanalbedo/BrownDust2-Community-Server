using System;
using SqlSugar;

namespace Bd2.Server.Common.DB;

public static class SqlSugarAop
{
	public static void OnLogExecuting(ISqlSugarClient sqlSugarScopeProvider, string table, string operate, string sql, SugarParameter[] p, ConnectionConfig config)
	{
		try
		{
			Console.WriteLine(string.Format($"------------------ \r\nTable:[{table}]  Operate:[{operate}] ConnId:[{config.ConfigId}]【SQL语句】: \r\n {UtilMethods.GetNativeSql(sql, p)}"));
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error occured OnLogExcuting:" + ex);
		}
	}
}
