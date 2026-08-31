using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLShopTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFNob3BU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiK8AQoLUkxTaG9wVGFi" + "bGUSIQoZaGF2ZUNoYXJDb3N0dW1lU2xvdE9wdGlvbhgBIAMoBRIKCgJpZBgC" + "IAEoBRIXCg9yZXJvbGxFeHBlbnNpdmUYAyABKAUSGAoQcmVyb2xsTmFtZVRl" + "eHRJZBgEIAEoBRITCgtyZXJvbGxQcmljZRgFIAEoBRIeChZzZWxsUmVsaWND" + "aG9pY2VUYWJsZUlkGAYgASgFEhYKDnNlbGxSZWxpY0NvdW50GAcgASgFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLShopTable), RLShopTable.Parser, new string[7] { "HaveCharCostumeSlotOption", "Id", "RerollExpensive", "RerollNameTextId", "RerollPrice", "SellRelicChoiceTableId", "SellRelicCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
