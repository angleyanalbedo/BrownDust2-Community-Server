using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EventHubConfig")]
public class EventHubConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public int Uid { get; set; }

	[SugarColumn(ColumnName = "HubId")]
	public int HubId { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "PlayEndTime")]
	public long PlayEndTime { get; set; }

	[SugarColumn(ColumnName = "EndTime")]
	public long EndTime { get; set; }
}

[SugarTable("EventHubSettingConfig")]
public class EventHubSettingConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "HubUid")]
	public int HubUid { get; set; }

	[SugarColumn(ColumnName = "Slot")]
	public int Slot { get; set; }

	[SugarColumn(ColumnName = "HubContentType")]
	public int HubContentType { get; set; }

	[SugarColumn(ColumnName = "EventUids", IsNullable = true)]
	public string? EventUids { get; set; }
}
