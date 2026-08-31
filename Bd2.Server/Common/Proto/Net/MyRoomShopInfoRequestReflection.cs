using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomShopInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L015Um9vbVNob3BJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IiQKFU15Um9vbVNob3BJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomShopInfoRequest), MyRoomShopInfoRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
