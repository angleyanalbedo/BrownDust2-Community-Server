using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("PresetInfo")]
public class PresetInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Slot")]
	public int Slot { get; set; }

	[SugarColumn(ColumnName = "PresetName")]
	public string PresetName { get; set; }

	[SugarColumn(ColumnName = "PresetResourceId")]
	public int PresetResourceId { get; set; }

	[SugarColumn(ColumnName = "PresetResourceColor")]
	public int PresetResourceColor { get; set; }

	[SugarColumn(ColumnName = "DeckInfo")]
	public string DeckInfo { get; set; }
}
