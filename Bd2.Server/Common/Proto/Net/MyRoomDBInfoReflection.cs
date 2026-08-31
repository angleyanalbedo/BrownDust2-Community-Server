using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL015Um9vbURCSW5mby5wcm90bxIJcHJvdG8ubmV0GiRDb21t" + "b25zL015Um9vbUl0ZW1Qb3NpdGlvbkluZm8ucHJvdG8iagoMTXlSb29tREJJ" + "bmZvEgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAkSQAoVbXlfcm9vbV9wb3Np" + "dGlvbl9pbmZvGAMgAygLMiEucHJvdG8ubmV0Lk15Um9vbUl0ZW1Qb3NpdGlv" + "bkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { MyRoomItemPositionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomDBInfo), MyRoomDBInfo.Parser, new string[3] { "Id", "Name", "MyRoomPositionInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
