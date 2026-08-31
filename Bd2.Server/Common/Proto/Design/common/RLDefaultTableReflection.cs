using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STERlZmF1" + "bHRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiL8BQoOUkxEZWZh" + "dWx0VGFibGUSEAoIYm9zc1Jvb20YASADKAUSEgoKY2hhckdyb3d0aBgCIAEo" + "BRIRCgljaGFyTGV2ZWwYAyABKAUSGgoSY29zdHVtZVNsb3QxT3B0aW9uGAQg" + "ASgFEhoKEmNvc3R1bWVTbG90Mk9wdGlvbhgFIAEoBRIaChJjb3N0dW1lU2xv" + "dDNPcHRpb24YBiABKAUSGgoSY29zdHVtZVNsb3Q0T3B0aW9uGAcgASgFEhcK" + "D2VuZW15U3RhdHVzUmF0ZRgIIAEoARIVCg1lbnRyeUJ1eVByaWNlGAkgASgF" + "EhIKCmZsb29yQ291bnQYCiABKAUSDwoHZmxvb3JJZBgLIAEoBRIVCg1naXZl" + "VXBQZW5hbHR5GAwgASgBEgoKAmlkGA0gASgFEhAKCGludGVyZXN0GA4gASgB" + "EhYKDm1lbWJlckNoYW5nZVNQGA8gASgFEhoKEm9ic2lkaWFuQ2hhbmdlUmF0" + "ZRgQIAEoARIYChByb2d1ZWxpa2VBcENvdW50GBEgASgFEhkKEXJvZ3VlbGlr" + "ZUN1cnJlbmN5GBIgASgFEh8KF3JvZ3VlbGlrZUdyb3d0aEN1cnJlbmN5GBMg" + "ASgFEhEKCXJvb21SYXRpbxgUIAEoBRIdChVzZWFzb25EZWZhdWx0TG9zdEdv" + "bGQYFSABKAUSHQoVc2Vhc29uRGVmYXVsdE9ic2lkaWFuGBYgASgFEhwKFHNo" + "b3BDaGFyQ29zdHVtZVByaWNlGBcgASgFEhgKEHNob3BEaXNjb3VudFJhdGUY" + "GCABKAESFQoNc2hvcEhlYWxQcmljZRgZIAEoBRIUCgxzaG9wSGVhbFJhdGUY" + "GiABKAUSGwoTc2hvcFJlcm9sbEV4cGVuc2l2ZRgbIAEoBRIXCg9zaG9wUmVy" + "b2xsUHJpY2UYHCABKAUSGQoRc3RhcnRDb3N0dW1lQ291bnQYHSABKAUSEQoJ" + "c3RhcnRHb2xkGB4gASgFEhMKC3N0YXJ0UmVyb2xsGB8gASgFQkRCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJv" + "dG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLDefaultTable), RLDefaultTable.Parser, new string[31]
		{
			"BossRoom", "CharGrowth", "CharLevel", "CostumeSlot1Option", "CostumeSlot2Option", "CostumeSlot3Option", "CostumeSlot4Option", "EnemyStatusRate", "EntryBuyPrice", "FloorCount",
			"FloorId", "GiveUpPenalty", "Id", "Interest", "MemberChangeSP", "ObsidianChangeRate", "RoguelikeApCount", "RoguelikeCurrency", "RoguelikeGrowthCurrency", "RoomRatio",
			"SeasonDefaultLostGold", "SeasonDefaultObsidian", "ShopCharCostumePrice", "ShopDiscountRate", "ShopHealPrice", "ShopHealRate", "ShopRerollExpensive", "ShopRerollPrice", "StartCostumeCount", "StartGold",
			"StartReroll"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
