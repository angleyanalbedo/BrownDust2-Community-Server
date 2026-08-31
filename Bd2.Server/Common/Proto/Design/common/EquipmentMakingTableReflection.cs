using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentMakingTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "TWFraW5nVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ilwIKFEVx" + "dWlwbWVudE1ha2luZ1RhYmxlEgoKAmlkGAEgASgFEhoKEml0ZW1EZXNMb2Nh" + "bFRleHRJZBgCIAEoBRIbChNpdGVtTmFtZUxvY2FsVGV4dElkGAMgASgFEhkK" + "EW1hdGVyaWFsSXRlbUNvdW50GAQgAygFEhYKDm1hdGVyaWFsSXRlbUlkGAUg" + "AygFEhgKEG1hdGVyaWFsSXRlbVR5cGUYBiADKAUSFwoPcmVzdWx0SXRlbUNv" + "dW50GAcgASgFEhQKDHJlc3VsdEl0ZW1JZBgIIAEoBRIWCg5yZXN1bHRJdGVt" + "VHlwZRgJIAEoBRIRCglzb3J0T3JkZXIYCiABKAUSEwoLdGFsZW50TGV2ZWwY" + "CyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2ln" + "bi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentMakingTable), EquipmentMakingTable.Parser, new string[11]
		{
			"Id", "ItemDesLocalTextId", "ItemNameLocalTextId", "MaterialItemCount", "MaterialItemId", "MaterialItemType", "ResultItemCount", "ResultItemId", "ResultItemType", "SortOrder",
			"TalentLevel"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
