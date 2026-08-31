using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ScheduleContentId
{
	[OriginalName("SCHEDULE_CONTENT_NONE")]
	ScheduleContentNone = 0,
	[OriginalName("SCHEDULE_CONTENT_PVP")]
	ScheduleContentPvp = 1,
	[OriginalName("SCHEDULE_CONTENT_EVIL_CASTLE")]
	ScheduleContentEvilCastle = 2,
	[OriginalName("SCHEDULE_CONTENT_POPULAR_COSTUME")]
	ScheduleContentPopularCostume = 3,
	[OriginalName("SCHEDULE_CONTENT_POPULAR_EQUIP")]
	ScheduleContentPopularEquip = 4,
	[OriginalName("SCHEDULE_CONTENT_EVIL_CASTLE_ROGUE_LIKE")]
	ScheduleContentEvilCastleRogueLike = 5,
	[OriginalName("SCHEDULE_CONTENT_GUILD_RAID")]
	ScheduleContentGuildRaid = 6,
	[OriginalName("SCHEDULE_CONTENT_MY_ROOM_MONTHLY_LIKE")]
	ScheduleContentMyRoomMonthlyLike = 7,
	[OriginalName("SCHEDULE_CONTENT_COLOSSEUM")]
	ScheduleContentColosseum = 8,
	[OriginalName("SCHEDULE_CONTENT_IB")]
	ScheduleContentIb = 9,
	[OriginalName("SCHEDULE_CONTENT_MAINTENANCE")]
	ScheduleContentMaintenance = 101,
	[OriginalName("SCHEDULE_CONTENT_CBT_APP_STORE")]
	ScheduleContentCbtAppStore = 102,
	[OriginalName("SCHEDULE_CONTENT_CBT_PLAY_STORE")]
	ScheduleContentCbtPlayStore = 103
}
