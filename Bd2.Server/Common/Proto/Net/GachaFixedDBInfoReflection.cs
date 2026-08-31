using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaFixedDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0dhY2hhRml4ZWREQkluZm8ucHJvdG8SCXByb3RvLm5ldCJYChBHYWNoYUZpeGVkREJJbmZvEhAKCGZpeGVkX2lkGAEgASgFEgwKBHR5cGUYAiABKAUSDQoFY291bnQYAyABKAUSFQoNYXBwbHlfc29ydF9pZBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaFixedDBInfo), GachaFixedDBInfo.Parser, new string[4] { "FixedId", "Type", "Count", "ApplySortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
