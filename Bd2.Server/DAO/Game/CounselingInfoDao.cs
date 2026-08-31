using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CounselingInfo")]
public class CounselingInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FriendshipCostumeId")]
	public int FriendshipCostumeId { get; set; }

	[SugarColumn(ColumnName = "CounselingSessionId", IsNullable = true)]
	public string? CounselingSessionId { get; set; }
}
