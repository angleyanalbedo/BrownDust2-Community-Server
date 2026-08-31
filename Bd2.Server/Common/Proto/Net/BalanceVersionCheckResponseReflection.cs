using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BalanceVersionCheckResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9CYWxhbmNlVmVyc2lvbkNoZWNrUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIdChtCYWxhbmNlVmVyc2lvbkNoZWNrUmVzcG9uc2ViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BalanceVersionCheckResponse), BalanceVersionCheckResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
