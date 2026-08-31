using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L01pbmlHYW1lRmllbGRJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkIKGE1pbmlHYW1lRmllbGRJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSGQoRZXZlbnRfc2NoZWR1bGVfaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldInfoRequest), MiniGameFieldInfoRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
