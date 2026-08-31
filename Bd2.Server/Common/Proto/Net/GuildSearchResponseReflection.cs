using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSearchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9HdWlsZFNlYXJjaFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGUNvbW1vbnMvR3VpbGREQkluZm8ucHJvdG8iQQoTR3VpbGRTZWFyY2hSZXNwb25zZRIqCgpndWlsZF9pbmZvGAEgAygLMhYucHJvdG8ubmV0Lkd1aWxkREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { GuildDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSearchResponse), GuildSearchResponse.Parser, new string[1] { "GuildInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
