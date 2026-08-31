using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SelectPlatformOtherDataRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXF1ZXN0L1NlbGVjdFBsYXRmb3JtT3RoZXJEYXRhUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkAKHlNlbGVjdFBsYXRmb3JtT3RoZXJEYXRhUmVxdWVzdBILCgNzZXEYASABKAUSEQoJbWVtYmVyX2lkGAIgASgJYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SelectPlatformOtherDataRequest), SelectPlatformOtherDataRequest.Parser, new string[2] { "Seq", "MemberId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
