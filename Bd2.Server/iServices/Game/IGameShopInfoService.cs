using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameShopInfoService : IBatchEndpointService
{
	GameActionResult CashShopInfo(string data, string uid);

	GameActionResult CharScoutInfo(string data, string uid);

	GameActionResult CashBonusInfo(string data, string uid);

	GameActionResult AvatarShopWishListInfo(string data, string uid);
}
