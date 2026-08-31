using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameInventoryInfoService : IBatchEndpointService
{
	GameActionResult RecipeInfo(string data, string uid);

	GameActionResult MyRoomItemInfo(string data, string uid);

	GameActionResult EquipPresetInfo(string data, string uid);

	GameActionResult ItemInfo(string data, string uid);

	GameActionResult IdCardPresetInfo(string data, string uid);

	GameActionResult RootSortIdInfo(string data, string uid);
}
