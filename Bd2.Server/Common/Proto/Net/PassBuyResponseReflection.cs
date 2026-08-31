using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9QYXNzQnV5UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIeCg9QYXNzQnV5UmVzcG9uc2USCwoDZXhwGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassBuyResponse), PassBuyResponse.Parser, new string[1] { "Exp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
