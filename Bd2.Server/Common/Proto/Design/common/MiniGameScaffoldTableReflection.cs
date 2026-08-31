using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameScaffoldTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL01pbmlHYW1l" + "U2NhZmZvbGRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJpChVN" + "aW5pR2FtZVNjYWZmb2xkVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgC" + "IAEoBRIRCglpdGVtQ291bnQYAyABKAUSDgoGaXRlbUlkGAQgASgFEhAKCGl0" + "ZW1UeXBlGAUgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90" + "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameScaffoldTable), MiniGameScaffoldTable.Parser, new string[5] { "GroupId", "Id", "ItemCount", "ItemId", "ItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
