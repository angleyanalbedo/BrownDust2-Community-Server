using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharAwakeInfo")]
public class CharAwakeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "OwnerIndex")]
	public long OwnerIndex { get; set; }

	[SugarColumn(ColumnName = "UniqueCharId")]
	public int UniqueCharId { get; set; }

	[SugarColumn(ColumnName = "ImprintSlot1Level")]
	public int ImprintSlot1Level { get; set; }

	[SugarColumn(ColumnName = "ImprintSlot2Level")]
	public int ImprintSlot2Level { get; set; }

	[SugarColumn(ColumnName = "ImprintSlot3Level")]
	public int ImprintSlot3Level { get; set; }

	[SugarColumn(ColumnName = "IsAwake")]
	public int IsAwake { get; set; }
}
