using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_BattleChallengeType
{
	[OriginalName("BATTLE_CHALLENGE_TYPE_NORMAL")]
	BattleChallengeTypeNormal,
	[OriginalName("BATTLE_CHALLENGE_TYPE_EVIL_CASTLE")]
	BattleChallengeTypeEvilCastle
}
