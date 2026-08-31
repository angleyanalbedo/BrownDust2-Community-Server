using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class InstantUseItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0luc3RhbnRVc2VJ" + "dGVtVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ilgEKE0luc3Rh" + "bnRVc2VJdGVtVGFibGUSCgoCaWQYASABKAUSGgoSaXRlbURlc2NOYW1lVGV4" + "dElkGAIgASgFEhYKDml0ZW1OYW1lVGV4dElkGAMgASgFEhYKDml0ZW1TcHJp" + "dGVOYW1lGAQgASgJEhkKEWl0ZW1TdWJOYW1lVGV4dElkGAUgASgFEgwKBHR5" + "cGUYBiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRl" + "c2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InstantUseItemTable), InstantUseItemTable.Parser, new string[6] { "Id", "ItemDescNameTextId", "ItemNameTextId", "ItemSpriteName", "ItemSubNameTextId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
