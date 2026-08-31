using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("TotalWarRank")]
public class TotalWarRankDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "ScoreData")]
	public string ScoreData { get; set; }

	[SugarColumn(ColumnName = "Score")]
	public long Score { get; set; }
}
