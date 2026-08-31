using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentGrowthTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "R3Jvd3RoVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ihQIKFEVx" + "dWlwbWVudEdyb3d0aFRhYmxlEhwKFGJyZWFrUmVzdWx0SXRlbUNvdW50GAEg" + "AygFEhkKEWJyZWFrUmVzdWx0SXRlbUlkGAIgAygFEhsKE2JyZWFrUmVzdWx0" + "SXRlbVR5cGUYAyADKAUSDwoHZ3JvdXBJZBgEIAEoBRITCgtncm93dGhQb2lu" + "dBgFIAEoBRIKCgJpZBgGIAEoBRIYChB1cGdyYWRlSXRlbUNvdW50GAcgAygF" + "EhUKDXVwZ3JhZGVJdGVtSWQYCCADKAUSFwoPdXBncmFkZUl0ZW1UeXBlGAkg" + "AygFEhsKE3VwZ3JhZGVTdWNjZXNzUmF0aW8YCiABKAFCREITUHJvdG8uRGVz" + "aWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5E" + "ZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentGrowthTable), EquipmentGrowthTable.Parser, new string[10] { "BreakResultItemCount", "BreakResultItemId", "BreakResultItemType", "GroupId", "GrowthPoint", "Id", "UpgradeItemCount", "UpgradeItemId", "UpgradeItemType", "UpgradeSuccessRatio" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
