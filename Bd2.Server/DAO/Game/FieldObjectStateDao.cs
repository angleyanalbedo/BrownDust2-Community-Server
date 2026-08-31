using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("FieldObjectState")]
public class FieldObjectStateDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "PackId")]
	public int PackId { get; set; }

	[SugarColumn(ColumnName = "GroupId")]
	public int GroupId { get; set; }

	[SugarColumn(ColumnName = "ObjectId")]
	public int ObjectId { get; set; }

	[SugarColumn(ColumnName = "MapId")]
	public int MapId { get; set; }

	[SugarColumn(ColumnName = "X")]
	public double X { get; set; }

	[SugarColumn(ColumnName = "Y")]
	public double Y { get; set; }

	[SugarColumn(ColumnName = "Z")]
	public double Z { get; set; }

	[SugarColumn(ColumnName = "IsRewardObtained")]
	public int IsRewardObtained { get; set; }
}
