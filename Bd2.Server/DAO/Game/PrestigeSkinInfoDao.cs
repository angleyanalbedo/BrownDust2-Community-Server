using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("PrestigeSkinInfo")]
public class PrestigeSkinInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "CostumeId")]
	public int CostumeId { get; set; }

	[SugarColumn(ColumnName = "CostumeDesignId")]
	public int CostumeDesignId { get; set; }

	[SugarColumn(ColumnName = "IsSet")]
	public int IsSet { get; set; }
}
