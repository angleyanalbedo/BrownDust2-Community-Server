using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameWorldInfoService : IBatchEndpointService
{
	GameActionResult PackInfo(string data, string uid);

	GameActionResult FieldTrapInfo(string data, string uid);

	GameActionResult WaypointInfo(string data, string uid);

	GameActionResult SkyWayScheduleInfo(string data, string uid);

	GameActionResult FieldObjectInfo(string data, string uid);

	GameActionResult SkyWayInfo(string data, string uid);

	GameActionResult PackInGameInfo(string data, string uid);

	GameActionResult SaveFieldCharControlDeckType(string data, string uid);

	GameActionResult FieldDeckInfo(string data, string uid);

	GameActionResult FieldEventSpawnInfo(string data, string uid);
}
