using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("RoomChatBlockInfo")]
public class RoomChatBlockInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "TargetOwnerIndex")]
	public long TargetOwnerIndex { get; set; }

	[SugarColumn(ColumnName = "TargetUserId", IsNullable = true)]
	public string? TargetUserId { get; set; }

	[SugarColumn(ColumnName = "BlockDate")]
	public long BlockDate { get; set; }
}
