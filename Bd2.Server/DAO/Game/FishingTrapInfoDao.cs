using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FishingTrapInfo")]
public class FishingTrapInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FishId")]
	public int FishId { get; set; }

	[SugarColumn(ColumnName = "Size")]
	public int Size { get; set; }

	[SugarColumn(ColumnName = "TrapRewardReceiptTime")]
	public long TrapRewardReceiptTime { get; set; }

	[SugarColumn(ColumnName = "TotalAddExp")]
	public int TotalAddExp { get; set; }

	[SugarColumn(ColumnName = "AfterLevel")]
	public int AfterLevel { get; set; }

	[SugarColumn(ColumnName = "AfterExp")]
	public int AfterExp { get; set; }
}
