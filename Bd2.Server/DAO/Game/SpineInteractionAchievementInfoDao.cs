using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("SpineInteractionAchievementInfo")]
public class SpineInteractionAchievementInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "InteractionGroupId")]
	public int InteractionGroupId { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }
}
