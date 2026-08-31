using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestTable1002Reflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdFRhYmxl" + "MTAwMi5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKtCwoOUXVlc3RUYWJs" + "ZTEwMDISGAoQYWNjZXB0Q2luZW1hTmFtZRgBIAEoCRITCgthY2NlcHROcGNJ" + "ZBgCIAEoBRIYChBhY2NlcHRUdXRvcmlhbElkGAMgASgFEhMKC2NoYXJHcm91" + "cElkGAQgASgFEhEKCWNsZWFyVGltZRgFIAEoBRIUCgxjb2xsZWN0aW9uSWQY" + "BiADKAUSGgoSY29tcGxldGVDaW5lbWFOYW1lGAcgASgJEhUKDWNvbXBsZXRl" + "TnBjSWQYCCABKAUSGgoSY29tcGxldGVUdXRvcmlhbElkGAkgASgFEhYKDmNv" + "bmRpdGlvbkNvdW50GAogASgFEhUKDWNvbmRpdGlvblR5cGUYCyABKAUSEAoI" + "ZGVja0xpc3QYDCADKAUSFAoMZGlzcGxheU1hcElkGA0gASgFEhoKEmRpc3Bs" + "YXlSZXdhcmRDb3VudBgOIAMoBRIbChNkaXNwbGF5UmV3YXJkQ291bnQxGA8g" + "AygFEhsKE2Rpc3BsYXlSZXdhcmRDb3VudDIYECADKAUSGwoTZGlzcGxheVJl" + "d2FyZENvdW50MxgRIAMoBRIbChNkaXNwbGF5UmV3YXJkQ291bnQ0GBIgAygF" + "EhcKD2Rpc3BsYXlSZXdhcmRJZBgTIAMoBRIYChBkaXNwbGF5UmV3YXJkSWQx" + "GBQgAygFEhgKEGRpc3BsYXlSZXdhcmRJZDIYFSADKAUSGAoQZGlzcGxheVJl" + "d2FyZElkMxgWIAMoBRIYChBkaXNwbGF5UmV3YXJkSWQ0GBcgAygFEhkKEWRp" + "c3BsYXlSZXdhcmRUeXBlGBggAygFEhoKEmRpc3BsYXlSZXdhcmRUeXBlMRgZ" + "IAMoBRIaChJkaXNwbGF5UmV3YXJkVHlwZTIYGiADKAUSGgoSZGlzcGxheVJl" + "d2FyZFR5cGUzGBsgAygFEhoKEmRpc3BsYXlSZXdhcmRUeXBlNBgcIAMoBRIX" + "Cg9naXZlUXVlc3RJdGVtSWQYHSADKAUSCgoCaWQYHiABKAUSHAoUaXNEaXNh" + "YmxlSW50ZXJhY3Rpb24YHyABKAUSGgoSaXNEaXNhYmxlUXVlc3RNYXJrGCAg" + "ASgFEhIKCm1hZ2ljVmFsdWUYISADKAUSDQoFbWFwSWQYIiABKAUSEwoLbmV4" + "dFF1ZXN0SWQYIyABKAUSDgoGcGFja0lkGCQgASgFEhQKDHByaW9yUXVlc3RJ" + "ZBglIAEoBRIdChVwcm9sb2dTa2lwUXVlc3RUZXh0SWQYJiABKAUSIQoZcXVl" + "c3RDb25kaXRpb25RdWVzdFRleHRJZBgnIAEoBRIcChRxdWVzdERlc2NRdWVz" + "dFRleHRJZBgoIAEoBRIcChRxdWVzdE5hbWVRdWVzdFRleHRJZBgpIAEoBRIc" + "ChRxdWVzdFNraXBRdWVzdFRleHRJZBgqIAEoBRIcChRyZXB1dGF0aW9uQ29t" + "cGxldGVJZBgrIAEoBRITCgtyZXdhcmRDb3VudBgsIAMoBRIUCgxyZXdhcmRD" + "b3VudDEYLSADKAUSFAoMcmV3YXJkQ291bnQyGC4gAygFEhQKDHJld2FyZENv" + "dW50MxgvIAMoBRIUCgxyZXdhcmRDb3VudDQYMCADKAUSEAoIcmV3YXJkSWQY" + "MSADKAUSEQoJcmV3YXJkSWQxGDIgAygFEhEKCXJld2FyZElkMhgzIAMoBRIR" + "CglyZXdhcmRJZDMYNCADKAUSEQoJcmV3YXJkSWQ0GDUgAygFEhIKCnJld2Fy" + "ZFR5cGUYNiADKAUSEwoLcmV3YXJkVHlwZTEYNyADKAUSEwoLcmV3YXJkVHlw" + "ZTIYOCADKAUSEwoLcmV3YXJkVHlwZTMYOSADKAUSEwoLcmV3YXJkVHlwZTQY" + "OiADKAUSGgoSdGltZWxpbmVTdGFydE1hcElkGDsgASgFEgwKBHR5cGUYPCAB" + "KAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5j" + "b21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestTable1002), QuestTable1002.Parser, new string[60]
		{
			"AcceptCinemaName", "AcceptNpcId", "AcceptTutorialId", "CharGroupId", "ClearTime", "CollectionId", "CompleteCinemaName", "CompleteNpcId", "CompleteTutorialId", "ConditionCount",
			"ConditionType", "DeckList", "DisplayMapId", "DisplayRewardCount", "DisplayRewardCount1", "DisplayRewardCount2", "DisplayRewardCount3", "DisplayRewardCount4", "DisplayRewardId", "DisplayRewardId1",
			"DisplayRewardId2", "DisplayRewardId3", "DisplayRewardId4", "DisplayRewardType", "DisplayRewardType1", "DisplayRewardType2", "DisplayRewardType3", "DisplayRewardType4", "GiveQuestItemId", "Id",
			"IsDisableInteraction", "IsDisableQuestMark", "MagicValue", "MapId", "NextQuestId", "PackId", "PriorQuestId", "PrologSkipQuestTextId", "QuestConditionQuestTextId", "QuestDescQuestTextId",
			"QuestNameQuestTextId", "QuestSkipQuestTextId", "ReputationCompleteId", "RewardCount", "RewardCount1", "RewardCount2", "RewardCount3", "RewardCount4", "RewardId", "RewardId1",
			"RewardId2", "RewardId3", "RewardId4", "RewardType", "RewardType1", "RewardType2", "RewardType3", "RewardType4", "TimelineStartMapId", "Type"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
