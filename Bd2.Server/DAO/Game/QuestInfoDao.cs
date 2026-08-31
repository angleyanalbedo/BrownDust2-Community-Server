using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("QuestInfo")]
public class QuestInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "QuestId")]
	public int QuestId { get; set; }

	[SugarColumn(ColumnName = "QuestClear", IsNullable = true)]
	public string? QuestClear { get; set; }

	[SugarColumn(ColumnName = "isPackComplete")]
	public int IsPackComplete { get; set; }
}
