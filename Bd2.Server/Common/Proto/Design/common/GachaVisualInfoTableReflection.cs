using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaVisualInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhVmlzdWFsSW5m" + "b1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIp4BChRHYWNoYVZp" + "c3VhbEluZm9UYWJsZRIKCgJpZBgBIAEoBRIZChFtZXJjaGFudElsdXN0TmFt" + "ZRgCIAEoCRIaChJtZXJjaGFudE5hbWVUZXh0SUQYAyABKAUSGgoSbWVyY2hh" + "bnRUYWxrVGV4dElEGAQgASgFEgwKBHR5cGUYBSABKAUSGQoRdm9pY2VSZXNv" + "dXJjZU5hbWUYBiABKAlCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaVisualInfoTable), GachaVisualInfoTable.Parser, new string[6] { "Id", "MerchantIlustName", "MerchantNameTextID", "MerchantTalkTextID", "Type", "VoiceResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
