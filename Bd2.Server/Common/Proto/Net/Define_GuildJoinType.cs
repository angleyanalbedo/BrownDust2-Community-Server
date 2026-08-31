using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GuildJoinType
{
	[OriginalName("GUILD_TYPE_NONE")]
	GuildTypeNone,
	[OriginalName("GUILD_TYPE_ANY")]
	GuildTypeAny,
	[OriginalName("GUILD_TYPE_PRIVATE")]
	GuildTypePrivate,
	[OriginalName("GUILD_TYPE_NOT_ALLOWED")]
	GuildTypeNotAllowed,
	[OriginalName("GUILD_TYPE_DELETE")]
	GuildTypeDelete,
	[OriginalName("GUILD_TYPE_DELETE_SUBMITTED")]
	GuildTypeDeleteSubmitted
}
