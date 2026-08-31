using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GuildMemberRole
{
	[OriginalName("GUILD_ROLE_NONE")]
	GuildRoleNone,
	[OriginalName("GUILD_ROLE_ADMIN")]
	GuildRoleAdmin,
	[OriginalName("GUILD_ROLE_SUB_ADMIN")]
	GuildRoleSubAdmin,
	[OriginalName("GUILD_ROLE_MEMBER")]
	GuildRoleMember
}
