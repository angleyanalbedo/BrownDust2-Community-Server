using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("ItemInfo")]
public class ItemInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "Count")]
	public int Count { get; set; }

	[SugarColumn(ColumnName = "KeepFlag")]
	public int KeepFlag { get; set; }

	[SugarColumn(ColumnName = "TimeValue")]
	public long TimeValue { get; set; }

	[SugarColumn(ColumnName = "ExpiryTime")]
	public long ExpiryTime { get; set; }

	[SugarColumn(ColumnName = "SortId")]
	public int SortId { get; set; }

	[SugarColumn(ColumnName = "UseCount")]
	public int UseCount { get; set; }
}
