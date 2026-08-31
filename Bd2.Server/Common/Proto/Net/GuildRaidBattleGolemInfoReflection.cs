using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBattleGolemInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL0d1aWxkUmFpZEJhdHRsZUdvbGVtSW5mby5wcm90bxIJcHJvdG8ubmV0IkcKGEd1aWxkUmFpZEJhdHRsZUdvbGVtSW5mbxIPCgdhZGRfZXhwGAEgASgFEg0KBWxldmVsGAIgASgFEgsKA2V4cBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBattleGolemInfo), GuildRaidBattleGolemInfo.Parser, new string[3] { "AddExp", "Level", "Exp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
