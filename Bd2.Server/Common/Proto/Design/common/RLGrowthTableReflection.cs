using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLGrowthTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEdyb3d0" + "aFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIt8BCg1STEdyb3d0" + "aFRhYmxlEg8KB2dyb3VwSWQYASABKAUSHQoVZ3Jvd3RoRGVzY0xvY2FsVGV4" + "dElkGAIgASgFEhIKCmdyb3d0aEljb24YAyABKAkSHQoVZ3Jvd3RoTmFtZUxv" + "Y2FsVGV4dElkGAQgASgFEhIKCmdyb3d0aFR5cGUYBSABKAUSEwoLZ3Jvd3Ro" + "VmFsdWUYBiABKAESCgoCaWQYByABKAUSEgoKcHJpY2VDb3VudBgIIAEoBRIP" + "CgdwcmljZUlkGAkgASgFEhEKCXByaWNlVHlwZRgKIAEoBUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLGrowthTable), RLGrowthTable.Parser, new string[10] { "GroupId", "GrowthDescLocalTextId", "GrowthIcon", "GrowthNameLocalTextId", "GrowthType", "GrowthValue", "Id", "PriceCount", "PriceId", "PriceType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
