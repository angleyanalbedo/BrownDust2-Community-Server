using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("WayPointInfo")]
public class WayPointInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "PointId", IsNullable = true)]
	public string? PointId { get; set; }
}
