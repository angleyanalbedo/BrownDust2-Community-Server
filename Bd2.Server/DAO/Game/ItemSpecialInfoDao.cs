using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("ItemSpecialInfo")]
public class ItemSpecialInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "Count")]
	public int Count { get; set; }

	[SugarColumn(ColumnName = "ExpiryTime")]
	public long ExpiryTime { get; set; }
}
