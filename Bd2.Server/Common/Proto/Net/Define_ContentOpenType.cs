using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ContentOpenType
{
	[OriginalName("CONTENT_NONE")]
	ContentNone,
	[OriginalName("CONTENT_UNLOCK_PACK")]
	ContentUnlockPack,
	[OriginalName("CONTENT_UNLOCK_HUNTING")]
	ContentUnlockHunting,
	[OriginalName("CONTENT_UNLOCK_NONE_USE")]
	ContentUnlockNoneUse,
	[OriginalName("CONTENT_UNLOCK_GACHA")]
	ContentUnlockGacha,
	[OriginalName("CONTENT_UNLOCK_UI_EVENT")]
	ContentUnlockUiEvent,
	[OriginalName("CONTENT_UNLOCK_UI_SHOP")]
	ContentUnlockUiShop,
	[OriginalName("CONTENT_UNLOCK_UI_PASS")]
	ContentUnlockUiPass,
	[OriginalName("CONTENT_UNLOCK_UI_MISSION")]
	ContentUnlockUiMission,
	[OriginalName("CONTENT_UNLOCK_UI_MAIL")]
	ContentUnlockUiMail,
	[OriginalName("CONTENT_UNLOCK_UI_PICTORIAL_BOOK")]
	ContentUnlockUiPictorialBook,
	[OriginalName("CONTENT_UNLOCK_MONSTER_HUNT")]
	ContentUnlockMonsterHunt,
	[OriginalName("CONTENT_UNLOCK_ACHIEVEMENT")]
	ContentUnlockAchievement,
	[OriginalName("CONTENT_UNLOCK_PREMIUM_ATTENDANCE")]
	ContentUnlockPremiumAttendance,
	[OriginalName("CONTENT_UNLOCK_HUNT_DISPATCH")]
	ContentUnlockHuntDispatch,
	[OriginalName("CONTENT_UNLOCK_FRIEND")]
	ContentUnlockFriend,
	[OriginalName("CONTENT_UNLOCK_MY_ROOM")]
	ContentUnlockMyRoom,
	[OriginalName("CONTENT_UNLOCK_GUILD")]
	ContentUnlockGuild,
	[OriginalName("CONTENT_UNLOCK_EVIL_CASTLE_ROGUE_LIKE")]
	ContentUnlockEvilCastleRogueLike
}
