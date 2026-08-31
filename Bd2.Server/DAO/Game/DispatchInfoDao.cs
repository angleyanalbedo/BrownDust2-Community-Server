using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("DispatchInfo")]
public class DispatchInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "DispatchId")]
	public int DispatchId { get; set; }

	[SugarColumn(ColumnName = "StartTime")]
	public long StartTime { get; set; }

	[SugarColumn(ColumnName = "CharInvenIndex", IsNullable = true)]
	public string? CharInvenIndex { get; set; }

	[SugarColumn(ColumnName = "IsComplete")]
	public int IsComplete { get; set; }

	[SugarColumn(ColumnName = "IsReward")]
	public int IsReward { get; set; }
}
