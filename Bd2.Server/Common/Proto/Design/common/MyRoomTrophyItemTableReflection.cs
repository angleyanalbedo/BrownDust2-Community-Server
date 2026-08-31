using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MyRoomTrophyItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvTXlSb29tX19f66eI7J2066O4L015Um9vbVRyb3BoeUl0" + "ZW1UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKHAQoVTXlSb29t" + "VHJvcGh5SXRlbVRhYmxlEgoKAmlkGAEgASgFEhYKDml0ZW1TcHJpdGVOYW1l" + "GAIgASgJEhwKFG9iamVjdERlc2NOYW1lVGV4dElkGAMgASgFEhgKEG9iamVj" + "dE5hbWVUZXh0SWQYBCABKAUSEgoKcHJlZmFiTmFtZRgFIAEoCUJEQhNQcm90" + "by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1By" + "b3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomTrophyItemTable), MyRoomTrophyItemTable.Parser, new string[5] { "Id", "ItemSpriteName", "ObjectDescNameTextId", "ObjectNameTextId", "PrefabName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
