using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSearchRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0d1aWxkU2VhcmNoUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ii8KEkd1aWxkU2VhcmNoUmVxdWVzdBILCgNzZXEYASABKAUSDAoEbmFtZRgCIAEoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSearchRequest), GuildSearchRequest.Parser, new string[2] { "Seq", "Name" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
