using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CashShopConfig")]
public class CashShopConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "ProductId")]
	public int ProductId { get; set; }

	[SugarColumn(ColumnName = "SaleGroup")]
	public int SaleGroup { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "EndTime")]
	public long EndTime { get; set; }

	[SugarColumn(ColumnName = "EndDelayMinutes")]
	public int EndDelayMinutes { get; set; }

	[SugarColumn(ColumnName = "DailyResetTime")]
	public long DailyResetTime { get; set; }

	[SugarColumn(ColumnName = "WeeklyResetTime")]
	public long WeeklyResetTime { get; set; }

	[SugarColumn(ColumnName = "MonthlyResetTime")]
	public long MonthlyResetTime { get; set; }
}
