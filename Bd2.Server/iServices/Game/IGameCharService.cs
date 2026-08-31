using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameCharService
{
	Task<GameActionResult> CharLevelUp(CharLevelUpRequest charLevelUp, string uid);

	Task<GameActionResult> CharClassUp(CharClassUpRequest charClassUp, string uid);

	Task<GameActionResult> CostumeUse(CostumeUseRequest use, string uid);

	Task<GameActionResult> CostumeNodeActivation(CostumeNodeActivationRequest open, string uid);

	Task<GameActionResult> CostumePotentialConnect(CostumePotentialConnectRequest req, string uid);

	Task<GameActionResult> CharImprintLevelUp(CharImprintLevelUpRequest req, string uid);

	Task<GameActionResult> CharAwakeActive(CharAwakeActiveRequest req, string uid);
}
