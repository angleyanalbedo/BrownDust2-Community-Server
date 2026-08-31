using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterAddResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZFN1cHBvcnRlckFkZFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiGwoZR3VpbGRTdXBwb3J0ZXJBZGRSZXNwb25zZWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterAddResponse), GuildSupporterAddResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
