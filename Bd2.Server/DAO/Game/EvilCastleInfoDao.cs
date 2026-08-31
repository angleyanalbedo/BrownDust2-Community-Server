using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EvilCastleInfo")]
public class EvilCastleInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Rank")]
	public int Rank { get; set; }

	[SugarColumn(ColumnName = "StageIndex")]
	public int StageIndex { get; set; }

	[SugarColumn(ColumnName = "Retry")]
	public int Retry { get; set; }

	[SugarColumn(ColumnName = "Point")]
	public int Point { get; set; }

	[SugarColumn(ColumnName = "SeasonHighestPoint")]
	public int SeasonHighestPoint { get; set; }

	[SugarColumn(ColumnName = "IsRewarded")]
	public int IsRewarded { get; set; }

	[SugarColumn(ColumnName = "StageClearTime")]
	public int StageClearTime { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "RegularSeason")]
	public int RegularSeason { get; set; }

	[SugarColumn(ColumnName = "TotalRank")]
	public int TotalRank { get; set; }

	[SugarColumn(ColumnName = "TotalPoint")]
	public int TotalPoint { get; set; }

	[SugarColumn(ColumnName = "TotalIsRewarded")]
	public int TotalIsRewarded { get; set; }
}
