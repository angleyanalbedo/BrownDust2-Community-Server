using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRecommendRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0d1aWxkUmVjb21tZW5kUmVxdWVzdC5wcm90bxIJcHJvdG8u" + "bmV0GhRDb21tb25zL0RlZmluZS5wcm90byKAAQoVR3VpbGRSZWNvbW1lbmRS" + "ZXF1ZXN0EgsKA3NlcRgBIAEoBRISCgpzZWFyY2hfbWluGAIgASgFEhIKCnNl" + "YXJjaF9tYXgYAyABKAUSMgoJam9pbl90eXBlGAQgASgOMh8ucHJvdG8ubmV0" + "LkRlZmluZV9HdWlsZEpvaW5UeXBlYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRecommendRequest), GuildRecommendRequest.Parser, new string[4] { "Seq", "SearchMin", "SearchMax", "JoinType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
