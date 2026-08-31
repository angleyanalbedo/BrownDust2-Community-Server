using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameFishingInfoService : IBatchEndpointService
{
	GameActionResult FishingItemInfo(string data, string uid);

	GameActionResult FishingInfo(string data, string uid);

	GameActionResult FishingCollectionInfo(string data, string uid);

	GameActionResult FishingTrapInfo(string data, string uid);
}
