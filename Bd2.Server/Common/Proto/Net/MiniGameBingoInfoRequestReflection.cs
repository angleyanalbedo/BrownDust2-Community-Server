using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBingoInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L01pbmlHYW1lQmluZ29JbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkIKGE1pbmlHYW1lQmluZ29JbmZvUmVxdWVzdBILCgNzZXEYASABKAUSGQoRZXZlbnRfc2NoZWR1bGVfaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoInfoRequest), MiniGameBingoInfoRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
