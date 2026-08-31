using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("ScheduleInfo")]
public class ScheduleInfoDao
{
	[SugarColumn(ColumnName = "Id", IsPrimaryKey = true)]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "CurrentSeason")]
	public int CurrentSeason { get; set; }

	[SugarColumn(ColumnName = "CurrentStartTime")]
	public long CurrentStartTime { get; set; }

	[SugarColumn(ColumnName = "CurrentEndTime")]
	public long CurrentEndTime { get; set; }

	[SugarColumn(ColumnName = "NextSeason")]
	public int NextSeason { get; set; }

	[SugarColumn(ColumnName = "NextStartTime")]
	public long NextStartTime { get; set; }

	[SugarColumn(ColumnName = "NextEndTime")]
	public long NextEndTime { get; set; }
}
