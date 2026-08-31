using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdEl0ZW1U" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKOAQoOUXVlc3RJdGVt" + "VGFibGUSFgoOaWNvblNwcml0ZU5hbWUYASABKAkSCgoCaWQYAiABKAUSGgoS" + "aXRlbURlc2NOYW1lVGV4dElkGAMgASgFEhYKDml0ZW1OYW1lVGV4dElkGAQg" + "ASgFEhAKCG5vdFRyYXNoGAUgASgFEhIKCnN0YWNrQ291bnQYBiABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestItemTable), QuestItemTable.Parser, new string[6] { "IconSpriteName", "Id", "ItemDescNameTextId", "ItemNameTextId", "NotTrash", "StackCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
