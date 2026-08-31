using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackInGameInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1BhY2tJbkdhbWVJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjUKFVBhY2tJbkdhbWVJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackInGameInfoRequest), PackInGameInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
