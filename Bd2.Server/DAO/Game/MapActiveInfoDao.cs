using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MapActiveInfo")]
public class MapActiveInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "MapId")]
	public int MapId { get; set; }

	[SugarColumn(ColumnName = "Active")]
	public string Active { get; set; }
}
