using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("SkyWayInfo")]
public class SkyWayInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "IsAuto")]
	public int IsAuto { get; set; }

	[SugarColumn(ColumnName = "CurrentId")]
	public int CurrentId { get; set; }

	[SugarColumn(ColumnName = "MaxClearLevel")]
	public int MaxClearLevel { get; set; }
}
