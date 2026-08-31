using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("TotalWarDeckInfo")]
public class TotalWarDeckInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "DeckInfo")]
	public string DeckInfo { get; set; }
}
