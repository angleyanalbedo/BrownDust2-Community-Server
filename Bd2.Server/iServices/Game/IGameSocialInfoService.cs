using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameSocialInfoService : IBatchEndpointService
{
	GameActionResult CharPartnerInfo(string data, string uid);

	GameActionResult MyLikeInfo(string data, string uid);

	GameActionResult GuildInitInfo(string data, string uid);

	GameActionResult FriendInfoList(string data, string uid);

	GameActionResult FriendshipInfo(string data, string uid);

	GameActionResult GuildRaidSeasonReward(string data, string uid);

	GameActionResult RoomChatReportAndBlockInfo(string data, string uid);

	GameActionResult FriendshipSpecialEpisodeInfo(string data, string uid);

	GameActionResult FriendshipGift(string data, string uid);

	GameActionResult FriendshipCounseling(string data, string uid);

	GameActionResult FriendshipSpecialEpisodeClear(string data, string uid);
}
