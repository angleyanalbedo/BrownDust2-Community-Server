using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PackType
{
	[OriginalName("PACK_STORY")]
	PackStory = 0,
	[OriginalName("PACK_CHAR")]
	PackChar = 1,
	[OriginalName("PACK_TUTORIAL")]
	PackTutorial = 2,
	[OriginalName("PACK_PVP")]
	PackPvp = 3,
	[OriginalName("PACK_EvilCastle")]
	PackEvilCastle = 4,
	[OriginalName("PACK_SKY_WAY")]
	PackSkyWay = 5,
	[OriginalName("PACK_EVENT")]
	PackEvent = 6,
	[OriginalName("PACK_TOTAL_WAR")]
	PackTotalWar = 7,
	[OriginalName("PACK_GUILD_RAID")]
	PackGuildRaid = 8,
	[OriginalName("PACK_HIDDEN")]
	PackHidden = 100
}
