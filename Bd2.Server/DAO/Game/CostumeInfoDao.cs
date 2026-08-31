using Bd2.Server.DAO.Config;
using Newtonsoft.Json;
using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CostumeInfo")]
public class CostumeInfoDao
{
	[SugarColumn(ColumnName = "InvenIndex", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long InvenIndex { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "Level", IsNullable = true)]
	public int Level { get; set; }

	[SugarColumn(ColumnName = "UseChar", IsNullable = true)]
	public long? UseChar { get; set; }

	[SugarColumn(ColumnName = "SortId", IsNullable = true)]
	public int? SortId { get; set; }

	[SugarColumn(ColumnName = "UseMyRoomCount", IsNullable = true)]
	public int? UseMyRoomCount { get; set; }

	[SugarColumn(ColumnName = "PotentialId", IsNullable = true)]
	[JsonConverter(typeof(StringArrayConverter))]
	public string? PotentialId { get; set; }
}
