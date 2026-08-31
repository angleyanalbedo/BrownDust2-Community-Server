using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PassBuyTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvU2Vhc29uUGFzc1RhYmxlX19f7Iuc7KaM7Yyo7IqkL1Bh" + "c3NCdXlUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLHAQoMUGFz" + "c0J1eVRhYmxlEhQKDGJ1eUl0ZW1Db3VudBgBIAEoBRIRCglidXlJdGVtSWQY" + "AiABKAUSEwoLYnV5SXRlbVR5cGUYAyABKAUSDwoHZ3JvdXBJZBgEIAEoBRIK" + "CgJpZBgFIAEoBRITCgtyZXdhcmRDb3VudBgGIAMoBRIQCghyZXdhcmRJZBgH" + "IAMoBRISCgpyZXdhcmRUeXBlGAggAygFEgwKBHR5cGUYCSABKAUSEwoLdW5s" + "b2NrTGV2ZWwYCiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassBuyTable), PassBuyTable.Parser, new string[10] { "BuyItemCount", "BuyItemId", "BuyItemType", "GroupId", "Id", "RewardCount", "RewardId", "RewardType", "Type", "UnlockLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
