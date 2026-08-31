using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MiniGameDefenseInfo")]
public class MiniGameDefenseInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "EventScheduleId")]
	public int EventScheduleId { get; set; }

	[SugarColumn(ColumnName = "RewardInfo", IsNullable = true)]
	public string? RewardInfo { get; set; }
}
