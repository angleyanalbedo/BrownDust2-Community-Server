using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("PassInfo")]
public class PassInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PassId")]
	public int PassId { get; set; }

	[SugarColumn(ColumnName = "Exp")]
	public int Exp { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "IsPremium")]
	public int IsPremium { get; set; }

	[SugarColumn(ColumnName = "NormalRewardReceived", IsNullable = true)]
	public string? NormalRewardReceived { get; set; }

	[SugarColumn(ColumnName = "PremiumRewardReceived", IsNullable = true)]
	public string? PremiumRewardReceived { get; set; }
}
