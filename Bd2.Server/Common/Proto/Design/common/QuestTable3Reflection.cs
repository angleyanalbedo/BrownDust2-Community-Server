using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestTable3Reflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdFRhYmxl" + "My5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKqCwoLUXVlc3RUYWJsZTMS" + "GAoQYWNjZXB0Q2luZW1hTmFtZRgBIAEoCRITCgthY2NlcHROcGNJZBgCIAEo" + "BRIYChBhY2NlcHRUdXRvcmlhbElkGAMgASgFEhMKC2NoYXJHcm91cElkGAQg" + "ASgFEhEKCWNsZWFyVGltZRgFIAEoBRIUCgxjb2xsZWN0aW9uSWQYBiADKAUS" + "GgoSY29tcGxldGVDaW5lbWFOYW1lGAcgASgJEhUKDWNvbXBsZXRlTnBjSWQY" + "CCABKAUSGgoSY29tcGxldGVUdXRvcmlhbElkGAkgASgFEhYKDmNvbmRpdGlv" + "bkNvdW50GAogASgFEhUKDWNvbmRpdGlvblR5cGUYCyABKAUSEAoIZGVja0xp" + "c3QYDCADKAUSFAoMZGlzcGxheU1hcElkGA0gASgFEhoKEmRpc3BsYXlSZXdh" + "cmRDb3VudBgOIAMoBRIbChNkaXNwbGF5UmV3YXJkQ291bnQxGA8gAygFEhsK" + "E2Rpc3BsYXlSZXdhcmRDb3VudDIYECADKAUSGwoTZGlzcGxheVJld2FyZENv" + "dW50MxgRIAMoBRIbChNkaXNwbGF5UmV3YXJkQ291bnQ0GBIgAygFEhcKD2Rp" + "c3BsYXlSZXdhcmRJZBgTIAMoBRIYChBkaXNwbGF5UmV3YXJkSWQxGBQgAygF" + "EhgKEGRpc3BsYXlSZXdhcmRJZDIYFSADKAUSGAoQZGlzcGxheVJld2FyZElk" + "MxgWIAMoBRIYChBkaXNwbGF5UmV3YXJkSWQ0GBcgAygFEhkKEWRpc3BsYXlS" + "ZXdhcmRUeXBlGBggAygFEhoKEmRpc3BsYXlSZXdhcmRUeXBlMRgZIAMoBRIa" + "ChJkaXNwbGF5UmV3YXJkVHlwZTIYGiADKAUSGgoSZGlzcGxheVJld2FyZFR5" + "cGUzGBsgAygFEhoKEmRpc3BsYXlSZXdhcmRUeXBlNBgcIAMoBRIXCg9naXZl" + "UXVlc3RJdGVtSWQYHSADKAUSCgoCaWQYHiABKAUSHAoUaXNEaXNhYmxlSW50" + "ZXJhY3Rpb24YHyABKAUSGgoSaXNEaXNhYmxlUXVlc3RNYXJrGCAgASgFEhIK" + "Cm1hZ2ljVmFsdWUYISADKAUSDQoFbWFwSWQYIiABKAUSEwoLbmV4dFF1ZXN0" + "SWQYIyABKAUSDgoGcGFja0lkGCQgASgFEhQKDHByaW9yUXVlc3RJZBglIAEo" + "BRIdChVwcm9sb2dTa2lwUXVlc3RUZXh0SWQYJiABKAUSIQoZcXVlc3RDb25k" + "aXRpb25RdWVzdFRleHRJZBgnIAEoBRIcChRxdWVzdERlc2NRdWVzdFRleHRJ" + "ZBgoIAEoBRIcChRxdWVzdE5hbWVRdWVzdFRleHRJZBgpIAEoBRIcChRxdWVz" + "dFNraXBRdWVzdFRleHRJZBgqIAEoBRIcChRyZXB1dGF0aW9uQ29tcGxldGVJ" + "ZBgrIAEoBRITCgtyZXdhcmRDb3VudBgsIAMoBRIUCgxyZXdhcmRDb3VudDEY" + "LSADKAUSFAoMcmV3YXJkQ291bnQyGC4gAygFEhQKDHJld2FyZENvdW50Mxgv" + "IAMoBRIUCgxyZXdhcmRDb3VudDQYMCADKAUSEAoIcmV3YXJkSWQYMSADKAUS" + "EQoJcmV3YXJkSWQxGDIgAygFEhEKCXJld2FyZElkMhgzIAMoBRIRCglyZXdh" + "cmRJZDMYNCADKAUSEQoJcmV3YXJkSWQ0GDUgAygFEhIKCnJld2FyZFR5cGUY" + "NiADKAUSEwoLcmV3YXJkVHlwZTEYNyADKAUSEwoLcmV3YXJkVHlwZTIYOCAD" + "KAUSEwoLcmV3YXJkVHlwZTMYOSADKAUSEwoLcmV3YXJkVHlwZTQYOiADKAUS" + "GgoSdGltZWxpbmVTdGFydE1hcElkGDsgASgFEgwKBHR5cGUYPCABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestTable3), QuestTable3.Parser, new string[60]
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
