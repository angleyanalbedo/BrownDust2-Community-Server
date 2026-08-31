using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TalentSkillTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvVGFsZW50VGFibGVfX1/snqzriqXsiqTtgqwvVGFsZW50" + "U2tpbGxUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLAAgoQVGFs" + "ZW50U2tpbGxUYWJsZRIVCg1jYXRhbHlzdFZhbHVlGAEgASgFEhEKCWNsYXNz" + "VHlwZRgCIAEoBRIRCgljb3N0dW1lSWQYAyADKAUSDgoGZ2V0RXhwGAQgASgF" + "Eg8KB2dyb3VwSWQYBSABKAUSCgoCaWQYBiABKAUSEQoJcmVzZXRUeXBlGAcg" + "ASgFEiIKGnRhbGVudFNraWxsRGVzY0xvY2FsVGV4dElkGAggAygFEiEKGXRh" + "bGVudFNraWxsSWNvblNwcml0ZU5hbWUYCSABKAkSIgoadGFsZW50U2tpbGxO" + "YW1lTG9jYWxUZXh0SWQYCiADKAUSHQoVdGFsZW50U2tpbGxSZXB1dGF0aW9u" + "GAsgASgFEhIKCnRhcmdldFR5cGUYDCABKAUSEQoJdmFsdWVMaXN0GA0gAygC" + "QkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29t" + "bW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSkillTable), TalentSkillTable.Parser, new string[13]
		{
			"CatalystValue", "ClassType", "CostumeId", "GetExp", "GroupId", "Id", "ResetType", "TalentSkillDescLocalTextId", "TalentSkillIconSpriteName", "TalentSkillNameLocalTextId",
			"TalentSkillReputation", "TargetType", "ValueList"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
