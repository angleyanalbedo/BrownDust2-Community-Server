using SqlSugar;
using Newtonsoft.Json;

namespace Bd2.Server.DAO.Game;

[SugarTable("CafeteriaInfo")]
public class CafeteriaInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "RewardReceiptTime")]
	public long RewardReceiptTime { get; set; }

	[SugarColumn(ColumnName = "SpawnTime")]
	public long SpawnTime { get; set; }

	[SugarColumn(ColumnName = "OngoingManageId")]
	public int OngoingManageId { get; set; }

	[SugarColumn(ColumnName = "DailyConnectionCostumeId")]
	public int DailyConnectionCostumeId { get; set; }

	[SugarColumn(ColumnName = "CanGetPhoneNumber")]
	public int CanGetPhoneNumber { get; set; }

	[SugarColumn(ColumnName = "DailyNpcRewardCurrencyCount")]
	public int DailyNpcRewardCurrencyCount { get; set; }

	[SugarColumn(ColumnName = "DailyRegularCostumeId", IsNullable = true)]
	public string DailyRegularCostumeId { get; set; }

	[SugarColumn(ColumnName = "RewardedDailyRegularCostumeId", IsNullable = true)]
	public string RewardedDailyRegularCostumeId { get; set; }
}
