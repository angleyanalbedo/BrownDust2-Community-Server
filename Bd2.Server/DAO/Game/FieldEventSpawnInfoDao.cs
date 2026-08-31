using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FieldEventSpawnInfo")]
public class FieldEventSpawnInfoDao
{
	[SugarColumn(ColumnName = "Uid", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "EventScheduleId")]
	public int EventScheduleId { get; set; }

	[SugarColumn(ColumnName = "SpawnEventId")]
	public int SpawnEventId { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "DailyNormalCount")]
	public int DailyNormalCount { get; set; }

	[SugarColumn(ColumnName = "DailySpecialCount")]
	public int DailySpecialCount { get; set; }

	[SugarColumn(ColumnName = "CaughtInfo", IsNullable = true)]
	public string? CaughtInfo { get; set; }
}
