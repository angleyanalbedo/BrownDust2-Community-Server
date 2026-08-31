using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FriendInfoList")]
public class FriendInfoListDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FriendUid")]
	public long FriendUid { get; set; }

	[SugarColumn(ColumnName = "FriendType")]
	public int FriendType { get; set; }

	[SugarColumn(ColumnName = "FriendDate")]
	public long FriendDate { get; set; }
}
