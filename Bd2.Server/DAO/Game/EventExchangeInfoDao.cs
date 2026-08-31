using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EventExchangeInfo")]
public class EventExchangeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "EventUid")]
	public int EventUid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "Page")]
	public int Page { get; set; }

	[SugarColumn(ColumnName = "KeyCount")]
	public int KeyCount { get; set; }
}
