using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("PersonalInfo")]
public class PersonalInfoDao
{
	[SugarColumn(ColumnName = "Uid", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "TitleId")]
	public int TitleId { get; set; }

	[SugarColumn(ColumnName = "Introduce", IsNullable = true)]
	public string? Introduce { get; set; }

	[SugarColumn(ColumnName = "BgImageId")]
	public int BgImageId { get; set; }

	[SugarColumn(ColumnName = "ProfileCharId")]
	public int ProfileCharId { get; set; }

	[SugarColumn(ColumnName = "ProfileCostumeId")]
	public int ProfileCostumeId { get; set; }
}
