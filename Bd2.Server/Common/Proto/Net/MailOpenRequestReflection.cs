using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailOpenRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L01haWxPcGVuUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjMKD01haWxPcGVuUmVxdWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiADKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailOpenRequest), MailOpenRequest.Parser, new string[2] { "Seq", "InvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
