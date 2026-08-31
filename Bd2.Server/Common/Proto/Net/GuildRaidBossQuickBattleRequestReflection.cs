using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossQuickBattleRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L0d1aWxkUmFpZEJvc3NRdWlja0JhdHRsZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIuCh9HdWlsZFJhaWRCb3NzUXVpY2tCYXR0bGVSZXF1ZXN0EgsKA3NlcRgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossQuickBattleRequest), GuildRaidBossQuickBattleRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
