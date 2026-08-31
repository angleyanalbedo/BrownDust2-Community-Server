using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameLeisureInfoService : IBatchEndpointService
{
	GameActionResult CafeteriaInfo(string data, string uid);

	GameActionResult CafeteriaLevelUp(string data, string uid);

	GameActionResult CafeteriaManageItemAdd(string data, string uid);
	GameActionResult CafeteriaIntroductionStoryReward(string data, string uid);
	GameActionResult CafeteriaCumulativeReward(string data, string uid);
	GameActionResult CafeteriaSpawnReset(string data, string uid);
	GameActionResult CafeteriaSpawnResetCheat(string data, string uid);
	GameActionResult CafeteriaDailyConnectionCostumeRefresh(string data, string uid);
	GameActionResult CafeteriaRegularCostumeNoteInfo(string data, string uid);
	GameActionResult CafeteriaRegularCostumeNoteReward(string data, string uid);
	GameActionResult CafeteriaRegularCostumeNoteAllReward(string data, string uid);
	GameActionResult CafeteriaRegularCostumeInteractionReward(string data, string uid);
	GameActionResult CafeteriaRegularCostumeInteractionAllReward(string data, string uid);
	GameActionResult CafeteriaRewardReceiptTimeUpdateUsingCheat(string data, string uid);
	GameActionResult CafeteriaEventNpcInteractionReward(string data, string uid);
	GameActionResult CafeteriaRareNpcInteractionReward(string data, string uid);

	GameActionResult MiniGameHubInfo(string data, string uid);

	GameActionResult DatingInfo(string data, string uid);

	GameActionResult LifeInfo(string data, string uid);

	GameActionResult CharVoteInfo(string data, string uid);

	GameActionResult MiniGameDefenseInfo(string data, string uid);

	GameActionResult FireWorksInfo(string data, string uid);

	GameActionResult LifeUserInfo(string data, string uid);
}
