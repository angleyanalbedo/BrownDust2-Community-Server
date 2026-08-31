using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentRankTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "UmFua1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uImwKEkVxdWlw" + "bWVudFJhbmtUYWJsZRIPCgdncm91cElkGAEgASgFEhMKC2dyb3d0aFBvaW50" + "GAIgAygFEgoKAmlkGAMgASgFEhEKCXJhbmtSYXRpbxgEIAMoAhIRCglyYW5r" + "VmFsdWUYBSADKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentRankTable), EquipmentRankTable.Parser, new string[5] { "GroupId", "GrowthPoint", "Id", "RankRatio", "RankValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
