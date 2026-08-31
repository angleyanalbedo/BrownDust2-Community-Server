using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentOptionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "T3B0aW9uVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iwAEKFEVx" + "dWlwbWVudE9wdGlvblRhYmxlEhQKDGRlZmF1bHRWYWx1ZRgBIAEoARIQCghn" + "ZXRSYXRpbxgCIAEoBRIPCgdncm91cElkGAMgASgFEhMKC2dyb3d0aFZhbHVl" + "GAQgASgBEgoKAmlkGAUgASgFEhIKCmxldmVsVmFsdWUYBiADKAISEgoKcmFu" + "a1ZhbHVlMRgHIAMoAhISCgpyYW5rVmFsdWUyGAggAygCEhIKCnJhbmtWYWx1" + "ZTMYCSADKAJCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRl" + "c2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentOptionTable), EquipmentOptionTable.Parser, new string[9] { "DefaultValue", "GetRatio", "GroupId", "GrowthValue", "Id", "LevelValue", "RankValue1", "RankValue2", "RankValue3" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
