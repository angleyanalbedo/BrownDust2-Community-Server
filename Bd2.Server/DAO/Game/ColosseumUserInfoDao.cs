using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("ColosseumUserInfo")]
public class ColosseumUserInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Vp")]
	public int Vp { get; set; }

	[SugarColumn(ColumnName = "Rank")]
	public int Rank { get; set; }

	[SugarColumn(ColumnName = "WinCount")]
	public int WinCount { get; set; }

	[SugarColumn(ColumnName = "LoseCount")]
	public int LoseCount { get; set; }

	[SugarColumn(ColumnName = "TopPercent")]
	public double TopPercent { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "RegularSeason")]
	public int RegularSeason { get; set; }

	[SugarColumn(ColumnName = "RankTableChangeSeason")]
	public int RankTableChangeSeason { get; set; }

	[SugarColumn(ColumnName = "IsSeasonReward")]
	public int IsSeasonReward { get; set; }

	[SugarColumn(ColumnName = "ApBuyCount")]
	public int ApBuyCount { get; set; }
}
