using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomNameChangeResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9NeVJvb21OYW1lQ2hhbmdlUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIaChhNeVJvb21OYW1lQ2hhbmdlUmVzcG9uc2ViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomNameChangeResponse), MyRoomNameChangeResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
