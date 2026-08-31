using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildDeleteCancelResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZERlbGV0ZUNhbmNlbFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiGwoZR3VpbGREZWxldGVDYW5jZWxSZXNwb25zZWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildDeleteCancelResponse), GuildDeleteCancelResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
