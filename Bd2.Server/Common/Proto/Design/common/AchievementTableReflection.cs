using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AchievementTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvQWNoaWV2ZW1lbnRUYWJsZV9fX+yXheyggS9BY2hpZXZl" + "bWVudFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoMDChBBY2hp" + "ZXZlbWVudFRhYmxlEhgKEGNvbmRpdGlvblN1YlR5cGUYASABKAUSFQoNY29u" + "ZGl0aW9uVHlwZRgCIAEoBRIWCg5jb25kaXRpb25WYWx1ZRgDIAEoARIVCg1j" + "b250ZW50c0dyb3VwGAQgASgFEhcKD2Rlc2NMb2NhbFRleHRJZBgFIAEoBRIP" + "CgdldmVudElkGAYgASgFEhEKCWV2ZW50VHlwZRgHIAEoBRILCgNleHAYCCAB" + "KAUSDwoHZ3JvdXBJZBgJIAEoBRIQCghpY29uTmFtZRgKIAEoCRIKCgJpZBgL" + "IAEoBRIXCg9yZXdhcmRJdGVtQ291bnQYDCABKAUSFAoMcmV3YXJkSXRlbUlk" + "GA0gASgFEhYKDnJld2FyZEl0ZW1UeXBlGA4gASgFEhIKCnNob3J0Q3V0SWQY" + "DyABKAUSDwoHdGFiVHlwZRgQIAEoBRIYChB0aXRsZUxvY2FsVGV4dElkGBEg" + "ASgFEhAKCHVzZUJsaW5kGBIgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementTable), AchievementTable.Parser, new string[18]
		{
			"ConditionSubType", "ConditionType", "ConditionValue", "ContentsGroup", "DescLocalTextId", "EventId", "EventType", "Exp", "GroupId", "IconName",
			"Id", "RewardItemCount", "RewardItemId", "RewardItemType", "ShortCutId", "TabType", "TitleLocalTextId", "UseBlind"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
