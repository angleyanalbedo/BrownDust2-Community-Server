using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("RecipeInfo")]
public class RecipeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "RecipeId")]
	public int RecipeId { get; set; }
}
