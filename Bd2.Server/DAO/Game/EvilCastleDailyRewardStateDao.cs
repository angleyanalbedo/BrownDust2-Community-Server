using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EvilCastleDailyRewardState")]
public class EvilCastleDailyRewardStateDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "IsObtainableDailyReward")]
	public int IsObtainableDailyReward { get; set; }

	[SugarColumn(ColumnName = "LastRewardDate")]
	public long LastRewardDate { get; set; }
}
