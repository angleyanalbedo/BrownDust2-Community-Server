using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetCharInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0VxdWlwUHJlc2V0Q2hhckluZm8ucHJvdG8SCXByb3RvLm5l" + "dBofQ29tbW9ucy9FcXVpcFByZXNldERCSW5mby5wcm90byJiChNFcXVpcFBy" + "ZXNldENoYXJJbmZvEhgKEGNoYXJfaW52ZW5faW5kZXgYASABKAMSMQoLcHJl" + "c2V0X2luZm8YAiADKAsyHC5wcm90by5uZXQuRXF1aXBQcmVzZXREQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[1] { EquipPresetDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetCharInfo), EquipPresetCharInfo.Parser, new string[2] { "CharInvenIndex", "PresetInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
