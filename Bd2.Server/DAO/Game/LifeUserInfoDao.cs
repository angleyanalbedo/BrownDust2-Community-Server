using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("LifeUserInfo")]
public class LifeUserInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "LifeCoin")]
	public int LifeCoin { get; set; }

	[SugarColumn(ColumnName = "LifeWorldId")]
	public int LifeWorldId { get; set; }
}
