using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PassTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvU2Vhc29uUGFzc1RhYmxlX19f7Iuc7KaM7Yyo7IqkL1Bh" + "c3NUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKSAwoJUGFzc1Rh" + "YmxlEh0KFWJhbm5lckZvbnRMb2NhbFRleHRJZBgBIAEoBRIXCg9jb3JlUmV3" + "YXJkQ291bnQYAiABKAUSFAoMY29yZVJld2FyZElkGAMgASgFEhYKDmNvcmVS" + "ZXdhcmRUeXBlGAQgASgFEh4KFmV4cEV2ZW50TWlzc2lvbkdyb3VwSWQYBSAB" + "KAUSCgoCaWQYBiABKAUSFAoMaXNOZXdiaWVQYXNzGAcgASgFEhgKEGlzU2hv" + "d0NvcmVSZXdhcmQYCCABKAUSFgoObWFpbkJhbm5lck5hbWUYCSABKAkSFgoO" + "bmV3YmllUGFzc1N0ZXAYCiABKAUSGAoQcGFzc0xldmVsR3JvdXBJZBgLIAEo" + "BRIWCg5wYXNzTmFtZVRleHRJZBgMIAEoBRIQCghwYXNzVHlwZRgNIAEoBRIS" + "CgpwcmVmYWJOYW1lGA4gASgJEhQKDHNjaGVkdWxlVHlwZRgPIAEoBRIOCgZz" + "b3J0SWQYECABKAUSFQoNc3ViQmFubmVyTmFtZRgRIAEoCUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassTable), PassTable.Parser, new string[17]
		{
			"BannerFontLocalTextId", "CoreRewardCount", "CoreRewardId", "CoreRewardType", "ExpEventMissionGroupId", "Id", "IsNewbiePass", "IsShowCoreReward", "MainBannerName", "NewbiePassStep",
			"PassLevelGroupId", "PassNameTextId", "PassType", "PrefabName", "ScheduleType", "SortId", "SubBannerName"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
