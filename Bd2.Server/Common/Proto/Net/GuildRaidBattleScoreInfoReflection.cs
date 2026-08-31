using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBattleScoreInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL0d1aWxkUmFpZEJhdHRsZVNjb3JlSW5mby5wcm90bxIJcHJv" + "dG8ubmV0IocBChhHdWlsZFJhaWRCYXR0bGVTY29yZUluZm8SFQoNZGVmYXVs" + "dF9zY29yZRgBIAEoBRIYChB0dXJuX2JvbnVzX3Njb3JlGAIgASgFEh8KF2dv" + "bGVtX2xldmVsX2JvbnVzX3Njb3JlGAMgASgFEhkKEWd1aWxkX3RvdGFsX3Nj" + "b3JlGAQgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBattleScoreInfo), GuildRaidBattleScoreInfo.Parser, new string[4] { "DefaultScore", "TurnBonusScore", "GolemLevelBonusScore", "GuildTotalScore" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
