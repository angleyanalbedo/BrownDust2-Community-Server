using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_JoinResultType
{
	[OriginalName("GUILD_JOIN_SUCCESS")]
	GuildJoinSuccess,
	[OriginalName("GUILD_JOIN_FAIL_COOLDOWN")]
	GuildJoinFailCooldown
}
