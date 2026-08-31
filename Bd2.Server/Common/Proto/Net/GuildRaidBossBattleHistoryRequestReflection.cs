using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossBattleHistoryRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXF1ZXN0L0d1aWxkUmFpZEJvc3NCYXR0bGVIaXN0b3J5UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkIKIUd1aWxkUmFpZEJvc3NCYXR0bGVIaXN0b3J5UmVxdWVzdBILCgNzZXEYASABKAUSEAoIcmFpZF9kYXkYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossBattleHistoryRequest), GuildRaidBossBattleHistoryRequest.Parser, new string[2] { "Seq", "RaidDay" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
