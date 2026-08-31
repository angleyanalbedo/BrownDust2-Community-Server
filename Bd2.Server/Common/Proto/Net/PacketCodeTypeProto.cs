using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PacketCodeTypeProto : IMessage<PacketCodeTypeProto>, IMessage, IEquatable<PacketCodeTypeProto>, IDeepCloneable<PacketCodeTypeProto>, IBufferMessage
{
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		public enum PacketCodeType
		{
			[OriginalName("Common")]
			Common = 0,
			[OriginalName("PingCheck")]
			PingCheck = 1,
			[OriginalName("JoinUser")]
			JoinUser = 2,
			[OriginalName("LoginUser")]
			LoginUser = 3,
			[OriginalName("PackInfo")]
			PackInfo = 4,
			[OriginalName("PackInGameInfo")]
			PackInGameInfo = 5,
			[OriginalName("PackBuy")]
			PackBuy = 6,
			[OriginalName("SaveUserPosition")]
			SaveUserPosition = 7,
			[OriginalName("DeckInfo")]
			DeckInfo = 8,
			[OriginalName("CharInfo")]
			CharInfo = 9,
			[OriginalName("DeckSave")]
			DeckSave = 10,
			[OriginalName("CharAllRevival")]
			CharAllRevival = 11,
			[OriginalName("CharLevelUp")]
			CharLevelUp = 12,
			[OriginalName("MercenaryScout")]
			MercenaryScout = 13,
			[OriginalName("BattleStart")]
			BattleStart = 14,
			[OriginalName("BattleEnd")]
			BattleEnd = 15,
			[OriginalName("QuestInfo")]
			QuestInfo = 16,
			[OriginalName("QuestAccept")]
			QuestAccept = 17,
			[OriginalName("QuestClear")]
			QuestClear = 18,
			[OriginalName("QuestUpdate")]
			QuestUpdate = 19,
			[OriginalName("QuestGiveUp")]
			QuestGiveUp = 20,
			[OriginalName("ItemInfo")]
			ItemInfo = 21,
			[OriginalName("EatFood")]
			EatFood = 22,
			[OriginalName("ItemDump")]
			ItemDump = 23,
			[OriginalName("InvenAddSlot")]
			InvenAddSlot = 24,
			[OriginalName("StorageAddSlot")]
			StorageAddSlot = 25,
			[OriginalName("ItemStorageUpdate")]
			ItemStorageUpdate = 26,
			[OriginalName("EatFoodAuto")]
			EatFoodAuto = 27,
			[OriginalName("FieldObjectInfo")]
			FieldObjectInfo = 28,
			[OriginalName("FieldObjectReward")]
			FieldObjectReward = 29,
			[OriginalName("FieldObjectRespawn")]
			FieldObjectRespawn = 30,
			[OriginalName("WaypointInfo")]
			WaypointInfo = 31,
			[OriginalName("WaypointSave")]
			WaypointSave = 32,
			[OriginalName("WaypointUse")]
			WaypointUse = 33,
			[OriginalName("EquipInfo")]
			EquipInfo = 34,
			[OriginalName("EquipUse")]
			EquipUse = 35,
			[OriginalName("EquipClear")]
			EquipClear = 36,
			[OriginalName("EquipUpgrade")]
			EquipUpgrade = 37,
			[OriginalName("EquipLock")]
			EquipLock = 38,
			[OriginalName("EquipAddSlot")]
			EquipAddSlot = 39,
			[OriginalName("CostumeInfo")]
			CostumeInfo = 40,
			[OriginalName("CostumeUse")]
			CostumeUse = 41,
			[OriginalName("CostumeUpgrade")]
			CostumeUpgrade = 42,
			[OriginalName("TalentSkillUse")]
			TalentSkillUse = 43,
			[OriginalName("TalentSkillUpgrade")]
			TalentSkillUpgrade = 44,
			[OriginalName("EquipChange")]
			EquipChange = 45,
			[OriginalName("RecipeInfo")]
			RecipeInfo = 46,
			[OriginalName("CookingResearch")]
			CookingResearch = 47,
			[OriginalName("Cooking")]
			Cooking = 48,
			[OriginalName("Alchemy")]
			Alchemy = 49,
			[OriginalName("EquipMaking")]
			EquipMaking = 50,
			[OriginalName("MonsterInfo")]
			MonsterInfo = 51,
			[OriginalName("BattleEnter")]
			BattleEnter = 52,
			[OriginalName("ShopInfo")]
			ShopInfo = 53,
			[OriginalName("ShopBuy")]
			ShopBuy = 54,
			[OriginalName("ShopSell")]
			ShopSell = 55,
			[OriginalName("EquipBreak")]
			EquipBreak = 56,
			[OriginalName("BattleGiveUp")]
			BattleGiveUp = 57,
			[OriginalName("BattleRetry")]
			BattleRetry = 58,
			[OriginalName("FieldObjectResearch")]
			FieldObjectResearch = 59,
			[OriginalName("CashShopInfo")]
			CashShopInfo = 60,
			[OriginalName("CashShopBuy")]
			CashShopBuy = 61,
			[OriginalName("CharHealing")]
			CharHealing = 62,
			[OriginalName("TrapDamage")]
			TrapDamage = 63,
			[OriginalName("TodayQuestInfo")]
			TodayQuestInfo = 64,
			[OriginalName("CharPartnerInfo")]
			CharPartnerInfo = 65,
			[OriginalName("CharPartnerReward")]
			CharPartnerReward = 66,
			[OriginalName("CharPartnerStoryReward")]
			CharPartnerStoryReward = 67,
			[OriginalName("NpcReputationInfo")]
			NpcReputationInfo = 68,
			[OriginalName("NpcReputationRecovery")]
			NpcReputationRecovery = 69,
			[OriginalName("QuestImmortalReset")]
			QuestImmortalReset = 70,
			[OriginalName("TalentSlotSave")]
			TalentSlotSave = 71,
			[OriginalName("PackJamEvent")]
			PackJamEvent = 72,
			[OriginalName("UserLevelReward")]
			UserLevelReward = 73,
			[OriginalName("UserNicknameChange")]
			UserNicknameChange = 74,
			[OriginalName("UserPortraitChange")]
			UserPortraitChange = 75,
			[OriginalName("ItemStoragePut")]
			ItemStoragePut = 76,
			[OriginalName("ItemStorageOut")]
			ItemStorageOut = 77,
			[OriginalName("ItemStorageInfo")]
			ItemStorageInfo = 78,
			[OriginalName("EquipStoragePut")]
			EquipStoragePut = 79,
			[OriginalName("EquipStorageOut")]
			EquipStorageOut = 80,
			[OriginalName("EquipStorageInfo")]
			EquipStorageInfo = 81,
			[OriginalName("EquipStorageAddSlot")]
			EquipStorageAddSlot = 82,
			[OriginalName("FieldMonsterEvent")]
			FieldMonsterEvent = 83,
			[OriginalName("FieldMonsterReward")]
			FieldMonsterReward = 84,
			[OriginalName("FieldMonsterDamage")]
			FieldMonsterDamage = 85,
			[OriginalName("PvpBattleUserInfo")]
			PvpBattleUserInfo = 86,
			[OriginalName("PvpBattleDeckInfo")]
			PvpBattleDeckInfo = 87,
			[OriginalName("PvpBattleDeckSave")]
			PvpBattleDeckSave = 88,
			[OriginalName("PvpBattleMatching")]
			PvpBattleMatching = 89,
			[OriginalName("PvpBattleStart")]
			PvpBattleStart = 90,
			[OriginalName("PvpBattleEnd")]
			PvpBattleEnd = 91,
			[OriginalName("PvpBattleReward")]
			PvpBattleReward = 92,
			[OriginalName("PvpBattleRanking")]
			PvpBattleRanking = 93,
			[OriginalName("PvpBattleRankUserDetail")]
			PvpBattleRankUserDetail = 94,
			[OriginalName("FieldObjecPositionUpdate")]
			FieldObjecPositionUpdate = 95,
			[OriginalName("CharImmortal")]
			CharImmortal = 96,
			[OriginalName("PvpBattleHistory")]
			PvpBattleHistory = 97,
			[OriginalName("PvpBattleHistoryDeckInfo")]
			PvpBattleHistoryDeckInfo = 98,
			[OriginalName("CharClassUp")]
			CharClassUp = 99,
			[OriginalName("TimePause")]
			TimePause = 100,
			[OriginalName("TutorialInfo")]
			TutorialInfo = 101,
			[OriginalName("TutorialClear")]
			TutorialClear = 102,
			[OriginalName("ActiveMiniMap")]
			ActiveMiniMap = 103,
			[OriginalName("PackPreviewInfo")]
			PackPreviewInfo = 104,
			[OriginalName("EquipSmelting")]
			EquipSmelting = 105,
			[OriginalName("ReputationInfo")]
			ReputationInfo = 106,
			[OriginalName("ShopOpen")]
			ShopOpen = 107,
			[OriginalName("DispatchReward")]
			DispatchReward = 108,
			[OriginalName("InnOpen")]
			InnOpen = 109,
			[OriginalName("HuntingGroundEnter")]
			HuntingGroundEnter = 110,
			[OriginalName("PictorialBookInfo")]
			PictorialBookInfo = 111,
			[OriginalName("EvilCastleInfo")]
			EvilCastleInfo = 112,
			[OriginalName("EvilCastleEnter")]
			EvilCastleEnter = 113,
			[OriginalName("EvilCastleRakingList")]
			EvilCastleRakingList = 114,
			[OriginalName("EvilCastleStageClearReward")]
			EvilCastleStageClearReward = 115,
			[OriginalName("EvilCastleStageRankingInfo")]
			EvilCastleStageRankingInfo = 116,
			[OriginalName("ScheduleInfo")]
			ScheduleInfo = 117,
			[OriginalName("MissionInfo")]
			MissionInfo = 118,
			[OriginalName("MissionUpdate")]
			MissionUpdate = 119,
			[OriginalName("MissionClear")]
			MissionClear = 120,
			[OriginalName("NOTUSEChargeCost")]
			NotusechargeCost = 121,
			[OriginalName("MissionSectionReward")]
			MissionSectionReward = 122,
			[OriginalName("ChargeCostInfo")]
			ChargeCostInfo = 123,
			[OriginalName("PassInfo")]
			PassInfo = 124,
			[OriginalName("EvilCastlePing")]
			EvilCastlePing = 125,
			[OriginalName("PassReward")]
			PassReward = 126,
			[OriginalName("EventMissionInfo")]
			EventMissionInfo = 127,
			[OriginalName("NoneUse128")]
			NoneUse128 = 128,
			[OriginalName("PassBuy")]
			PassBuy = 129,
			[OriginalName("ServerNowTime")]
			ServerNowTime = 130,
			[OriginalName("MailInfo")]
			MailInfo = 131,
			[OriginalName("MailOpen")]
			MailOpen = 132,
			[OriginalName("CharExpiry")]
			CharExpiry = 133,
			[OriginalName("HuntingGroundInfo")]
			HuntingGroundInfo = 134,
			[OriginalName("EvilCastleRewardInfo")]
			EvilCastleRewardInfo = 135,
			[OriginalName("PvpSeasonReward")]
			PvpSeasonReward = 136,
			[OriginalName("QuestMaxClearInfo")]
			QuestMaxClearInfo = 137,
			[OriginalName("MailHistoryInfo")]
			MailHistoryInfo = 138,
			[OriginalName("FieldMonsterRegen")]
			FieldMonsterRegen = 139,
			[OriginalName("CashMailInfo")]
			CashMailInfo = 140,
			[OriginalName("BattleVerify")]
			BattleVerify = 141,
			[OriginalName("BattleVerifyState")]
			BattleVerifyState = 142,
			[OriginalName("UseRandomBox")]
			UseRandomBox = 143,
			[OriginalName("FieldObjectPreview")]
			FieldObjectPreview = 144,
			[OriginalName("GachaInfo")]
			GachaInfo = 145,
			[OriginalName("GachaBuy")]
			GachaBuy = 146,
			[OriginalName("GachaPointExchange")]
			GachaPointExchange = 147,
			[OriginalName("CharSpecialScoutInfo")]
			CharSpecialScoutInfo = 148,
			[OriginalName("CharSpecialScoutBuy")]
			CharSpecialScoutBuy = 149,
			[OriginalName("CharSpecialScoutReset")]
			CharSpecialScoutReset = 150,
			[OriginalName("EventReward")]
			EventReward = 151,
			[OriginalName("EquipsUse")]
			EquipsUse = 155,
			[OriginalName("LeaveUser")]
			LeaveUser = 156,
			[OriginalName("CancelLeaveUser")]
			CancelLeaveUser = 157,
			[OriginalName("PlatformLogin")]
			PlatformLogin = 158,
			[OriginalName("SelectPlatformOtherData")]
			SelectPlatformOtherData = 159,
			[OriginalName("SkyWayInfo")]
			SkyWayInfo = 160,
			[OriginalName("SkyWayEnter")]
			SkyWayEnter = 161,
			[OriginalName("SkyWayScheduleInfo")]
			SkyWayScheduleInfo = 162,
			[OriginalName("EventScheduleInfo")]
			EventScheduleInfo = 163,
			[OriginalName("AllCharRefresh")]
			AllCharRefresh = 165,
			[OriginalName("AchievementInfo")]
			AchievementInfo = 166,
			[OriginalName("AchievementUpdate")]
			AchievementUpdate = 167,
			[OriginalName("AchievementClear")]
			AchievementClear = 168,
			[OriginalName("FieldTrapInfo")]
			FieldTrapInfo = 171,
			[OriginalName("InteractionTrigger")]
			InteractionTrigger = 172,
			[OriginalName("JpUser")]
			JpUser = 173,
			[OriginalName("JpUserInfo")]
			JpUserInfo = 174,
			[OriginalName("GachaBuyPreview")]
			GachaBuyPreview = 175,
			[OriginalName("EquipSequenceUpgrade")]
			EquipSequenceUpgrade = 176,
			[OriginalName("EquipSequenceSmelting")]
			EquipSequenceSmelting = 177,
			[OriginalName("PresetInfo")]
			PresetInfo = 178,
			[OriginalName("PresetSave")]
			PresetSave = 179,
			[OriginalName("PresetAddSlot")]
			PresetAddSlot = 180,
			[OriginalName("BattleEndTest")]
			BattleEndTest = 181,
			[OriginalName("EventExchangeInfo")]
			EventExchangeInfo = 183,
			[OriginalName("EventExchangeReward")]
			EventExchangeReward = 184,
			[OriginalName("EventExchangeNextPageOpen")]
			EventExchangeNextPageOpen = 185,
			[OriginalName("BalanceVersionCheck")]
			BalanceVersionCheck = 186,
			[OriginalName("LogoutUser")]
			LogoutUser = 187,
			[OriginalName("GachaPointManualExchange")]
			GachaPointManualExchange = 188,
			[OriginalName("HuntDispatchInfo")]
			HuntDispatchInfo = 189,
			[OriginalName("HuntDispatchStart")]
			HuntDispatchStart = 190,
			[OriginalName("HuntDispatchEnd")]
			HuntDispatchEnd = 191,
			[OriginalName("EquipOptionReRoll")]
			EquipOptionReRoll = 192,
			[OriginalName("EquipOptionReRollConfirm")]
			EquipOptionReRollConfirm = 193,
			[OriginalName("HuntDispatchRewardPreview")]
			HuntDispatchRewardPreview = 194,
			[OriginalName("NoticeDetailInfo")]
			NoticeDetailInfo = 195,
			[OriginalName("MonsterHuntUserInfo")]
			MonsterHuntUserInfo = 196,
			[OriginalName("MonsterHuntRankInfo")]
			MonsterHuntRankInfo = 197,
			[OriginalName("GachaSelectionSave")]
			GachaSelectionSave = 198,
			[OriginalName("PersonalInfo")]
			PersonalInfo = 199,
			[OriginalName("EvilCastleTowerInfo")]
			EvilCastleTowerInfo = 200,
			[OriginalName("GachaLogInfo")]
			GachaLogInfo = 201,
			[OriginalName("StatueObjectReward")]
			StatueObjectReward = 202,
			[OriginalName("LikeUser")]
			LikeUser = 203,
			[OriginalName("FriendInfoList")]
			FriendInfoList = 204,
			[OriginalName("FriendSend")]
			FriendSend = 205,
			[OriginalName("FriendAccept")]
			FriendAccept = 206,
			[OriginalName("FriendRefuse")]
			FriendRefuse = 207,
			[OriginalName("FriendRemove")]
			FriendRemove = 208,
			[OriginalName("FriendSendList")]
			FriendSendList = 209,
			[OriginalName("FriendReceiveList")]
			FriendReceiveList = 210,
			[OriginalName("FriendRecommend")]
			FriendRecommend = 211,
			[OriginalName("FriendSearch")]
			FriendSearch = 212,
			[OriginalName("FriendSendRemove")]
			FriendSendRemove = 213,
			[OriginalName("PackEventBattleInfo")]
			PackEventBattleInfo = 214,
			[OriginalName("UserContentsInfo")]
			UserContentsInfo = 215,
			[OriginalName("UserContentsInfoOption")]
			UserContentsInfoOption = 216,
			[OriginalName("UpdateUserContentsInfoOption")]
			UpdateUserContentsInfoOption = 217,
			[OriginalName("MyLikeInfo")]
			MyLikeInfo = 218,
			[OriginalName("UserGreetingChange")]
			UserGreetingChange = 219,
			[OriginalName("PackEventStoryInfo")]
			PackEventStoryInfo = 220,
			[OriginalName("PackEventStoryClear")]
			PackEventStoryClear = 221,
			[OriginalName("EventHubInfoResponse")]
			EventHubInfoResponse = 222,
			[OriginalName("MiniGameBoardInfo")]
			MiniGameBoardInfo = 223,
			[OriginalName("MiniGameBoardPlay")]
			MiniGameBoardPlay = 224,
			[OriginalName("UserTitleChange")]
			UserTitleChange = 225,
			[OriginalName("PackRewardObjectCount")]
			PackRewardObjectCount = 226,
			[OriginalName("PackSubQuestClearInfo")]
			PackSubQuestClearInfo = 227,
			[OriginalName("MyRoomUserInfo")]
			MyRoomUserInfo = 228,
			[OriginalName("MyRoomSave")]
			MyRoomSave = 229,
			[OriginalName("MyRoomSearchFriend")]
			MyRoomSearchFriend = 230,
			[OriginalName("MyRoomSearchRecommend")]
			MyRoomSearchRecommend = 231,
			[OriginalName("MyRoomItemInfo")]
			MyRoomItemInfo = 232,
			[OriginalName("NoneUse233")]
			NoneUse233 = 233,
			[OriginalName("MyRoomNameChange")]
			MyRoomNameChange = 234,
			[OriginalName("MyRoomPrimaryChange")]
			MyRoomPrimaryChange = 235,
			[OriginalName("TotalWarInfo")]
			TotalWarInfo = 236,
			[OriginalName("TotalWarDeckInfo")]
			TotalWarDeckInfo = 237,
			[OriginalName("TotalWarDeckSave")]
			TotalWarDeckSave = 238,
			[OriginalName("TotalWarDeckPresetInfo")]
			TotalWarDeckPresetInfo = 239,
			[OriginalName("TotalWarDeckPresetSave")]
			TotalWarDeckPresetSave = 240,
			[OriginalName("TotalWarDeckPresetSlotAdd")]
			TotalWarDeckPresetSlotAdd = 241,
			[OriginalName("TotalWarReward")]
			TotalWarReward = 242,
			[OriginalName("TotalWarBattleStart")]
			TotalWarBattleStart = 243,
			[OriginalName("TotalWarBattleEnd")]
			TotalWarBattleEnd = 244,
			[OriginalName("MyRoomShopInfo")]
			MyRoomShopInfo = 245,
			[OriginalName("MyRoomShopBuy")]
			MyRoomShopBuy = 246,
			[OriginalName("MiniGameFieldInfo")]
			MiniGameFieldInfo = 247,
			[OriginalName("MiniGameFieldStart")]
			MiniGameFieldStart = 248,
			[OriginalName("MiniGameFieldScore")]
			MiniGameFieldScore = 249,
			[OriginalName("MiniGameFieldEnd")]
			MiniGameFieldEnd = 250,
			[OriginalName("MiniGameFieldQuickReward")]
			MiniGameFieldQuickReward = 251,
			[OriginalName("TotalWarRewardState")]
			TotalWarRewardState = 252,
			[OriginalName("EquipPresetInfo")]
			EquipPresetInfo = 253,
			[OriginalName("EquipPresetSave")]
			EquipPresetSave = 254,
			[OriginalName("EquipsClear")]
			EquipsClear = 255,
			[OriginalName("MiniGameBingoInfo")]
			MiniGameBingoInfo = 256,
			[OriginalName("MiniGameBingoPlay")]
			MiniGameBingoPlay = 257,
			[OriginalName("SaveTotalBattlePower")]
			SaveTotalBattlePower = 258,
			[OriginalName("EquipPresetNameChange")]
			EquipPresetNameChange = 259,
			[OriginalName("FieldObjectRewardList")]
			FieldObjectRewardList = 260,
			[OriginalName("QuickBattle")]
			QuickBattle = 261,
			[OriginalName("AlchemyBatch")]
			AlchemyBatch = 262,
			[OriginalName("MonsterHuntDeckInfo")]
			MonsterHuntDeckInfo = 263,
			[OriginalName("MonsterHuntDeckSave")]
			MonsterHuntDeckSave = 264,
			[OriginalName("MonsterHuntChangeTeam")]
			MonsterHuntChangeTeam = 265,
			[OriginalName("MonsterHuntQuickBattle")]
			MonsterHuntQuickBattle = 266,
			[OriginalName("CostumePotentialConnect")]
			CostumePotentialConnect = 267,
			[OriginalName("CostumeNodeActivation")]
			CostumeNodeActivation = 268,
			[OriginalName("PopularCostumeInfo")]
			PopularCostumeInfo = 269,
			[OriginalName("ClientCustomLog")]
			ClientCustomLog = 270,
			[OriginalName("UseResourceItem")]
			UseResourceItem = 271,
			[OriginalName("FieldDeckInfo")]
			FieldDeckInfo = 273,
			[OriginalName("FieldDeckSave")]
			FieldDeckSave = 274,
			[OriginalName("Overwhelm")]
			Overwhelm = 275,
			[OriginalName("EquipBatchUse")]
			EquipBatchUse = 276,
			[OriginalName("PvpBattleOnceRewardInfo")]
			PvpBattleOnceRewardInfo = 277,
			[OriginalName("PresetInfoChange")]
			PresetInfoChange = 278,
			[OriginalName("EvilCastleRogueLikeInfo")]
			EvilCastleRogueLikeInfo = 279,
			[OriginalName("EvilCastleRogueLikeEnter")]
			EvilCastleRogueLikeEnter = 280,
			[OriginalName("EvilCastleRogueLikeGiveUp")]
			EvilCastleRogueLikeGiveUp = 281,
			[OriginalName("EvilCastleRogueLikeRoomEnter")]
			EvilCastleRogueLikeRoomEnter = 282,
			[OriginalName("EvilCastleRogueLikeSelectReward")]
			EvilCastleRogueLikeSelectReward = 283,
			[OriginalName("EvilCastleRogueLikeRewardReRoll")]
			EvilCastleRogueLikeRewardReRoll = 284,
			[OriginalName("EvilCastleRogueLikeDeckSave")]
			EvilCastleRogueLikeDeckSave = 285,
			[OriginalName("PackClearReward")]
			PackClearReward = 286,
			[OriginalName("BattleRetryPreviousTurn")]
			BattleRetryPreviousTurn = 287,
			[OriginalName("SaveFieldCharControlDeckType")]
			SaveFieldCharControlDeckType = 288,
			[OriginalName("CommunityRewardInfo")]
			CommunityRewardInfo = 289,
			[OriginalName("CommunityReward")]
			CommunityReward = 290,
			[OriginalName("GuildRaidMainInfo")]
			GuildRaidMainInfo = 291,
			[OriginalName("GuildRaidNormalBattleInfo")]
			GuildRaidNormalBattleInfo = 292,
			[OriginalName("GuildRaidBossBattleInfo")]
			GuildRaidBossBattleInfo = 293,
			[OriginalName("GuildRaidBossQuickBattle")]
			GuildRaidBossQuickBattle = 294,
			[OriginalName("GuildCreate")]
			GuildCreate = 296,
			[OriginalName("GuildInfo")]
			GuildInfo = 297,
			[OriginalName("GuildLeave")]
			GuildLeave = 298,
			[OriginalName("GuildRecommend")]
			GuildRecommend = 299,
			[OriginalName("GuildJoin")]
			GuildJoin = 300,
			[OriginalName("GuildAccept")]
			GuildAccept = 301,
			[OriginalName("GuildJoinRefuse")]
			GuildJoinRefuse = 302,
			[OriginalName("GuildMemberBan")]
			GuildMemberBan = 303,
			[OriginalName("GuildMemberRoleEdit")]
			GuildMemberRoleEdit = 304,
			[OriginalName("GuildInfoEdit")]
			GuildInfoEdit = 305,
			[OriginalName("GuildSearch")]
			GuildSearch = 306,
			[OriginalName("GuildSupporterList")]
			GuildSupporterList = 308,
			[OriginalName("GuildRaidMemberRanking")]
			GuildRaidMemberRanking = 309,
			[OriginalName("GuildRaidSeasonReward")]
			GuildRaidSeasonReward = 310,
			[OriginalName("GuildJoinSendCancel")]
			GuildJoinSendCancel = 311,
			[OriginalName("GuildRaidDeckInfo")]
			GuildRaidDeckInfo = 312,
			[OriginalName("GuildRaidDeckSave")]
			GuildRaidDeckSave = 313,
			[OriginalName("GuildJoinRequestInfo")]
			GuildJoinRequestInfo = 314,
			[OriginalName("GuildDeleteCancel")]
			GuildDeleteCancel = 315,
			[OriginalName("GuildRaidBossBattleEnter")]
			GuildRaidBossBattleEnter = 316,
			[OriginalName("EvilCastleRogueLikeBattleCharChange")]
			EvilCastleRogueLikeBattleCharChange = 317,
			[OriginalName("EvilCastleRogueLikeEventSelect")]
			EvilCastleRogueLikeEventSelect = 318,
			[OriginalName("EvilCastleRogueLikeEventChoice")]
			EvilCastleRogueLikeEventChoice = 319,
			[OriginalName("EvilCastleRogueLikeShopBuy")]
			EvilCastleRogueLikeShopBuy = 320,
			[OriginalName("EvilCastleRogueLikeShopReRoll")]
			EvilCastleRogueLikeShopReRoll = 321,
			[OriginalName("EvilCastleRogueLikeShopExit")]
			EvilCastleRogueLikeShopExit = 322,
			[OriginalName("EvilCastleRogueLikeGrowth")]
			EvilCastleRogueLikeGrowth = 323,
			[OriginalName("EvilCastleRogueLikeGiveUpInfo")]
			EvilCastleRogueLikeGiveUpInfo = 324,
			[OriginalName("EvilCastleRogueLikeAllUserScoreInfo")]
			EvilCastleRogueLikeAllUserScoreInfo = 325,
			[OriginalName("EvilCastleRogueLikeRankInfo")]
			EvilCastleRogueLikeRankInfo = 326,
			[OriginalName("EvilCastleRogueLikeSeasonReward")]
			EvilCastleRogueLikeSeasonReward = 327,
			[OriginalName("GuildInitInfo")]
			GuildInitInfo = 332,
			[OriginalName("GuildSupporterAdd")]
			GuildSupporterAdd = 333,
			[OriginalName("GuildSupporterDelete")]
			GuildSupporterDelete = 334,
			[OriginalName("GuildUpdateActionInfo")]
			GuildUpdateActionInfo = 335,
			[OriginalName("CharImprintInfo")]
			CharImprintInfo = 336,
			[OriginalName("CharImprintLevelUp")]
			CharImprintLevelUp = 337,
			[OriginalName("CharAwakeActive")]
			CharAwakeActive = 338,
			[OriginalName("GuildRaidBossBattleHistory")]
			GuildRaidBossBattleHistory = 339,
			[OriginalName("EvilCastleRogueLikeQuickBattle")]
			EvilCastleRogueLikeQuickBattle = 340,
			[OriginalName("GuildSupporterInfo")]
			GuildSupporterInfo = 341
		}
	}

	private static readonly MessageParser<PacketCodeTypeProto> _parser = new MessageParser<PacketCodeTypeProto>(() => new PacketCodeTypeProto());

	private UnknownFieldSet _unknownFields;

	public const int PacketCodeTypeFieldNumber = 1;

	private Types.PacketCodeType packetCodeType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PacketCodeTypeProto> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PacketCodeTypeProtoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PacketCodeType PacketCodeType
	{
		get
		{
			return packetCodeType_;
		}
		set
		{
			packetCodeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PacketCodeTypeProto()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PacketCodeTypeProto(PacketCodeTypeProto other)
		: this()
	{
		packetCodeType_ = other.packetCodeType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PacketCodeTypeProto Clone()
	{
		return new PacketCodeTypeProto(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PacketCodeTypeProto);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PacketCodeTypeProto other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PacketCodeType == other.PacketCodeType)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (PacketCodeType != Types.PacketCodeType.Common)
		{
			num ^= PacketCodeType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (PacketCodeType != Types.PacketCodeType.Common)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)PacketCodeType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (PacketCodeType != Types.PacketCodeType.Common)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PacketCodeType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PacketCodeTypeProto other)
	{
		if (other != null)
		{
			if (other.PacketCodeType != Types.PacketCodeType.Common)
			{
				PacketCodeType = other.PacketCodeType;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PacketCodeType = (Types.PacketCodeType)input.ReadEnum();
			}
		}
	}
}
