using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("AvatarInfo")]
public class AvatarInfoDao
{
	[SugarColumn(ColumnName = "Uid", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "UseCharId")]
	public int UseCharId { get; set; }

	[SugarColumn(ColumnName = "UseHairId")]
	public int UseHairId { get; set; }

	[SugarColumn(ColumnName = "UseHairAccessoryId")]
	public int UseHairAccessoryId { get; set; }

	[SugarColumn(ColumnName = "UseFaceAccessoryId")]
	public int UseFaceAccessoryId { get; set; }

	[SugarColumn(ColumnName = "UseCostumeId")]
	public int UseCostumeId { get; set; }

	[SugarColumn(ColumnName = "UseBodyAccessoryId")]
	public int UseBodyAccessoryId { get; set; }

	[SugarColumn(ColumnName = "UseHandAccessoryId")]
	public int UseHandAccessoryId { get; set; }

	[SugarColumn(ColumnName = "UsePetId")]
	public int UsePetId { get; set; }

	[SugarColumn(ColumnName = "UseMountId")]
	public int UseMountId { get; set; }

	[SugarColumn(ColumnName = "UseEffectId")]
	public int UseEffectId { get; set; }

	[SugarColumn(ColumnName = "Date")]
	public long Date { get; set; }
}
