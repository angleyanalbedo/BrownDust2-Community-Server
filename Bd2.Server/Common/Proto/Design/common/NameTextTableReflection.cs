using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class NameTextTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvVGV4dFRhYmxlX19f7YWN7Iqk7Yq4L05hbWVUZXh0VGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iewoNTmFtZVRleHRUYWJs" + "ZRIMCgRkYXRlGAEgASgJEgoKAmlkGAIgASgFEgwKBHRleHQYAyABKAkSDwoH" + "dGV4dF9jbhgEIAEoCRIPCgd0ZXh0X2VuGAUgASgJEg8KB3RleHRfanAYBiAB" + "KAkSDwoHdGV4dF90dxgHIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFa" + "FS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NameTextTable), NameTextTable.Parser, new string[7] { "Date", "Id", "Text", "TextCn", "TextEn", "TextJp", "TextTw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
