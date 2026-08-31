using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MiniGameHubInfo")]
public class MiniGameHubInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Slot")]
	public int Slot { get; set; }

	[SugarColumn(ColumnName = "EventUid")]
	public int EventUid { get; set; }

	[SugarColumn(ColumnName = "ProgressType")]
	public int ProgressType { get; set; }
}
