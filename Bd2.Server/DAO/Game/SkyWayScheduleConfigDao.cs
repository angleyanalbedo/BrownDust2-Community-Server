using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("SkyWayScheduleConfig")]
public class SkyWayScheduleConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "Day", IsNullable = true)]
	public string? Day { get; set; }

	[SugarColumn(ColumnName = "BonusRate")]
	public int BonusRate { get; set; }
}
