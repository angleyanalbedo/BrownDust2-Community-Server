using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FireWorksInfo")]
public class FireWorksInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "RewardedGroupId")]
	public int RewardedGroupId { get; set; }
}
