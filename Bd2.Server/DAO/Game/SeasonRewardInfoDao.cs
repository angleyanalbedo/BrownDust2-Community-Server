using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("SeasonRewardInfo")]
public class SeasonRewardInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "IsRewardReceived")]
	public int IsRewardReceived { get; set; }
}
