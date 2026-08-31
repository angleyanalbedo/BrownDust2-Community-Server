using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("DeckInfo")]
public class DeckInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Sequence")]
	public int Sequence { get; set; }

	[SugarColumn(ColumnName = "CharInvenIndex")]
	public long CharInvenIndex { get; set; }

	[SugarColumn(ColumnName = "Position")]
	public int Position { get; set; }
}
