using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FriendshipSpecialEpisodeInfo")]
public class FriendshipSpecialEpisodeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "EpisodeId")]
	public int EpisodeId { get; set; }
}
