using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MiniEventHubSlotInfo")]
public class MiniEventHubSlotInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "HubIndex")]
	public long HubIndex { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "HubContentType")]
	public int HubContentType { get; set; }

	[SugarColumn(ColumnName = "HubContentId")]
	public int HubContentId { get; set; }

	[SugarColumn(ColumnName = "EventUid")]
	public int EventUid { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "EndTime")]
	public long EndTime { get; set; }
}
