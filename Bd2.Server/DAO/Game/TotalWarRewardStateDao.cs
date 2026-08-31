using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("TotalWarRewardState")]
public class TotalWarRewardStateDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "IsRewardReceived")]
	public int IsRewardReceived { get; set; }
}
