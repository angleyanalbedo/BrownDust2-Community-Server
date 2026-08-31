using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RandomBoxTextTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvVGV4dFRhYmxlX19f7YWN7Iqk7Yq4L1JhbmRvbUJveFRl" + "eHRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKAAQoSUmFuZG9t" + "Qm94VGV4dFRhYmxlEgwKBGRhdGUYASABKAkSCgoCaWQYAiABKAUSDAoEdGV4" + "dBgDIAEoCRIPCgd0ZXh0X2NuGAQgASgJEg8KB3RleHRfZW4YBSABKAkSDwoH" + "dGV4dF9qcBgGIAEoCRIPCgd0ZXh0X3R3GAcgASgJQkRCE1Byb3RvLkRlc2ln" + "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz" + "aWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RandomBoxTextTable), RandomBoxTextTable.Parser, new string[7] { "Date", "Id", "Text", "TextCn", "TextEn", "TextJp", "TextTw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
