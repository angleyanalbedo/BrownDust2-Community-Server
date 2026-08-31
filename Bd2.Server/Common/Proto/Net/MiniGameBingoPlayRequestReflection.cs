using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBingoPlayRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L01pbmlHYW1lQmluZ29QbGF5UmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8igwEKGE1pbmlHYW1l" + "QmluZ29QbGF5UmVxdWVzdBILCgNzZXEYASABKAUSGQoRZXZlbnRfc2NoZWR1" + "bGVfaWQYAiABKAUSKwoMY29uc3VtZV9pdGVtGAMgAygLMhUucHJvdG8ubmV0" + "Lkl0ZW1EQkluZm8SEgoKcGxheV9jb3VudBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoPlayRequest), MiniGameBingoPlayRequest.Parser, new string[4] { "Seq", "EventScheduleId", "ConsumeItem", "PlayCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
