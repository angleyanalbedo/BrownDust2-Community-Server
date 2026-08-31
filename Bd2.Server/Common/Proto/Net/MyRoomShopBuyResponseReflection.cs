using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomShopBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9NeVJvb21TaG9wQnV5UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8iUgoVTXlSb29tU2hvcEJ1eVJlc3BvbnNlEjkKEnJld2FyZF9pbmZvX2J1bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomShopBuyResponse), MyRoomShopBuyResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
