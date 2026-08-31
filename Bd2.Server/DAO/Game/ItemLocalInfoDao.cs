using SqlSugar;

namespace Bd2.Server.DAO.Game;

/// <summary>
/// 物品/角色名称本地化表（从 Google Sheets NameTextTable 导入）
/// </summary>
[SugarTable("ItemLocalInfo")]
public class ItemLocalInfoDao
{
	[SugarColumn(ColumnName = "Id", IsPrimaryKey = true, ColumnDataType = "INTEGER")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "TextKr", IsNullable = true)]
	public string? TextKr { get; set; }

	[SugarColumn(ColumnName = "TextEn", IsNullable = true)]
	public string? TextEn { get; set; }

	[SugarColumn(ColumnName = "TextJp", IsNullable = true)]
	public string? TextJp { get; set; }

	[SugarColumn(ColumnName = "TextTw", IsNullable = true)]
	public string? TextTw { get; set; }

	[SugarColumn(ColumnName = "TextCn", IsNullable = true)]
	public string? TextCn { get; set; }
}
