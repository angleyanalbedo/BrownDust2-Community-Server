using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MissionConditionType
{
	[OriginalName("MC_CONNECT")]
	McConnect = 0,
	[OriginalName("MC_TODAY_QUEST_CLEAR")]
	McTodayQuestClear = 1,
	[OriginalName("MC_MONSTER_KILL")]
	McMonsterKill = 2,
	[OriginalName("MC_COLLECTION_GET")]
	McCollectionGet = 3,
	[OriginalName("MC_WAYPOINT_USE")]
	McWaypointUse = 4,
	[OriginalName("MC_FIELD_REWARD_MONSTER_CATCH")]
	McFieldRewardMonsterCatch = 5,
	[OriginalName("MC_TALENT_SKILL_USE")]
	McTalentSkillUse = 6,
	[OriginalName("MC_HUNTING_BATTLE")]
	McHuntingBattle = 7,
	[OriginalName("MC_GACHA_BUY")]
	McGachaBuy = 9,
	[OriginalName("MC_PACK_BATTLE")]
	McPackBattle = 10,
	[OriginalName("MC_ITEM_CURRENCY_USE")]
	McItemCurrencyUse = 11,
	[OriginalName("MC_RESOURCE_USE")]
	McResourceUse = 12,
	[OriginalName("MC_CHAR_LEVEL_UP_ITEM_USE")]
	McCharLevelUpItemUse = 13,
	[OriginalName("MC_EQUIPMENT_UPGRADE")]
	McEquipmentUpgrade = 14,
	[OriginalName("MC_EVENT_MINI_GAME_COUNT")]
	McEventMiniGameCount = 15,
	[OriginalName("MC_TARGET_BASIC_PASS_REWARD")]
	McTargetBasicPassReward = 16,
	[OriginalName("MC_PACK_REWARD_BY_EVENT_LOST_COIN_REWARD_FIELD_OBJECT")]
	McPackRewardByEventLostCoinRewardFieldObject = 17,
	[OriginalName("MC_BATTLE_MODE_START_TRY")]
	McBattleModeStartTry = 18,
	[OriginalName("MC_BATTLE_MODE_START_TRY_WITH_UNIQUE_CHAR_ID")]
	McBattleModeStartTryWithUniqueCharId = 19,
	[OriginalName("MC_EQUIP_MAKE_GRADE")]
	McEquipMakeGrade = 20,
	[OriginalName("MC_EQUIP_SMELTING")]
	McEquipSmelting = 21,
	[OriginalName("MC_DECK_BATTLE_POWER")]
	McDeckBattlePower = 22,
	[OriginalName("MC_HUNT_DISPATCH")]
	McHuntDispatch = 23,
	[OriginalName("MC_SKY_WAY_DUNGEON_POSITION_GROUP_LEVEL_CLEAR")]
	McSkyWayDungeonPositionGroupLevelClear = 24,
	[OriginalName("MC_PACK_MAIN_QUEST_HARD_LEVEL_CLEAR")]
	McPackMainQuestHardLevelClear = 25,
	[OriginalName("MC_COSTUME_POTENTIAL_ACTIVATE_NODE_KIND")]
	McCostumePotentialActivateNodeKind = 26,
	[OriginalName("MC_PVP_RANK_ID_GOAL")]
	McPvpRankIdGoal = 27,
	[OriginalName("MC_COSTUME_GRADE_GET")]
	McCostumeGradeGet = 28,
	[OriginalName("MC_TALENT_SKILL_UPGRADE")]
	McTalentSkillUpgrade = 29,
	[OriginalName("MC_SAM_GROUP_ID_MISSION_UPDATE_COMPLETE_COUNT")]
	McSamGroupIdMissionUpdateCompleteCount = 30,
	[OriginalName("MC_OTHER_GROUP_ID_MISSION_UPDATE_COMPLETE_COUNT")]
	McOtherGroupIdMissionUpdateCompleteCount = 31,
	[OriginalName("MC_GACHA_USE_POINT")]
	McGachaUsePoint = 101,
	[OriginalName("MC_GET_GACHA_PICKUP_COSTUME")]
	McGetGachaPickupCostume = 103,
	[OriginalName("MC_COSTUME_UPGRADE")]
	McCostumeUpgrade = 104,
	[OriginalName("MC_TRY_TO_GACHA_TO_TARGET_GACHA_GROUP")]
	McTryToGachaToTargetGachaGroup = 105,
	[OriginalName("MC_GET_GACHA_TO_TARGET_EQUIPMENT_ITEM")]
	McGetGachaToTargetEquipmentItem = 106,
	[OriginalName("MC_PACK_MAIN_QUEST_NORMAL_LEVEL_CLEAR")]
	McPackMainQuestNormalLevelClear = 201,
	[OriginalName("MC_PACK_MAIN_QUEST_1LEVEL_ACCEPT_QUEST")]
	McPackMainQuest1LevelAcceptQuest = 202,
	[OriginalName("MC_PACK_MAIN_QUEST_2LEVEL_ACCEPT_QUEST")]
	McPackMainQuest2LevelAcceptQuest = 203,
	[OriginalName("MC_ENTER_PACK_IN_FIELD")]
	McEnterPackInField = 204,
	[OriginalName("MC_CHAR_TARGET_LEVEL_UP")]
	McCharTargetLevelUp = 207,
	[OriginalName("MC_CHAR_TARGET_GRADE_UP")]
	McCharTargetGradeUp = 208,
	[OriginalName("MC_TRY_TO_CHAR_SCOUT_TO_TARGET_GRADE")]
	McTryToCharScoutToTargetGrade = 209,
	[OriginalName("MC_USE_RECOVERY_THROUGH_MOTEL")]
	McUseRecoveryThroughMotel = 210,
	[OriginalName("MC_BUY_ITEM_iN_SHOP")]
	McBuyItemINShop = 211,
	[OriginalName("MC_SELL_ITEM_iN_SHOP")]
	McSellItemINShop = 212,
	[OriginalName("MC_SUCCESS_EQUIPMENT_UPGRADE_TO_TARGET_LEVEL")]
	McSuccessEquipmentUpgradeToTargetLevel = 213,
	[OriginalName("MC_TRY_TO_EQUIP_EQUIPMENT_ITEM")]
	McTryToEquipEquipmentItem = 214,
	[OriginalName("MC_TRY_TO_CHANGE_EQUIPMENT_ITEM")]
	McTryToChangeEquipmentItem = 215,
	[OriginalName("MC_TRY_TO_BREAK_EQUIPMENT_ITEM")]
	McTryToBreakEquipmentItem = 216,
	[OriginalName("MC_TRY_TO_SMELT_EQUIPMENT_ITEM")]
	McTryToSmeltEquipmentItem = 217,
	[OriginalName("MC_REWARD_BY_RESEARCH_FIELD_OBJECT")]
	McRewardByResearchFieldObject = 218,
	[OriginalName("MC_REWARD_BY_FIELD_REWARD_OBJECT")]
	McRewardByFieldRewardObject = 219,
	[OriginalName("MC_TALENT_SKILL_UPGRADE_TO_TARGET_GRADE")]
	McTalentSkillUpgradeToTargetGrade = 220,
	[OriginalName("MC_REWARD_TO_ACHIEVEMENT_LEVEL")]
	McRewardToAchievementLevel = 221,
	[OriginalName("MC_COMPLETED_PICTORIAL_TO_TARGET_PICTORIAL_TYPE")]
	McCompletedPictorialToTargetPictorialType = 222,
	[OriginalName("MC_REWARD_TO_PASS_LEVEL")]
	McRewardToPassLevel = 223,
	[OriginalName("MC_TRY_TO_USE_AUTO_HUNTING")]
	McTryToUseAutoHunting = 224,
	[OriginalName("MC_TRY_TO_BATTLE_IN_SKYWAY_DUNGEON_GROUP_ID")]
	McTryToBattleInSkywayDungeonGroupId = 227,
	[OriginalName("MC_TRY_TO_CHANGE_COSTUME_IN_BATTLE")]
	McTryToChangeCostumeInBattle = 226,
	[OriginalName("MC_TRY_TO_BATTLE_IN_EVIL_CASTLE_TO_TARGET_FLOOR")]
	McTryToBattleInEvilCastleToTargetFloor = 228,
	[OriginalName("MC_CLEAR_IN_EVIL_CASTLE_TO_TARGET_FLOOR")]
	McClearInEvilCastleToTargetFloor = 229,
	[OriginalName("MC_TRY_TO_BATTLE_IN_MONSTER_HUNT")]
	McTryToBattleInMonsterHunt = 230,
	[OriginalName("MC_PLATFORM_CONNECT_OR_LOGIN")]
	McPlatformConnectOrLogin = 231,
	[OriginalName("MC_EVIL_CASTLE_GREED_TOWER_BATTLE")]
	McEvilCastleGreedTowerBattle = 232,
	[OriginalName("MC_EVIL_CASTLE_GREED_TOWER_CLEAR")]
	McEvilCastleGreedTowerClear = 233,
	[OriginalName("MC_WIN_TO_BATTLE_IN_MONSTER_HUNT")]
	McWinToBattleInMonsterHunt = 240,
	[OriginalName("MC_PACK_NORMAL_LEVEL_CLEAR")]
	McPackNormalLevelClear = 250,
	[OriginalName("MC_PACK_NPC_QUEST_CLEAR_IN_PACK")]
	McPackNpcQuestClearInPack = 251,
	[OriginalName("MC_PACK_REWARD_BY_RESEARCH_FIELD_OBJECT")]
	McPackRewardByResearchFieldObject = 260,
	[OriginalName("MC_PACK_REWARD_BY_UNIQUE_BOX_REWARD_FIELD_OBJECT")]
	McPackRewardByUniqueBoxRewardFieldObject = 261,
	[OriginalName("MC_TOTAL_WAR_USE_COSTUME")]
	McTotalWarUseCostume = 270,
	[OriginalName("MC_TOTAL_WAR_TRY_COUNT")]
	McTotalWarTryCount = 280,
	[OriginalName("MC_TOTAL_WAR_RESULT_SCORE")]
	McTotalWarResultScore = 281,
	[OriginalName("MC_TOTAL_WAR_DISTRIBUTION")]
	McTotalWarDistribution = 290,
	[OriginalName("MC_MY_ROOM_CHANGE_SKIN_FLOOR")]
	McMyRoomChangeSkinFloor = 300,
	[OriginalName("MC_MY_ROOM_CHANGE_SKIN_WALL")]
	McMyRoomChangeSkinWall = 301,
	[OriginalName("MC_MY_ROOM_INSTALL_OBJECT_FLOOR")]
	McMyRoomInstallObjectFloor = 302,
	[OriginalName("MC_MY_ROOM_INSTALL_OBJECT_WALL")]
	McMyRoomInstallObjectWall = 303,
	[OriginalName("MC_MY_ROOM_INSTALL_CARPET")]
	McMyRoomInstallCarpet = 304,
	[OriginalName("MC_MY_ROOM_INSTALL_COSTUME")]
	McMyRoomInstallCostume = 305,
	[OriginalName("MC_MY_ROOM_SAVE_THE_ROOM")]
	McMyRoomSaveTheRoom = 306,
	[OriginalName("MC_MY_ROOM_INSTALL_COSTUME_TO_LYING_POSITION")]
	McMyRoomInstallCostumeToLyingPosition = 307,
	[OriginalName("MC_MY_ROOM_INSTALL_COSTUME_TO_SITTING_POSITION")]
	McMyRoomInstallCostumeToSittingPosition = 308,
	[OriginalName("MC_MY_ROOM_SET_PRESENTIVE_ROOM")]
	McMyRoomSetPresentiveRoom = 309,
	[OriginalName("MC_MY_ROOM_BUY_ITEM")]
	McMyRoomBuyItem = 310,
	[OriginalName("MC_MY_ROOM_INSTALL_OBJECT")]
	McMyRoomInstallObject = 311,
	[OriginalName("MC_MY_ROOM_VISIT_ANOTHER_USER")]
	McMyRoomVisitAnotherUser = 312,
	[OriginalName("MC_MY_ROOM_SATURATION_PERCENT")]
	McMyRoomSaturationPercent = 313,
	[OriginalName("MC_COSTUME_POTENTIAL_ACTIVATION_SKILL_NODE")]
	McCostumePotentialActivationSkillNode = 314,
	[OriginalName("MC_COMPLETED_DAILY_OPEN_EVENT_MISSION_TO_TARGET_DAY")]
	McCompletedDailyOpenEventMissionToTargetDay = 1001,
	[OriginalName("MC_COMPLETED_EVENT_MISSION_IN_SAME_GROUP_ID")]
	McCompletedEventMissionInSameGroupId = 1002
}
