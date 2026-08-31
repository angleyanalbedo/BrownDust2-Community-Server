using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameQuestService
{
	Task<GameActionResult> QuestUpdate(QuestUpdateRequest req, string uid);

	Task<GameActionResult> QuestClear(QuestClearRequest req, string uid);

	Task FastCompletePack(long uid, int packId);
}
