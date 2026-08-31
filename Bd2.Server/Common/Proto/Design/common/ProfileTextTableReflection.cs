using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ProfileTextTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvVGV4dFRhYmxlX19f7YWN7Iqk7Yq4L1Byb2ZpbGVUZXh0" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ifgoQUHJvZmlsZVRl" + "eHRUYWJsZRIMCgRkYXRlGAEgASgJEgoKAmlkGAIgASgFEgwKBHRleHQYAyAB" + "KAkSDwoHdGV4dF9jbhgEIAEoCRIPCgd0ZXh0X2VuGAUgASgJEg8KB3RleHRf" + "anAYBiABKAkSDwoHdGV4dF90dxgHIAEoCUJEQhNQcm90by5EZXNpZ24uY29t" + "bW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5j" + "b21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ProfileTextTable), ProfileTextTable.Parser, new string[7] { "Date", "Id", "Text", "TextCn", "TextEn", "TextJp", "TextTw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
