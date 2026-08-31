using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendReceiveListRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0ZyaWVuZFJlY2VpdmVMaXN0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IicKGEZyaWVuZFJlY2VpdmVMaXN0UmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendReceiveListRequest), FriendReceiveListRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
