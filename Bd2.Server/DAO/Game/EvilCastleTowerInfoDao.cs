using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EvilCastleTowerInfo")]
public class EvilCastleTowerInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "TowerId")]
	public int TowerId { get; set; }

	[SugarColumn(ColumnName = "BattleChallengeIndex", IsNullable = true)]
	public string? BattleChallengeIndex { get; set; }

	[SugarColumn(ColumnName = "BattleMode")]
	public int BattleMode { get; set; }
}
