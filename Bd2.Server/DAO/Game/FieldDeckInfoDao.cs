using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FieldDeckInfo")]
public class FieldDeckInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Sequence")]
	public int Sequence { get; set; }

	[SugarColumn(ColumnName = "CharInvenIndex")]
	public long CharInvenIndex { get; set; }

	[SugarColumn(ColumnName = "CostumeInvenIndex")]
	public long CostumeInvenIndex { get; set; }
}
