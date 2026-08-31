using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaLogRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0dhY2hhTG9nUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjUKD0dhY2hhTG9nUmVxdWVzdBILCgNzZXEYASABKAUSFQoNbGFzdF9sb2dfdGltZRgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaLogRequest), GachaLogRequest.Parser, new string[2] { "Seq", "LastLogTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
