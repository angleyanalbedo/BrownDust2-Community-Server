using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MonsterHuntDeckInfo")]
public class MonsterHuntDeckInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Slot")]
	public int Slot { get; set; }

	[SugarColumn(ColumnName = "CharInvenIndex")]
	public long CharInvenIndex { get; set; }

	[SugarColumn(ColumnName = "CostumeInvenIndex")]
	public long CostumeInvenIndex { get; set; }
}
