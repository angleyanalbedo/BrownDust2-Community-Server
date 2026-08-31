using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventStoryGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudFN0" + "b3J5R3JvdXBUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJEChhQ" + "YWNrRXZlbnRTdG9yeUdyb3VwVGFibGUSCgoCaWQYASABKAUSHAoUc3RvcnlO" + "YW1lTG9jYWxUZXh0SWQYAiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblAB" + "WhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9u" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryGroupTable), PackEventStoryGroupTable.Parser, new string[2] { "Id", "StoryNameLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
