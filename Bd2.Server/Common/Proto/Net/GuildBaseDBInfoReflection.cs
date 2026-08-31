using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildBaseDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0d1aWxkQmFzZURCSW5mby5wcm90bxIJcHJvdG8ubmV0IlwKD0d1aWxkQmFzZURCSW5mbxIKCgJpZBgBIAEoAxIMCgRuYW1lGAIgASgJEgwKBGljb24YAyABKAUSEgoKaWNvbl9jb2xvchgEIAEoCRINCgVncmFkZRgFIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildBaseDBInfo), GuildBaseDBInfo.Parser, new string[5] { "Id", "Name", "Icon", "IconColor", "Grade" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
