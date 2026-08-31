using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L01haWxJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ik8KD01haWxJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSGQoRc3RhcnRfaW52ZW5faW5kZXgYAiABKAMSFAoMc2VsZWN0X2NvdW50GAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailInfoRequest), MailInfoRequest.Parser, new string[3] { "Seq", "StartInvenIndex", "SelectCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
