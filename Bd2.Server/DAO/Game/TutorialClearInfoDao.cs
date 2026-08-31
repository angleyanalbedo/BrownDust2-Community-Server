using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("TutorialClearInfo")]
public class TutorialClearInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "TutorialClearId")]
	public int TutorialClearId { get; set; }
}
