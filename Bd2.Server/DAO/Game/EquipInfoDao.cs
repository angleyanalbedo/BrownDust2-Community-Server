using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("EquipInfo")]
public class EquipInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "UseChar", IsNullable = true)]
	public long UseChar { get; set; }

	[SugarColumn(ColumnName = "KeepFlag", IsNullable = true)]
	public int KeepFlag { get; set; }

	[SugarColumn(ColumnName = "LockFlag", IsNullable = true)]
	public int LockFlag { get; set; }

	[SugarColumn(ColumnName = "SortId", IsNullable = true)]
	public int SortId { get; set; }

	[SugarColumn(ColumnName = "SlotType")]
	public int SlotType { get; set; }

	[SugarColumn(ColumnName = "ID")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Level", IsNullable = true)]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "MainOption", IsNullable = true)]
	public string? MainOption { get; set; }

	[SugarColumn(ColumnName = "SubOption", IsNullable = true)]
	public string? SubOption { get; set; }

	[SugarColumn(ColumnName = "PrivateOption", IsNullable = true)]
	public string? PrivateOption { get; set; }

	[SugarColumn(ColumnName = "Rank", IsNullable = true)]
	public string Rank { get; set; }
}
