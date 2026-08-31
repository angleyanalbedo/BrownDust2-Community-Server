using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossBattleHistoryResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXNwb25zZS9HdWlsZFJhaWRCb3NzQmF0dGxlSGlzdG9yeVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiXgoiR3VpbGRSYWlkQm9zc0JhdHRsZUhpc3RvcnlSZXNwb25zZRIbChN0b2RheV9oaWdoZXN0X2xldmVsGAEgASgFEhsKE3RvZGF5X2hpZ2hlc3Rfc2NvcmUYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossBattleHistoryResponse), GuildRaidBossBattleHistoryResponse.Parser, new string[2] { "TodayHighestLevel", "TodayHighestScore" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
