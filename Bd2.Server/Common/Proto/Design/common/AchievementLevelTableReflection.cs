using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AchievementLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvQWNoaWV2ZW1lbnRUYWJsZV9fX+yXheyggS9BY2hpZXZl" + "bWVudExldmVsVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ibwoV" + "QWNoaWV2ZW1lbnRMZXZlbFRhYmxlEgoKAmlkGAEgASgFEg8KB25lZWRFWFAY" + "AiABKAUSEwoLcmV3YXJkQ291bnQYAyADKAUSEAoIcmV3YXJkSWQYBCADKAUS" + "EgoKcmV3YXJkVHlwZRgFIAMoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFa" + "FS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementLevelTable), AchievementLevelTable.Parser, new string[5] { "Id", "NeedEXP", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
