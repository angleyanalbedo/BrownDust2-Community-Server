using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildAcceptResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9HdWlsZEFjY2VwdFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiFQoTR3VpbGRBY2NlcHRSZXNwb25zZWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildAcceptResponse), GuildAcceptResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
