using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L1Nob3BJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ii8KD1Nob3BJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSDwoHc2hvcF9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopInfoRequest), ShopInfoRequest.Parser, new string[2] { "Seq", "ShopId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
