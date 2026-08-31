using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameTalentServer
{
	Task<GameActionResult> TalentSkillUse(TalentSkillUseRequest req, string uid);

	Task<GameActionResult> TalentSkillUpgrade(TalentSkillUpgradeRequest req, string uid);

	Task<GameActionResult> EquipMaking(EquipMakingRequest req, string uid);

	Task<GameActionResult> Alchemy(AlchemyRequest req, string uid);

	Task<GameActionResult> AlchemyBatch(AlchemyBatchRequest req, string uid);
}
