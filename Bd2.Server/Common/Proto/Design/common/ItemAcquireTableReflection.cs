using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ItemAcquireTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9J" + "dGVtQWNxdWlyZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoIB" + "ChBJdGVtQWNxdWlyZVRhYmxlEhkKEWFjcXVpcmVEZXNjVGV4dElkGAEgASgF" + "EhcKD2FjcXVpcmVJY29uTmFtZRgCIAEoCRIaChJhY3F1aXJlVGl0bGVUZXh0" + "SWQYAyABKAUSCgoCaWQYBCABKAUSEgoKc2hvcnRDdXRJZBgFIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemAcquireTable), ItemAcquireTable.Parser, new string[5] { "AcquireDescTextId", "AcquireIconName", "AcquireTitleTextId", "Id", "ShortCutId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
