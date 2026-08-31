using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameEvilCastleInfoService : IBatchEndpointService
{
	GameActionResult EvilCastleRogueLikeAllUserScoreInfo(string data, string uid);

	GameActionResult EvilCastleInfo(string data, string uid);

	GameActionResult EvilCastleTowerInfo(string data, string uid);

	GameActionResult EvilCastleEnter(string data, string uid);

	GameActionResult EvilCastleRogueLikeInfo(string data, string uid);

	GameActionResult EvilCastleRewardInfo(string data, string uid);

	GameActionResult EvilCastleDailyRewardState(string data, string uid);
}
