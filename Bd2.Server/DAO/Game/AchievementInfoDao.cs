using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("AchievementInfo")]
public class AchievementInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "Value")]
	public long Value { get; set; }

	[SugarColumn(ColumnName = "MaxClearId")]
	public int MaxClearId { get; set; }
}
