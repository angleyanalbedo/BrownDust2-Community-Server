using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CommunityRewardInfo")]
public class CommunityRewardInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "SubType")]
	public int SubType { get; set; }
}
