using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("MyRoomItemInfo")]
public class MyRoomItemInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Type")]
	public int Type { get; set; }

	[SugarColumn(ColumnName = "PlaceType")]
	public int PlaceType { get; set; }

	[SugarColumn(ColumnName = "PositionX")]
	public float PositionX { get; set; }

	[SugarColumn(ColumnName = "PositionY")]
	public float PositionY { get; set; }

	[SugarColumn(ColumnName = "PositionZ")]
	public float PositionZ { get; set; }

	[SugarColumn(ColumnName = "Rotation")]
	public float Rotation { get; set; }
}
