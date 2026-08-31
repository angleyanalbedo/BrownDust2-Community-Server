using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharPartnerInfo")]
public class CharPartnerInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "MainUniqueId")]
	public int MainUniqueId { get; set; }

	[SugarColumn(ColumnName = "SubUniqueId")]
	public int SubUniqueId { get; set; }

	[SugarColumn(ColumnName = "Point")]
	public int Point { get; set; }

	[SugarColumn(ColumnName = "Reward")]
	public int Reward { get; set; }
}
