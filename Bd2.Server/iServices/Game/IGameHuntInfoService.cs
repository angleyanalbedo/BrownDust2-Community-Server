using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameHuntInfoService : IBatchEndpointService
{
	GameActionResult DispatchInfo(string data, string uid);

	GameActionResult MonsterHuntDeckInfo(string data, string uid);

	GameActionResult HuntDispatchInfo(string data, string uid);

	GameActionResult MonsterHuntScheduleInfo(string data, string uid);

	GameActionResult MonsterHuntUserInfo(string data, string uid);
}
