using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameTotalWarService
{
	Task<GameActionResult> TotalWarInfo(string uid);

	Task<GameActionResult> TotalWarDeckPresetInfo(string uid);

	Task<GameActionResult> TotalWarDeckPresetSave(TotalWarDeckPresetSaveRequest req, string uid);

	Task<GameActionResult> TotalWarDeckInfo(string uid);

	Task<GameActionResult> TotalWarDeckSave(TotalWarDeckSaveRequest req, string uid);

	Task<GameActionResult> TotalWarBattleStart(TotalWarBattleStartRequest req, string uid);

	Task<GameActionResult> TotalWarBattleEnd(TotalWarBattleEndRequest req, string uid);
}
