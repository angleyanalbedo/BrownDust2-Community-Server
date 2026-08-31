using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FriendshipInfo")]
public class FriendshipInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FriendshipCostumeId")]
	public int FriendshipCostumeId { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "Exp")]
	public int Exp { get; set; }

	[SugarColumn(ColumnName = "LastCounselingDate")]
	public long LastCounselingDate { get; set; }
}
