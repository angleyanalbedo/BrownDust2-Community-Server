using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("DatingInfo")]
public class DatingInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "DatingPoint")]
	public int DatingPoint { get; set; }

	[SugarColumn(ColumnName = "LastClearId")]
	public int LastClearId { get; set; }

	[SugarColumn(ColumnName = "LastMessageGroupId")]
	public int LastMessageGroupId { get; set; }

	[SugarColumn(ColumnName = "LastMessageId")]
	public int LastMessageId { get; set; }

	[SugarColumn(ColumnName = "LastMessageUpdateTime")]
	public long LastMessageUpdateTime { get; set; }
}
