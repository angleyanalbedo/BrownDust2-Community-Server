using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FishingInfo")]
public class FishingInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Exp")]
	public int Exp { get; set; }

	[SugarColumn(ColumnName = "Level")]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "BoatLevel")]
	public int BoatLevel { get; set; }

	[SugarColumn(ColumnName = "BoatSkinId")]
	public int BoatSkinId { get; set; }

	[SugarColumn(ColumnName = "UseRodInvenIndex")]
	public long UseRodInvenIndex { get; set; }

	[SugarColumn(ColumnName = "MultiApResetTime")]
	public long MultiApResetTime { get; set; }

	[SugarColumn(ColumnName = "MapId", IsNullable = true)]
	public string? MapId { get; set; }

	[SugarColumn(ColumnName = "BoatSkinIds", IsNullable = true)]
	public string? BoatSkinIds { get; set; }
}
