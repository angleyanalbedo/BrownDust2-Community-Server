using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestTable14Reflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdFRhYmxl" + "MTQucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iqwsKDFF1ZXN0VGFibGUx" + "NBIYChBhY2NlcHRDaW5lbWFOYW1lGAEgASgJEhMKC2FjY2VwdE5wY0lkGAIg" + "ASgFEhgKEGFjY2VwdFR1dG9yaWFsSWQYAyABKAUSEwoLY2hhckdyb3VwSWQY" + "BCABKAUSEQoJY2xlYXJUaW1lGAUgASgFEhQKDGNvbGxlY3Rpb25JZBgGIAMo" + "BRIaChJjb21wbGV0ZUNpbmVtYU5hbWUYByABKAkSFQoNY29tcGxldGVOcGNJ" + "ZBgIIAEoBRIaChJjb21wbGV0ZVR1dG9yaWFsSWQYCSABKAUSFgoOY29uZGl0" + "aW9uQ291bnQYCiABKAUSFQoNY29uZGl0aW9uVHlwZRgLIAEoBRIQCghkZWNr" + "TGlzdBgMIAMoBRIUCgxkaXNwbGF5TWFwSWQYDSABKAUSGgoSZGlzcGxheVJl" + "d2FyZENvdW50GA4gAygFEhsKE2Rpc3BsYXlSZXdhcmRDb3VudDEYDyADKAUS" + "GwoTZGlzcGxheVJld2FyZENvdW50MhgQIAMoBRIbChNkaXNwbGF5UmV3YXJk" + "Q291bnQzGBEgAygFEhsKE2Rpc3BsYXlSZXdhcmRDb3VudDQYEiADKAUSFwoP" + "ZGlzcGxheVJld2FyZElkGBMgAygFEhgKEGRpc3BsYXlSZXdhcmRJZDEYFCAD" + "KAUSGAoQZGlzcGxheVJld2FyZElkMhgVIAMoBRIYChBkaXNwbGF5UmV3YXJk" + "SWQzGBYgAygFEhgKEGRpc3BsYXlSZXdhcmRJZDQYFyADKAUSGQoRZGlzcGxh" + "eVJld2FyZFR5cGUYGCADKAUSGgoSZGlzcGxheVJld2FyZFR5cGUxGBkgAygF" + "EhoKEmRpc3BsYXlSZXdhcmRUeXBlMhgaIAMoBRIaChJkaXNwbGF5UmV3YXJk" + "VHlwZTMYGyADKAUSGgoSZGlzcGxheVJld2FyZFR5cGU0GBwgAygFEhcKD2dp" + "dmVRdWVzdEl0ZW1JZBgdIAMoBRIKCgJpZBgeIAEoBRIcChRpc0Rpc2FibGVJ" + "bnRlcmFjdGlvbhgfIAEoBRIaChJpc0Rpc2FibGVRdWVzdE1hcmsYICABKAUS" + "EgoKbWFnaWNWYWx1ZRghIAMoBRINCgVtYXBJZBgiIAEoBRITCgtuZXh0UXVl" + "c3RJZBgjIAEoBRIOCgZwYWNrSWQYJCABKAUSFAoMcHJpb3JRdWVzdElkGCUg" + "ASgFEh0KFXByb2xvZ1NraXBRdWVzdFRleHRJZBgmIAEoBRIhChlxdWVzdENv" + "bmRpdGlvblF1ZXN0VGV4dElkGCcgASgFEhwKFHF1ZXN0RGVzY1F1ZXN0VGV4" + "dElkGCggASgFEhwKFHF1ZXN0TmFtZVF1ZXN0VGV4dElkGCkgASgFEhwKFHF1" + "ZXN0U2tpcFF1ZXN0VGV4dElkGCogASgFEhwKFHJlcHV0YXRpb25Db21wbGV0" + "ZUlkGCsgASgFEhMKC3Jld2FyZENvdW50GCwgAygFEhQKDHJld2FyZENvdW50" + "MRgtIAMoBRIUCgxyZXdhcmRDb3VudDIYLiADKAUSFAoMcmV3YXJkQ291bnQz" + "GC8gAygFEhQKDHJld2FyZENvdW50NBgwIAMoBRIQCghyZXdhcmRJZBgxIAMo" + "BRIRCglyZXdhcmRJZDEYMiADKAUSEQoJcmV3YXJkSWQyGDMgAygFEhEKCXJl" + "d2FyZElkMxg0IAMoBRIRCglyZXdhcmRJZDQYNSADKAUSEgoKcmV3YXJkVHlw" + "ZRg2IAMoBRITCgtyZXdhcmRUeXBlMRg3IAMoBRITCgtyZXdhcmRUeXBlMhg4" + "IAMoBRITCgtyZXdhcmRUeXBlMxg5IAMoBRITCgtyZXdhcmRUeXBlNBg6IAMo" + "BRIaChJ0aW1lbGluZVN0YXJ0TWFwSWQYOyABKAUSDAoEdHlwZRg8IAEoBUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestTable14), QuestTable14.Parser, new string[60]
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
