using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("NoticeInfo")]
public class NoticeInfoDao
{
	[SugarColumn(ColumnName = "Id")]
	public int Id { get; set; }

	[SugarColumn(ColumnName = "NoticeType", IsNullable = true)]
	public int? NoticeType { get; set; }

	[SugarColumn(ColumnName = "Title", IsNullable = true)]
	public string? Title { get; set; }

	[SugarColumn(ColumnName = "Thumbnail", IsNullable = true)]
	public string? Thumbnail { get; set; }

	[SugarColumn(ColumnName = "StartTime", IsNullable = true)]
	public long? StartTime { get; set; }

	[SugarColumn(ColumnName = "EndTime", IsNullable = true)]
	public long? EndTime { get; set; }

	[SugarColumn(ColumnName = "NoticeContent", IsNullable = true)]
	public string? NoticeContent { get; set; }

	[SugarColumn(ColumnName = "PromotionBannerId", IsNullable = true)]
	public int? PromotionBannerId { get; set; }

	[SugarColumn(ColumnName = "IsPin", IsNullable = true)]
	public bool? IsPin { get; set; }

	[SugarColumn(ColumnName = "Sort", IsNullable = true)]
	public int? Sort { get; set; }

	[SugarColumn(ColumnName = "SubType", IsNullable = true)]
	public int? SubType { get; set; }
}
