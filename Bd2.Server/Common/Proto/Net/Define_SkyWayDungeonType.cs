using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_SkyWayDungeonType
{
	[OriginalName("SWD_NONE")]
	SwdNone,
	[OriginalName("SWD_GOBLIN")]
	SwdGoblin,
	[OriginalName("SWD_SLIME")]
	SwdSlime,
	[OriginalName("SWD_CRYSTAL_FIRE")]
	SwdCrystalFire,
	[OriginalName("SWD_CRYSTAL_WATER")]
	SwdCrystalWater,
	[OriginalName("SWD_CRYSTAL_WIND")]
	SwdCrystalWind,
	[OriginalName("SWD_CRYSTAL_LIGHT")]
	SwdCrystalLight,
	[OriginalName("SWD_CRYSTAL_DARK")]
	SwdCrystalDark,
	[OriginalName("SWD_MAX")]
	SwdMax
}
