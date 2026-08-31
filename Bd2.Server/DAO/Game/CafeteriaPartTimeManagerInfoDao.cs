using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CafeteriaPartTimeManagerInfo")]
public class CafeteriaPartTimeManagerInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PartTimeManagerId")]
	public int PartTimeManagerId { get; set; }
}
