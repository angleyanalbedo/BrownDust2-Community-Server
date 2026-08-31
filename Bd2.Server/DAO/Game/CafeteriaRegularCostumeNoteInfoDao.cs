using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CafeteriaRegularCostumeNoteInfo")]
public class CafeteriaRegularCostumeNoteInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "CostumeId")]
	public int CostumeId { get; set; }

	[SugarColumn(ColumnName = "ServeCount")]
	public int ServeCount { get; set; }

	[SugarColumn(ColumnName = "IsReceivedReward")]
	public int IsReceivedReward { get; set; }
}
