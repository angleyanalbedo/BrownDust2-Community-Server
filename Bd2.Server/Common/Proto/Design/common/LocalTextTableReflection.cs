using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class LocalTextTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvVGV4dFRhYmxlX19f7YWN7Iqk7Yq4L0xvY2FsVGV4dFRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uInwKDkxvY2FsVGV4dFRh" + "YmxlEgwKBGRhdGUYASABKAkSCgoCaWQYAiABKAUSDAoEdGV4dBgDIAEoCRIP" + "Cgd0ZXh0X2NuGAQgASgJEg8KB3RleHRfZW4YBSABKAkSDwoHdGV4dF9qcBgG" + "IAEoCRIPCgd0ZXh0X3R3GAcgASgJQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LocalTextTable), LocalTextTable.Parser, new string[7] { "Date", "Id", "Text", "TextCn", "TextEn", "TextJp", "TextTw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
