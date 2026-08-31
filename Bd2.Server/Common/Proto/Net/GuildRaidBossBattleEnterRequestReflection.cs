using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossBattleEnterRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L0d1aWxkUmFpZEJvc3NCYXR0bGVFbnRlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJCCh9HdWlsZFJhaWRCb3NzQmF0dGxlRW50ZXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRISCgpib3NzX2xldmVsGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossBattleEnterRequest), GuildRaidBossBattleEnterRequest.Parser, new string[2] { "Seq", "BossLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
