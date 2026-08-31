using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomItemCostumeInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL015Um9vbUl0ZW1Db3N0dW1lSW5mby5wcm90bxIJcHJvdG8ubmV0IlMKFU15Um9vbUl0ZW1Db3N0dW1lSW5mbxITCgtpbnZlbl9pbmRleBgBIAEoAxIKCgJpZBgCIAEoBRIZChF1c2VfbXlfcm9vbV9jb3VudBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemCostumeInfo), MyRoomItemCostumeInfo.Parser, new string[3] { "InvenIndex", "Id", "UseMyRoomCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
