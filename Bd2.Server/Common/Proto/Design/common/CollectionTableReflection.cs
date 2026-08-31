using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CollectionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvQ29sbGVjdGlvblRhYmxlX19f7IiY7KeR7ZKIL0NvbGxl" + "Y3Rpb25UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLKAQoPQ29s" + "bGVjdGlvblRhYmxlEg0KBWdyYWRlGAEgASgFEhYKDmljb25TcHJpdGVOYW1l" + "GAIgASgJEgoKAmlkGAMgASgFEhUKDWl0ZW1BY3F1aXJlSWQYBCADKAUSGgoS" + "aXRlbURlc2NOYW1lVGV4dElkGAUgASgFEhYKDml0ZW1OYW1lVGV4dElkGAYg" + "ASgFEhkKEWl0ZW1TdWJOYW1lVGV4dElkGAcgASgFEhAKCG5vdFRyYXNoGAgg" + "ASgFEgwKBHR5cGUYCSABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUu" + "L1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CollectionTable), CollectionTable.Parser, new string[9] { "Grade", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescNameTextId", "ItemNameTextId", "ItemSubNameTextId", "NotTrash", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
