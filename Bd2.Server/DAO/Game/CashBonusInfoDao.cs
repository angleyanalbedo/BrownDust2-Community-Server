using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CashBonusInfo")]
public class CashBonusInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "ContentsGroupId")]
	public int ContentsGroupId { get; set; }

	[SugarColumn(ColumnName = "BuyCount")]
	public int BuyCount { get; set; }

	[SugarColumn(ColumnName = "RewardedId", IsNullable = true)]
	public string? RewardedId { get; set; }
}
