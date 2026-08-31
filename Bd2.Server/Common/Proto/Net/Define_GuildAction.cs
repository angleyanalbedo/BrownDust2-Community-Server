using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GuildAction
{
	[OriginalName("GUILD_ACTION_NONE")]
	GuildActionNone,
	[OriginalName("GUILD_ACTION_CREATE")]
	GuildActionCreate,
	[OriginalName("GUILD_ACTION_JOIN")]
	GuildActionJoin,
	[OriginalName("GUILD_ACTION_LEAVE")]
	GuildActionLeave,
	[OriginalName("GUILD_ACTION_BAN")]
	GuildActionBan,
	[OriginalName("GUILD_ACTION_ACCEPT")]
	GuildActionAccept,
	[OriginalName("GUILD_ACTION_REFUSE")]
	GuildActionRefuse,
	[OriginalName("GUILD_ACTION_INFO_EDIT")]
	GuildActionInfoEdit,
	[OriginalName("GUILD_ACTION_ROLE_CHANGE")]
	GuildActionRoleChange,
	[OriginalName("GUILD_ACTION_ADMIN_INACTIVE")]
	GuildActionAdminInactive
}
