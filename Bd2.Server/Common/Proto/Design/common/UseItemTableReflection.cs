using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class UseItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL1VzZUl0ZW1UYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiL0AQoMVXNlSXRlbVRhYmxl" + "Eg0KBWdyYWRlGAEgASgFEhYKDmljb25TcHJpdGVOYW1lGAIgASgJEgoKAmlk" + "GAMgASgFEhUKDWl0ZW1BY3F1aXJlSWQYBCADKAUSGgoSaXRlbURlc2NOYW1l" + "VGV4dElkGAUgASgFEhYKDml0ZW1OYW1lVGV4dElkGAYgASgFEhkKEWl0ZW1T" + "dWJOYW1lVGV4dElkGAcgASgFEhAKCG5vdFRyYXNoGAggASgFEhAKCHNvcnRU" + "eXBlGAkgASgFEhIKCnN0YWNrQ291bnQYCiABKAUSEwoLdXNlSXRlbVR5cGUY" + "CyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2ln" + "bi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UseItemTable), UseItemTable.Parser, new string[11]
		{
			"Grade", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescNameTextId", "ItemNameTextId", "ItemSubNameTextId", "NotTrash", "SortType", "StackCount",
			"UseItemType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
