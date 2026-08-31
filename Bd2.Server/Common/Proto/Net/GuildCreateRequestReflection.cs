using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildCreateRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0d1aWxkQ3JlYXRlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhRDb21tb25zL0RlZmluZS5wcm90byKWAQoSR3VpbGRDcmVhdGVSZXF1ZXN0" + "EgsKA3NlcRgBIAEoBRIMCgRuYW1lGAIgASgJEgwKBGljb24YAyABKAUSEgoK" + "aWNvbl9jb2xvchgEIAEoCRIPCgdtZXNzYWdlGAUgASgJEjIKCWpvaW5fdHlw" + "ZRgGIAEoDjIfLnByb3RvLm5ldC5EZWZpbmVfR3VpbGRKb2luVHlwZWIGcHJv" + "dG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildCreateRequest), GuildCreateRequest.Parser, new string[6] { "Seq", "Name", "Icon", "IconColor", "Message", "JoinType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
