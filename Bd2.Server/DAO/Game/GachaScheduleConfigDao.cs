using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("GachaScheduleConfig")]
public sealed class GachaScheduleConfigDao
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
    public long Id { get; set; }
    public int GachaGroupRowId { get; set; }
    public int Enabled { get; set; }
    public long StartTime { get; set; }
    public long EndTime { get; set; }
    public long UpdatedAt { get; set; }
}
