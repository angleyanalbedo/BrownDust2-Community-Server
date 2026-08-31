using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("DailyStoryInfo")]
public class DailyStoryInfoDao
{
	[SugarColumn(ColumnName = "Uid", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Info", IsNullable = true)]
	public string? Info { get; set; }
}
