using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameProgressInfoService : IBatchEndpointService
{
	GameActionResult QuestMaxClearInfo(string data, string uid);

	GameActionResult AchievementInfo(string data, string uid);

	GameActionResult SeasonRewardInfo(string data, string uid);

	GameActionResult PassInfo(string data, string uid);

	GameActionResult MissionInfo(string data, string uid);

	GameActionResult NoticeInfo(string data, string uid);

	GameActionResult MailInfo(string data, string uid);

	GameActionResult CashMailInfo(string data, string uid);
}
