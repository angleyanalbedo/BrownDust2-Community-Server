using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("IdCardPresetInfo")]
public class IdCardPresetInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PresetId")]
	public int PresetId { get; set; }
}
