using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRewardInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXF1ZXN0L0V2aWxDYXN0bGVSZXdhcmRJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjsKG0V2aWxDYXN0bGVSZXdhcmRJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRewardInfoRequest), EvilCastleRewardInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
