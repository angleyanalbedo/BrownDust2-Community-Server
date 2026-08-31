using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L1Bhc3NJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ih4KD1Bhc3NJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassInfoRequest), PassInfoRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
