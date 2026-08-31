using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EventScheduleConfig")]
public class EventScheduleConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "EventType")]
	public int EventType { get; set; }

	[SugarColumn(ColumnName = "EventId")]
	public int EventId { get; set; }

	[SugarColumn(ColumnName = "EventSubId")]
	public int EventSubId { get; set; }

	[SugarColumn(ColumnName = "StartDate")]
	public long StartDate { get; set; }

	[SugarColumn(ColumnName = "EndDate")]
	public long EndDate { get; set; }
}
