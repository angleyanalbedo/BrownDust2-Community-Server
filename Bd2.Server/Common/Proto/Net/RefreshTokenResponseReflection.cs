using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RefreshTokenResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9SZWZyZXNoVG9rZW5SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IiwKFFJlZnJlc2hUb2tlblJlc3BvbnNlEhQKDGFjY2Vzc190b2tlbhgBIAEoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RefreshTokenResponse), RefreshTokenResponse.Parser, new string[1] { "AccessToken" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
