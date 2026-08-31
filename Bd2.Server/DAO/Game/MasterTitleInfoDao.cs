using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MasterTitleInfo")]
public class MasterTitleInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Seq")]
	public int Seq { get; set; }

	[SugarColumn(ColumnName = "Name")]
	public string Name { get; set; } = "";

	[SugarColumn(ColumnName = "Month")]
	public int Month { get; set; }

	[SugarColumn(ColumnName = "Day")]
	public int Day { get; set; }
}
