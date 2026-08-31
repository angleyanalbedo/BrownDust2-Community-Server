using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MonsterHuntPartsType
{
	[OriginalName("MONSTER_HUNT_PARTS_BODY")]
	MonsterHuntPartsBody = 0,
	[OriginalName("MONSTER_HUNT_PARTS_ETC")]
	MonsterHuntPartsEtc = 1,
	[OriginalName("MONSTER_HUNT_PARTS_NONE")]
	MonsterHuntPartsNone = -1
}
