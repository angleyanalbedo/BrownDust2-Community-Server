using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameCompleteRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL01pbmlHYW1l" + "Q29tcGxldGVSZXdhcmRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biKYAQobTWluaUdhbWVDb21wbGV0ZVJld2FyZFRhYmxlEhUKDWNvbXBsZXRl" + "Q291bnQYASABKAUSDwoHZ3JvdXBJZBgCIAEoBRIKCgJpZBgDIAEoBRIXCg9y" + "ZXdhcmRJdGVtQ291bnQYBCABKAUSFAoMcmV3YXJkSXRlbUlkGAUgASgFEhYK" + "DnJld2FyZEl0ZW1UeXBlGAYgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameCompleteRewardTable), MiniGameCompleteRewardTable.Parser, new string[6] { "CompleteCount", "GroupId", "Id", "RewardItemCount", "RewardItemId", "RewardItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
