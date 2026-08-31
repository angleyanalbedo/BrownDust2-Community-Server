using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("CafeteriaFacilityInfo")]
public class CafeteriaFacilityInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "FacilityId")]
	public int FacilityId { get; set; }
}
