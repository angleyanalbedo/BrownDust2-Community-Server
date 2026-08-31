using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0VxdWlwUHJlc2V0REJJbmZvLnByb3RvEglwcm90by5uZXQa" + "IUNvbW1vbnMvRXF1aXBQcmVzZXRJdGVtSW5mby5wcm90byKkAQoRRXF1aXBQ" + "cmVzZXREQkluZm8SEwoLcHJlc2V0X25hbWUYASABKAkSDAoEc2xvdBgCIAEo" + "BRIaChJwcmVzZXRfcmVzb3VyY2VfaWQYAyABKAUSHQoVcHJlc2V0X3Jlc291" + "cmNlX2NvbG9yGAQgASgFEjEKCWl0ZW1faW5mbxgFIAMoCzIeLnByb3RvLm5l" + "dC5FcXVpcFByZXNldEl0ZW1JbmZvYgZwcm90bzM="), new FileDescriptor[1] { EquipPresetItemInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetDBInfo), EquipPresetDBInfo.Parser, new string[5] { "PresetName", "Slot", "PresetResourceId", "PresetResourceColor", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
