using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharLevelData")]
public class CharLevelData
{
	[SugarColumn(ColumnName = "GroupId", IsNullable = true)]
	public int? GroupId { get; set; }

	[SugarColumn(ColumnName = "Level", IsNullable = true)]
	public int? Level { get; set; }

	[SugarColumn(ColumnName = "LevelupExp", IsNullable = true)]
	public int? LevelupExp { get; set; }

	[SugarColumn(ColumnName = "Health", IsNullable = true)]
	public float? Health { get; set; }
}
