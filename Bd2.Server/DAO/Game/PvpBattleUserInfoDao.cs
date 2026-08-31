using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("PvpBattleUserInfo")]
public class PvpBattleUserInfoDao
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

	[SugarColumn(ColumnName = "IsSeasonReward")]
	public int IsSeasonReward { get; set; }

	[SugarColumn(ColumnName = "PvpTableChangeSeason")]
	public int PvpTableChangeSeason { get; set; }
}
