using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FieldTrapInfo")]
public class FieldTrapInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "MapId")]
	public int MapId { get; set; }

	[SugarColumn(ColumnName = "TrapId")]
	public int TrapId { get; set; }

	[SugarColumn(ColumnName = "State")]
	public int State { get; set; }
}
