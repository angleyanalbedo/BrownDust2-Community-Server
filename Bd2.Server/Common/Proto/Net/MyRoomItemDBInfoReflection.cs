using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomItemDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL015Um9vbUl0ZW1EQkluZm8ucHJvdG8SCXByb3RvLm5ldCJVChBNeVJvb21JdGVtREJJbmZvEhMKC2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIgASgFEg0KBWNvdW50GAMgASgFEhEKCXVzZV9jb3VudBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemDBInfo), MyRoomItemDBInfo.Parser, new string[4] { "InvenIndex", "Id", "Count", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
