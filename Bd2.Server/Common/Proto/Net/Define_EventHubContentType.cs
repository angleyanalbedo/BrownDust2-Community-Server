using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EventHubContentType
{
	[OriginalName("EHC_NONE")]
	EhcNone,
	[OriginalName("EHC_STORY")]
	EhcStory,
	[OriginalName("EHC_BATTLE")]
	EhcBattle,
	[OriginalName("EHC_MONSTER_HUNT")]
	EhcMonsterHunt,
	[OriginalName("EHC_EXCHANGE")]
	EhcExchange,
	[OriginalName("EHC_MARBLE")]
	EhcMarble,
	[OriginalName("EHC_MINI_GAME")]
	EhcMiniGame,
	[OriginalName("EHC_BINGO")]
	EhcBingo,
	[OriginalName("EHC_EVENT_MISSION")]
	EhcEventMission,
	[OriginalName("EHC_EVENT_SHOP")]
	EhcEventShop
}
