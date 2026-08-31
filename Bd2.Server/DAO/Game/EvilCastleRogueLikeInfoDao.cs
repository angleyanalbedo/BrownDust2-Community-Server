using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EvilCastleRogueLikeInfo")]
public class EvilCastleRogueLikeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Floor")]
	public int Floor { get; set; }

	[SugarColumn(ColumnName = "Room")]
	public int Room { get; set; }

	[SugarColumn(ColumnName = "State")]
	public int State { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "ReRoll")]
	public int ReRoll { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "RogueLikeId")]
	public int RogueLikeId { get; set; }

	[SugarColumn(ColumnName = "BattleLevel")]
	public int BattleLevel { get; set; }

	[SugarColumn(ColumnName = "MaxTryLevel")]
	public int MaxTryLevel { get; set; }

	[SugarColumn(ColumnName = "Obsidian")]
	public int Obsidian { get; set; }

	[SugarColumn(ColumnName = "RogueLikeGold")]
	public int RogueLikeGold { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "RegularSeason")]
	public int RegularSeason { get; set; }

	[SugarColumn(ColumnName = "IsSeasonReward")]
	public int IsSeasonReward { get; set; }

	[SugarColumn(ColumnName = "MaxRewardLevel")]
	public int MaxRewardLevel { get; set; }
}
