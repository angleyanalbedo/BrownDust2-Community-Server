using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AlchemyTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0FsY2hlbXlUYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKeAgoMQWxjaGVteVRhYmxl" + "EhcKD2FsY2hlbXlDYXRlZ29yeRgBIAEoBRIWCg5kaXNwbGF5R3JvdXBJZBgC" + "IAEoBRIYChBncm91cExvY2FsVGV4dElkGAMgASgFEgoKAmlkGAQgASgFEhkK" + "EW1hdGVyaWFsSXRlbUNvdW50GAUgAygFEhYKDm1hdGVyaWFsSXRlbUlkGAYg" + "AygFEhgKEG1hdGVyaWFsSXRlbVR5cGUYByADKAUSDgoGcGFja0lkGAggAygF" + "EhcKD3Jlc3VsdEl0ZW1Db3VudBgJIAEoBRIUCgxyZXN1bHRJdGVtSWQYCiAB" + "KAUSFgoOcmVzdWx0SXRlbVR5cGUYCyABKAUSEwoLdGFsZW50TGV2ZWwYDCAB" + "KAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5j" + "b21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AlchemyTable), AlchemyTable.Parser, new string[12]
		{
			"AlchemyCategory", "DisplayGroupId", "GroupLocalTextId", "Id", "MaterialItemCount", "MaterialItemId", "MaterialItemType", "PackId", "ResultItemCount", "ResultItemId",
			"ResultItemType", "TalentLevel"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
