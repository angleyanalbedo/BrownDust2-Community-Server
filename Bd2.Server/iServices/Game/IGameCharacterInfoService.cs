using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameCharacterInfoService : IBatchEndpointService
{
	GameActionResult CharInfo(string data, string uid);

	GameActionResult CostumeInfo(string data, string uid);

	GameActionResult CharAwakeInfo(string data, string uid);

	GameActionResult AvatarInfo(string data, string uid);

	GameActionResult PrestigeSkinInfo(string data, string uid);

	GameActionResult SpineInteractionAchievementInfo(string data, string uid);
}
