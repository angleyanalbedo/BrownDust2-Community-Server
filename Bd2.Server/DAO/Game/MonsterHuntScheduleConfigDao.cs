using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MonsterHuntScheduleConfig")]
public class MonsterHuntScheduleConfigDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "SeasonStartTime")]
	public long SeasonStartTime { get; set; }

	[SugarColumn(ColumnName = "SeasonEndTime")]
	public long SeasonEndTime { get; set; }

	[SugarColumn(ColumnName = "MonsterHuntId")]
	public int MonsterHuntId { get; set; }

	[SugarColumn(ColumnName = "InfoOpenDay")]
	public int InfoOpenDay { get; set; }

	[SugarColumn(ColumnName = "CalculateEndDate")]
	public long CalculateEndDate { get; set; }

	[SugarColumn(ColumnName = "StartRegularSeason")]
	public int StartRegularSeason { get; set; }
}

[SugarTable("MonsterHuntScheduleHistory")]
public class MonsterHuntScheduleHistoryDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "MonsterHuntId")]
	public int MonsterHuntId { get; set; }
}
