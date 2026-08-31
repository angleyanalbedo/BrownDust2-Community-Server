using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EventMissionInfo")]
public class EventMissionInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "EventUid")]
	public int EventUid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "Value")]
	public int Value { get; set; }

	[SugarColumn(ColumnName = "IsComplete")]
	public int IsComplete { get; set; }
}
