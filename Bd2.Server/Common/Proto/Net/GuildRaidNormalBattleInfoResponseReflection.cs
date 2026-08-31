using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidNormalBattleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjBSZXNwb25zZS9HdWlsZFJhaWROb3JtYWxCYXR0bGVJbmZvUmVzcG9uc2Uu" + "cHJvdG8SCXByb3RvLm5ldBopQ29tbW9ucy9HdWlsZFJhaWROb3JtYWxCYXR0" + "bGVEQkluZm8ucHJvdG8igQEKIUd1aWxkUmFpZE5vcm1hbEJhdHRsZUluZm9S" + "ZXNwb25zZRI0CgRpbmZvGAEgAygLMiYucHJvdG8ubmV0Lkd1aWxkUmFpZE5v" + "cm1hbEJhdHRsZURCSW5mbxITCgtnb2xlbV9sZXZlbBgCIAEoBRIRCglnb2xl" + "bV9leHAYAyABKAViBnByb3RvMw=="), new FileDescriptor[1] { GuildRaidNormalBattleDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidNormalBattleInfoResponse), GuildRaidNormalBattleInfoResponse.Parser, new string[3] { "Info", "GolemLevel", "GolemExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
