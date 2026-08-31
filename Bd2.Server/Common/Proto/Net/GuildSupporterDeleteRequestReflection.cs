using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterDeleteRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXF1ZXN0L0d1aWxkU3VwcG9ydGVyRGVsZXRlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ij4KG0d1aWxkU3VwcG9ydGVyRGVsZXRlUmVxdWVzdBILCgNzZXEYASABKAUSEgoKc2xvdF9pbmRleBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterDeleteRequest), GuildSupporterDeleteRequest.Parser, new string[2] { "Seq", "SlotIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
