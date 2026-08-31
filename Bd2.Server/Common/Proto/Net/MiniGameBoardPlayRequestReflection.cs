using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBoardPlayRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L01pbmlHYW1lQm9hcmRQbGF5UmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8ibwoYTWluaUdhbWVC" + "b2FyZFBsYXlSZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFldmVudF9zY2hlZHVs" + "ZV9pZBgCIAEoBRIrCgxjb25zdW1lX2l0ZW0YAyADKAsyFS5wcm90by5uZXQu" + "SXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBoardPlayRequest), MiniGameBoardPlayRequest.Parser, new string[3] { "Seq", "EventScheduleId", "ConsumeItem" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
