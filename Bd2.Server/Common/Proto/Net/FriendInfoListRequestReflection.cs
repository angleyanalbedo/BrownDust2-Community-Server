using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendInfoListRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0ZyaWVuZEluZm9MaXN0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjEKFUZyaWVuZEluZm9MaXN0UmVxdWVzdBILCgNzZXEYASABKAUSCwoDYWxsGAIgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendInfoListRequest), FriendInfoListRequest.Parser, new string[2] { "Seq", "All" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
