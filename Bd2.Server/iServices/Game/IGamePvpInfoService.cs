using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGamePvpInfoService : IBatchEndpointService
{
	GameActionResult PvpBattleUserInfo(string data, string uid);

	GameActionResult ColosseumUserInfo(string data, string uid);
}
