using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastlePingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0V2aWxDYXN0bGVQaW5nUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjkKFUV2aWxDYXN0bGVQaW5nUmVxdWVzdBILCgNzZXEYASABKAUSEwoLc3RhZ2VfaW5kZXgYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastlePingRequest), EvilCastlePingRequest.Parser, new string[2] { "Seq", "StageIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
