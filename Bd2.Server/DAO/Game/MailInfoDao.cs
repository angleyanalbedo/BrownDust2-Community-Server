using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MailInfo")]
public class MailInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "MailId")]
	public int MailId { get; set; }

	[SugarColumn(ColumnName = "SenderText", IsNullable = true)]
	public string? SenderText { get; set; }

	[SugarColumn(ColumnName = "TitleText", IsNullable = true)]
	public string? TitleText { get; set; }

	[SugarColumn(ColumnName = "MessageText", IsNullable = true)]
	public string? MessageText { get; set; }

	[SugarColumn(ColumnName = "RewardExpireTime")]
	public long RewardExpireTime { get; set; }

	[SugarColumn(ColumnName = "ItemType")]
	public int ItemType { get; set; }

	[SugarColumn(ColumnName = "ItemId")]
	public int ItemId { get; set; }

	[SugarColumn(ColumnName = "ItemCount")]
	public int ItemCount { get; set; }

	[SugarColumn(ColumnName = "IsOpen")]
	public int IsOpen { get; set; }

	[SugarColumn(ColumnName = "OpenTime")]
	public long OpenTime { get; set; }

	[SugarColumn(ColumnName = "CreateTime")]
	public long CreateTime { get; set; }

	[SugarColumn(ColumnName = "HistoryDeleteTime")]
	public long HistoryDeleteTime { get; set; }

	[SugarColumn(ColumnName = "IsCash")]
	public int IsCash { get; set; }
}
