using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MissionInfo")]
public class MissionInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "Value")]
	public int Value { get; set; }

	[SugarColumn(ColumnName = "IsComplete")]
	public int IsComplete { get; set; }

	[SugarColumn(ColumnName = "IsReward")]
	public int IsReward { get; set; }
}
