using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MissionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvTWlzc2lvblRhYmxlX19f66+47IWYL01pc3Npb25UYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLKAwoMTWlzc2lvblRhYmxl" + "EhgKEGNvbmRpdGlvblN1YlR5cGUYASABKAUSHgoWY29uZGl0aW9uU3ViVHlw" + "ZVBhcmFtcxgCIAMoBRIVCg1jb25kaXRpb25UeXBlGAMgASgFEhYKDmNvbmRp" + "dGlvblZhbHVlGAQgASgFEhcKD2Rlc2NMb2NhbFRleHRJZBgFIAEoBRIPCgdn" + "cm91cElkGAYgASgFEhEKCWdyb3VwVHlwZRgHIAEoBRIKCgJpZBgIIAEoBRIj" + "Chtpc0NvbmRpdGlvblN1YlR5cGVNb3JlQ2hlY2sYCSABKAUSEwoLaXNIaWdo" + "bGlnaHQYCiABKAUSFwoPbG9ja0xvY2FsVGV4dElkGAsgASgFEg8KB3Bhc3NF" + "eHAYDCABKAUSEwoLcmV3YXJkQ291bnQYDSABKAUSEAoIcmV3YXJkSWQYDiAB" + "KAUSEgoKcmV3YXJkVHlwZRgPIAEoBRISCgpzaG9ydEN1dElkGBAgASgFEg4K" + "BnNvcnRJZBgRIAEoBRIYChB0aXRsZUxvY2FsVGV4dElkGBIgASgFEhQKDHVu" + "bG9ja1BhY2tJZBgTIAEoBRIVCg11bmxvY2tRdWVzdElkGBQgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionTable), MissionTable.Parser, new string[20]
		{
			"ConditionSubType", "ConditionSubTypeParams", "ConditionType", "ConditionValue", "DescLocalTextId", "GroupId", "GroupType", "Id", "IsConditionSubTypeMoreCheck", "IsHighlight",
			"LockLocalTextId", "PassExp", "RewardCount", "RewardId", "RewardType", "ShortCutId", "SortId", "TitleLocalTextId", "UnlockPackId", "UnlockQuestId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
