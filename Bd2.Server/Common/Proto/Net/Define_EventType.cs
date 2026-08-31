using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EventType
{
	[OriginalName("EVENT_ALWAYS_ATTENDANCE")]
	EventAlwaysAttendance = 0,
	[OriginalName("EVENT_LIMIT_ATTENDANCE")]
	EventLimitAttendance = 1,
	[OriginalName("EVENT_WORLD_BUFF")]
	EventWorldBuff = 3,
	[OriginalName("EVENT_MISSION")]
	EventMission = 4,
	[OriginalName("EVENT_PASS")]
	EventPass = 5,
	[OriginalName("EVENT_DROP_ITEM")]
	EventDropItem = 6,
	[OriginalName("EVENT_EXCHANGE")]
	EventExchange = 7,
	[OriginalName("EVENT_PACK")]
	EventPack = 8,
	[OriginalName("EVENT_BATTLE")]
	EventBattle = 9,
	[OriginalName("EVENT_STORY")]
	EventStory = 10,
	[OriginalName("EVENT_MINI_GAME")]
	EventMiniGame = 11,
	[OriginalName("EVENT_MINI_GAME_BOARD")]
	EventMiniGameBoard = 12,
	[OriginalName("EVENT_MINI_GAME_BINGO")]
	EventMiniGameBingo = 13,
	[OriginalName("EVENT_LOST_COIN")]
	EventLostCoin = 14,
	[OriginalName("EVENT_SHOP")]
	EventShop = 15,
	[OriginalName("EVENT_GACHA_STEP_UP")]
	EventGachaStepUp = 16
}
