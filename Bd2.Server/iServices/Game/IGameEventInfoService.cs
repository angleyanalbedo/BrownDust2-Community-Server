using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameEventInfoService : IBatchEndpointService
{
	GameActionResult CommunityRewardInfo(string data, string uid);

	GameActionResult EventHubInfo(string data, string uid);

	GameActionResult EventExchangeInfo(string data, string uid);

	GameActionResult EventScheduleInfo(string data, string uid);

	GameActionResult ScheduleInfo(string data, string uid);

	GameActionResult EventMissionInfo(string data, string uid);

	GameActionResult MiniEventHubInfo(string data, string uid);

	GameActionResult DailyStoryInfo(string data, string uid);
}
