using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_BattleModeType
{
	[OriginalName("NONE")]
	None,
	[OriginalName("QUEST")]
	Quest,
	[OriginalName("NORMAL_HUNT")]
	NormalHunt,
	[OriginalName("FIELD_BOX_BATTLE")]
	FieldBoxBattle,
	[OriginalName("TODAY_QUEST")]
	TodayQuest,
	[OriginalName("HUNTING_GROUND")]
	HuntingGround,
	[OriginalName("PVP")]
	Pvp,
	[OriginalName("EVIL_CASTLE")]
	EvilCastle,
	[OriginalName("MONSTER_HUNT")]
	MonsterHunt,
	[OriginalName("SKY_WAY_GOBLIN")]
	SkyWayGoblin,
	[OriginalName("SKY_WAY_SLIME")]
	SkyWaySlime,
	[OriginalName("SKY_WAY_CRYSTAL_FIRE")]
	SkyWayCrystalFire,
	[OriginalName("SKY_WAY_CRYSTAL_WATER")]
	SkyWayCrystalWater,
	[OriginalName("SKY_WAY_CRYSTAL_WIND")]
	SkyWayCrystalWind,
	[OriginalName("SKY_WAY_CRYSTAL_LIGHT")]
	SkyWayCrystalLight,
	[OriginalName("SKY_WAY_CRYSTAL_DARK")]
	SkyWayCrystalDark,
	[OriginalName("EVIL_CASTLE_GREED_TOWER")]
	EvilCastleGreedTower,
	[OriginalName("PACK_EVENT_BATTLE")]
	PackEventBattle,
	[OriginalName("TOTAL_WAR")]
	TotalWar,
	[OriginalName("EVIL_CASTLE_RAGE_TOWER")]
	EvilCastleRageTower,
	[OriginalName("EVIL_CASTLE_ENVY_TOWER")]
	EvilCastleEnvyTower,
	[OriginalName("EVIL_CASTLE_ROGUE_LIKE")]
	EvilCastleRogueLike,
	[OriginalName("GUILD_RAID_NORMAL")]
	GuildRaidNormal,
	[OriginalName("GUILD_RAID_BOSS")]
	GuildRaidBoss,
	[OriginalName("MONSTER_HUNT_PRACTICE")]
	MonsterHuntPractice
}
