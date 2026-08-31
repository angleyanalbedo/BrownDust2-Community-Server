using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0Nvc3R1bWVDbGVhclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJNChNDb3N0dW1lQ2xlYXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRIVCg1jb3N0dW1lX2luZGV4GAIgASgDEhIKCmNoYXJfaW5kZXgYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeClearRequest), CostumeClearRequest.Parser, new string[3] { "Seq", "CostumeIndex", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
