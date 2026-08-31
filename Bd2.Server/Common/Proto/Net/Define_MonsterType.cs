using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MonsterType
{
	[OriginalName("MONSTER_SYMBOL_NORMAL")]
	MonsterSymbolNormal = 0,
	[OriginalName("MONSTER_SYMBOL_BOSS")]
	MonsterSymbolBoss = 1,
	[OriginalName("MONSTER_FIELD_REWARD")]
	MonsterFieldReward = 2,
	[OriginalName("MONSTER_FIELD_RUSH")]
	MonsterFieldRush = 3,
	[OriginalName("MONSTER_FIELD_CHASE")]
	MonsterFieldChase = 4,
	[OriginalName("MONSTER_SYMBOL_STORY")]
	MonsterSymbolStory = 5,
	[OriginalName("MONSTER_FIELD_GUARD")]
	MonsterFieldGuard = 6,
	[OriginalName("MONSTER_3D_SYMBOL_NORMAL")]
	Monster3DSymbolNormal = 101,
	[OriginalName("MONSTER_3D_SYMBOL_BOSS")]
	Monster3DSymbolBoss = 102
}
