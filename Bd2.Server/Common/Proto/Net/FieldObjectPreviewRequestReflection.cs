using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectPreviewRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0ZpZWxkT2JqZWN0UHJldmlld1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI5ChlGaWVsZE9iamVjdFByZXZpZXdSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectPreviewRequest), FieldObjectPreviewRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
