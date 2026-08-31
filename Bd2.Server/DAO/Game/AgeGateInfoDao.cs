using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("AgeGateInfo")]
public class AgeGateInfoDao
{
	[SugarColumn(ColumnName = "Uid", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "IsJp")]
	public int IsJp { get; set; }

	[SugarColumn(ColumnName = "Year")]
	public int Year { get; set; }

	[SugarColumn(ColumnName = "Month")]
	public int Month { get; set; }

	[SugarColumn(ColumnName = "Day")]
	public int Day { get; set; }
}
