using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharScoutInfo")]
public class CharScoutInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "AppearCharIds", IsNullable = true)]
	public string? AppearCharIds { get; set; }

	[SugarColumn(ColumnName = "UseResetCount")]
	public int UseResetCount { get; set; }

	[SugarColumn(ColumnName = "NextAutoResetTime")]
	public long NextAutoResetTime { get; set; }

	[SugarColumn(ColumnName = "ScoutCompleteCharIds", IsNullable = true)]
	public string? ScoutCompleteCharIds { get; set; }
}
