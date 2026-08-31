using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CharInfo")]
public class CharInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Hp")]
	public long Hp { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "CostumeId")]
	public int CostumeId { get; set; }

	[SugarColumn(ColumnName = "Exp")]
	public int Exp { get; set; }

	[SugarColumn(ColumnName = "UseCostume")]
	public long UseCostume { get; set; }

	[SugarColumn(ColumnName = "TalentLevel")]
	public int TalentLevel { get; set; }

	[SugarColumn(ColumnName = "TalentExp")]
	public int TalentExp { get; set; }

	[SugarColumn(ColumnName = "SolidarityReward")]
	public int SolidarityReward { get; set; }

	[SugarColumn(ColumnName = "ExpiryTime")]
	public long ExpiryTime { get; set; }

	[SugarColumn(ColumnName = "ConnectPotentialCostume")]
	public int ConnectPotentialCostume { get; set; }

	[SugarColumn(ColumnName = "UniqueCharId")]
	public int UniqueCharId { get; set; }
}
