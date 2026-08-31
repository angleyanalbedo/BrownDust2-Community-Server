using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildCreateResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9HdWlsZENyZWF0ZVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGUNvbW1vbnMvR3VpbGREQkluZm8ucHJvdG8iVgoTR3VpbGRDcmVhdGVSZXNwb25zZRIqCgpndWlsZF9pbmZvGAEgASgLMhYucHJvdG8ubmV0Lkd1aWxkREJJbmZvEhMKC3RvcF9wZXJjZW50GAIgASgBYgZwcm90bzM="), new FileDescriptor[1] { GuildDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildCreateResponse), GuildCreateResponse.Parser, new string[2] { "GuildInfo", "TopPercent" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
