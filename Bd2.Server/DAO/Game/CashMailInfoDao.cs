using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CashMailInfo")]
public class CashMailInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "MailId")]
	public int MailId { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "IsOpen")]
	public int IsOpen { get; set; }

	[SugarColumn(ColumnName = "CreateTime")]
	public long CreateTime { get; set; }

	[SugarColumn(ColumnName = "ExpireTime")]
	public long ExpireTime { get; set; }
}
