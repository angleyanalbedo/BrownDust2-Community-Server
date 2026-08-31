using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_RankContentType
{
	[OriginalName("RANK_NONE")]
	RankNone,
	[OriginalName("RANK_PVP")]
	RankPvp,
	[OriginalName("RANK_EVIL_CASTLE")]
	RankEvilCastle,
	[OriginalName("RANK_MONSTER_HUNT")]
	RankMonsterHunt,
	[OriginalName("RANK_TOTAL_WAR")]
	RankTotalWar,
	[OriginalName("RANK_EVIL_CASTLE_ROGUE_LIKE")]
	RankEvilCastleRogueLike,
	[OriginalName("RANK_GUILD_RAID")]
	RankGuildRaid
}
