using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameDeckInfoService : IBatchEndpointService
{
	GameActionResult DeckInfo(string data, string uid);

	GameActionResult DeckCostumeSettingInfo(string data, string uid);
}
