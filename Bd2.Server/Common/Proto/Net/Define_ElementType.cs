using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ElementType
{
	[OriginalName("_TYPE_NONE")]
	TypeNone = 0,
	[OriginalName("_TYPE_CASH")]
	TypeCash = 1,
	[OriginalName("_TYPE_JEWELRY")]
	TypeJewelry = 2,
	[OriginalName("_TYPE_FREE_JEWELRY")]
	TypeFreeJewelry = 3,
	[OriginalName("_TYPE_GOLD")]
	TypeGold = 4,
	[OriginalName("_TYPE_FOOD")]
	TypeFood = 5,
	[OriginalName("_TYPE_CHAR")]
	TypeChar = 6,
	[OriginalName("_TYPE_COOKING_RECIPE")]
	TypeCookingRecipe = 7,
	[OriginalName("_TYPE_RESOURCE")]
	TypeResource = 8,
	[OriginalName("_TYPE_RANDOM_BOX")]
	TypeRandomBox = 9,
	[OriginalName("_TYPE_EQUIP")]
	TypeEquip = 10,
	[OriginalName("_TYPE_COSTUME")]
	TypeCostume = 11,
	[OriginalName("_TYPE_CATALYST")]
	TypeCatalyst = 12,
	[OriginalName("_TYPE_QUEST")]
	TypeQuest = 13,
	[OriginalName("_TYPE_USE_ITEM")]
	TypeUseItem = 14,
	[OriginalName("_TYPE_PVP_TICKET")]
	TypePvpTicket = 15,
	[OriginalName("_TYPE_MEDAL")]
	TypeMedal = 16,
	[OriginalName("_TYPE_COLLECTION")]
	TypeCollection = 17,
	[OriginalName("_TYPE_EVIL_CASTLE_COIN")]
	TypeEvilCastleCoin = 18,
	[OriginalName("_TYPE_CONTENT_TICKET")]
	TypeContentTicket = 19,
	[OriginalName("_TYPE_MILEAGE")]
	TypeMileage = 20,
	[OriginalName("_TYPE_HUNTING_GROUND_AP")]
	TypeHuntingGroundAp = 21,
	[OriginalName("_TYPE_HOPE_POWDER")]
	TypeHopePowder = 22,
	[OriginalName("_TYPE_BONUS_HUNTING_AP")]
	TypeBonusHuntingAp = 23,
	[OriginalName("_TYPE_PVP_TICKET_STACK")]
	TypePvpTicketStack = 24,
	[OriginalName("_TYPE_LOBBY_SETTING_ITEM")]
	TypeLobbySettingItem = 25,
	[OriginalName("_TYPE_TITLE")]
	TypeTitle = 26,
	[OriginalName("_TYPE_MY_ROOM_ITEM")]
	TypeMyRoomItem = 27,
	[OriginalName("_TYPE_MY_ROOM_TROPHY")]
	TypeMyRoomTrophy = 28,
	[OriginalName("_TYPE_INSTANT_USE_ITEM")]
	TypeInstantUseItem = 29,
	[OriginalName("_TYPE_EVENT_AP_FREE")]
	TypeEventApFree = 30,
	[OriginalName("_TYPE_EVENT_AP_STACK")]
	TypeEventApStack = 31,
	[OriginalName("_TYPE_FREE_TORCH_LIGHT_AP")]
	TypeFreeTorchLightAp = 32,
	[OriginalName("_TYPE_TORCH_LIGHT_AP")]
	TypeTorchLightAp = 33,
	[OriginalName("_TYPE_ROGUE_LIKE_RELIC")]
	TypeRogueLikeRelic = 34,
	[OriginalName("_TYPE_ROGUE_LIKE_AP")]
	TypeRogueLikeAp = 35,
	[OriginalName("_TYPE_ROGUE_LIKE_OBSIDIAN")]
	TypeRogueLikeObsidian = 36,
	[OriginalName("_TYPE_ROGUE_LIKE_GOLD")]
	TypeRogueLikeGold = 37,
	[OriginalName("_TYPE_ROGUE_LIKE_AP_STACK")]
	TypeRogueLikeApStack = 38,
	[OriginalName("_TYPE_GUILD_COIN")]
	TypeGuildCoin = 39,
	[OriginalName("_TYPE_DIRECT_RANDOM_BOX")]
	TypeDirectRandomBox = 99
}
