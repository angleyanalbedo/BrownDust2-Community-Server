using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeConceptInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkZjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVDb25jZXB0SW5mb1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29t" + "bW9uIuUFChdDb3N0dW1lQ29uY2VwdEluZm9UYWJsZRIYChBhZ2VQcm9maWxl" + "VGV4dElkGAEgASgFEiAKGGFzc29jaWF0aW9uUHJvZmlsZVRleHRJZBgCIAEo" + "BRIdChViaXJ0aERheVByb2ZpbGVUZXh0SWQYAyABKAUSIwobY3V0U2NlbmVE" + "aWFsb2dQcm9maWxlVGV4dElkGAQgAygFEicKH2N1dFNjZW5lRGlhbG9nVm9p" + "Y2VSZXNvdXJjZU5hbWUYBSADKAkSHAoUZGlzbGlrZVByb2ZpbGVUZXh0SWQY" + "BiABKAUSHQoVZmF2b3JpdGVQcm9maWxlVGV4dElkGAcgASgFEiIKGmdlbmVy" + "YWxEaWFsb2dQcm9maWxlVGV4dElkGAggAygFEiYKHmdlbmVyYWxEaWFsb2dW" + "b2ljZVJlc291cmNlTmFtZRgJIAMoCRIbChNoZWlnaHRQcm9maWxlVGV4dElk" + "GAogASgFEhoKEmhvYmJ5UHJvZmlsZVRleHRJZBgLIAEoBRIKCgJpZBgMIAEo" + "BRIdChVwcmVjaW91c1Byb2ZpbGVUZXh0SWQYDSABKAUSGwoTcnVtb3IxUHJv" + "ZmlsZVRleHRJZBgOIAEoBRIbChNydW1vcjJQcm9maWxlVGV4dElkGA8gASgF" + "EiAKGHNraWxsRGlhbG9nUHJvZmlsZVRleHRJZBgQIAMoBRIkChxza2lsbERp" + "YWxvZ1ZvaWNlUmVzb3VyY2VOYW1lGBEgAygJEhwKFHN1bW1hcnlQcm9maWxl" + "VGV4dElkGBIgASgFEiEKGXRhbGVudERpYWxvZ1Byb2ZpbGVUZXh0SWQYEyAD" + "KAUSJQoddGFsZW50RGlhbG9nVm9pY2VSZXNvdXJjZU5hbWUYFCADKAkSIgoa" + "dmljdG9yeURpYWxvZ1Byb2ZpbGVUZXh0SWQYFSADKAUSJgoedmljdG9yeURp" + "YWxvZ1ZvaWNlUmVzb3VyY2VOYW1lGBYgAygJQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeConceptInfoTable), CostumeConceptInfoTable.Parser, new string[22]
		{
			"AgeProfileTextId", "AssociationProfileTextId", "BirthDayProfileTextId", "CutSceneDialogProfileTextId", "CutSceneDialogVoiceResourceName", "DislikeProfileTextId", "FavoriteProfileTextId", "GeneralDialogProfileTextId", "GeneralDialogVoiceResourceName", "HeightProfileTextId",
			"HobbyProfileTextId", "Id", "PreciousProfileTextId", "Rumor1ProfileTextId", "Rumor2ProfileTextId", "SkillDialogProfileTextId", "SkillDialogVoiceResourceName", "SummaryProfileTextId", "TalentDialogProfileTextId", "TalentDialogVoiceResourceName",
			"VictoryDialogProfileTextId", "VictoryDialogVoiceResourceName"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
