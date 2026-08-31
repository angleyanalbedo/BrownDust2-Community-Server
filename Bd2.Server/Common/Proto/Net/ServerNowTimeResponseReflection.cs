using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ServerNowTimeResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9TZXJ2ZXJOb3dUaW1lUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIsChVTZXJ2ZXJOb3dUaW1lUmVzcG9uc2USEwoLc2VydmVyX3RpbWUYASABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ServerNowTimeResponse), ServerNowTimeResponse.Parser, new string[1] { "ServerTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
