using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DispatchDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL0Rpc3BhdGNoREJJbmZvLnByb3RvEglwcm90by5uZXQiRwoORGlzcGF0Y2hEQkluZm8SCgoCaWQYASABKAUSFwoPc2VydmVyX25vd190aW1lGAIgASgDEhAKCGVuZF90aW1lGAMgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DispatchDBInfo), DispatchDBInfo.Parser, new string[3] { "Id", "ServerNowTime", "EndTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
