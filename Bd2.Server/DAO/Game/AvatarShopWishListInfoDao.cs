using SqlSugar;

namespace Bd2.Server.DAO.Game;

[SugarTable("AvatarShopWishListInfo")]
public class AvatarShopWishListInfoDao
{
	[SugarColumn(ColumnName = "Index", IsPrimaryKey = true, IsIdentity = true, ColumnDataType = "INTEGER")]
	public long Index { get; set; }

	[SugarColumn(ColumnName = "Uid")]
	public long Uid { get; set; }

	[SugarColumn(ColumnName = "ShopId")]
	public int ShopId { get; set; }
}
