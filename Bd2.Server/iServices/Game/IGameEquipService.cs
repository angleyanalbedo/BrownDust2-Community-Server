using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameEquipService
{
	Task<GameActionResult> EquipInfo(string uid);

	Task<GameActionResult> EquipSmelting(long index);

	Task<GameActionResult> EquipSequenceSmelting(EquipSequenceSmeltingRequest req, string uid);

	Task<GameActionResult> EquipClear(EquipClearRequest equipClear);

	Task<GameActionResult> EquipUse(EquipUseRequest equipUse);

	Task<GameActionResult> EquipChange(EquipChangeRequest equipChange);

	Task<GameActionResult> EquipBatchUse(EquipBatchUseRequest equipBatchUse);

	Task<GameActionResult> EquipUpgrade(EquipUpgradeRequest equipUpgrade, string uid);

	Task<GameActionResult> EquipSequenceUpgrade(EquipSequenceUpgradeRequest req, string uid);

	Task<GameActionResult> EquipOptionReRoll(EquipOptionReRollRequest req, string uid);

	Task<GameActionResult> EquipOptionReRollConfirm(EquipOptionReRollConfirmRequest req, string uid);

	Task<GameActionResult> EquipBreak(EquipBreakRequest req, string uid);
}
