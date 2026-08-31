using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0h1bnRpbmdHcm91bmRJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjgKGEh1bnRpbmdHcm91bmRJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundInfoRequest), HuntingGroundInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
