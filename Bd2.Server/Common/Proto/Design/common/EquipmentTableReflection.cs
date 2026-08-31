using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i4QMKDkVxdWlwbWVu" + "dFRhYmxlEg0KBWdyYWRlGAEgASgFEhUKDWdyb3d0aEdyb3VwSWQYAiABKAUS" + "FgoOaWNvblNwcml0ZU5hbWUYAyABKAkSCgoCaWQYBCABKAUSFQoNaXNNb25z" + "dGVySHVudBgFIAEoBRIVCg1pdGVtQWNxdWlyZUlkGAYgAygFEhoKEml0ZW1E" + "ZXNjTmFtZVRleHRJZBgHIAEoBRIWCg5pdGVtTmFtZVRleHRJZBgIIAEoBRIe" + "ChZpdGVtU3ViRGVzY0xvY2FsVGV4dElkGAkgASgFEhkKEW1haW5PcHRpb25H" + "cm91cElkGAogAygFEhAKCG1heExldmVsGAsgASgFEhAKCG5vdFRyYXNoGAwg" + "ASgFEhYKDm9wdGlvblJlcm9sbElkGA0gASgFEhsKE3ByaXZhdGVVbmlxdWVD" + "aGFySWQYDiABKAUSIgoacHJpdmF0ZVVuaXF1ZU9wdGlvbkdyb3VwSWQYDyAD" + "KAUSEwoLcXVhbGl0eVR5cGUYECABKAUSEwoLcmFua0dyb3VwSWQYESABKAUS" + "EAoIc2xvdFR5cGUYEiABKAUSGAoQc3ViT3B0aW9uR3JvdXBJZBgTIAMoBRIV" + "Cg11bmlxdWVFcXVpcElkGBQgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentTable), EquipmentTable.Parser, new string[20]
		{
			"Grade", "GrowthGroupId", "IconSpriteName", "Id", "IsMonsterHunt", "ItemAcquireId", "ItemDescNameTextId", "ItemNameTextId", "ItemSubDescLocalTextId", "MainOptionGroupId",
			"MaxLevel", "NotTrash", "OptionRerollId", "PrivateUniqueCharId", "PrivateUniqueOptionGroupId", "QualityType", "RankGroupId", "SlotType", "SubOptionGroupId", "UniqueEquipId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
