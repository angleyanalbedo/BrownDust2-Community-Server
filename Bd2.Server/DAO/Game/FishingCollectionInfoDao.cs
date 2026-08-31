using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FishingCollectionInfo")]
public class FishingCollectionInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FishId")]
	public int FishId { get; set; }

	[SugarColumn(ColumnName = "MaxSize")]
	public int MaxSize { get; set; }

	[SugarColumn(ColumnName = "MinSize")]
	public int MinSize { get; set; }

	[SugarColumn(ColumnName = "CreateTime")]
	public long CreateTime { get; set; }
}
