using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("GuildUserInfo")]
public class GuildUserInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GuildId")]
	public long GuildId { get; set; }

	[SugarColumn(ColumnName = "Role")]
	public int Role { get; set; }

	[SugarColumn(ColumnName = "IsReward")]
	public int IsReward { get; set; }

	[SugarColumn(ColumnName = "RaidBossScore")]
	public long RaidBossScore { get; set; }

	[SugarColumn(ColumnName = "RaidTotalScore")]
	public int RaidTotalScore { get; set; }

	[SugarColumn(ColumnName = "RaidTopPercent")]
	public double RaidTopPercent { get; set; }

	[SugarColumn(ColumnName = "IsPlayRaidToday")]
	public int IsPlayRaidToday { get; set; }

	[SugarColumn(ColumnName = "IsNormalBattlePlay")]
	public int IsNormalBattlePlay { get; set; }

	[SugarColumn(ColumnName = "BattleMode")]
	public int BattleMode { get; set; }
}
