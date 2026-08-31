using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EquipUpgradeResultType
{
	[OriginalName("UPGRADE_SUCCESS")]
	UpgradeSuccess,
	[OriginalName("UPGRADE_FAIL")]
	UpgradeFail,
	[OriginalName("UPGRADE_STOP_MAX_LEVEL")]
	UpgradeStopMaxLevel,
	[OriginalName("UPGRADE_STOP_SUCCESS")]
	UpgradeStopSuccess,
	[OriginalName("UPGRADE_STOP_NOT_ENOUGH")]
	UpgradeStopNotEnough,
	[OriginalName("UPGRADE_STOP_GOLD_LIMIT")]
	UpgradeStopGoldLimit,
	[OriginalName("UPGRADE_STOP_TARGET_LEVEL")]
	UpgradeStopTargetLevel
}
