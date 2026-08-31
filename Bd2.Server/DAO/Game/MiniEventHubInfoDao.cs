using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MiniEventHubInfo")]
public class MiniEventHubInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "HubUid")]
	public int HubUid { get; set; }

	[SugarColumn(ColumnName = "HubId")]
	public int HubId { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "PlayEndTime")]
	public long PlayEndTime { get; set; }

	[SugarColumn(ColumnName = "EndTime")]
	public long EndTime { get; set; }
}
