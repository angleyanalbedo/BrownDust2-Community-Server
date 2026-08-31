using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharVoteInfo")]
public class CharVoteInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "CurrentRound")]
	public int CurrentRound { get; set; }

	[SugarColumn(ColumnName = "NextDailyResetTime")]
	public long NextDailyResetTime { get; set; }

	[SugarColumn(ColumnName = "IsDailyReset")]
	public int IsDailyReset { get; set; }
}
