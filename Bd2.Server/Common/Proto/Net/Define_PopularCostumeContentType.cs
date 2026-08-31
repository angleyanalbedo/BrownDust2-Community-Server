using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PopularCostumeContentType
{
	[OriginalName("PCC_PVP")]
	PccPvp,
	[OriginalName("PCC_EVIL_CASTLE")]
	PccEvilCastle,
	[OriginalName("PCC_EVIL_CASTLE_GREED_TOWER")]
	PccEvilCastleGreedTower,
	[OriginalName("PCC_TOTAL_WAR")]
	PccTotalWar,
	[OriginalName("PCC_EVIL_CASTLE_RAGE_TOWER")]
	PccEvilCastleRageTower,
	[OriginalName("PCC_EVIL_CASTLE_ENVY_TOWER")]
	PccEvilCastleEnvyTower
}
