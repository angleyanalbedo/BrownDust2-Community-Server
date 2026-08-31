using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MonsterHuntUserInfo")]
public class MonsterHuntUserInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Season")]
	public int Season { get; set; }

	[SugarColumn(ColumnName = "Rank")]
	public int Rank { get; set; }

	[SugarColumn(ColumnName = "Score")]
	public long Score { get; set; }

	[SugarColumn(ColumnName = "Ticket")]
	public int Ticket { get; set; }

	[SugarColumn(ColumnName = "MaxScore")]
	public long MaxScore { get; set; }
}
