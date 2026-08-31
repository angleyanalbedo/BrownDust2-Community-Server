using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MyLikeInfo")]
public class MyLikeInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "TargetUid")]
	public long TargetUid { get; set; }

	[SugarColumn(ColumnName = "LikeDate")]
	public long LikeDate { get; set; }
}
