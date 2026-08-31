using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestTable11005Reflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdFRhYmxl" + "MTEwMDUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24irgsKD1F1ZXN0VGFi" + "bGUxMTAwNRIYChBhY2NlcHRDaW5lbWFOYW1lGAEgASgJEhMKC2FjY2VwdE5w" + "Y0lkGAIgASgFEhgKEGFjY2VwdFR1dG9yaWFsSWQYAyABKAUSEwoLY2hhckdy" + "b3VwSWQYBCABKAUSEQoJY2xlYXJUaW1lGAUgASgFEhQKDGNvbGxlY3Rpb25J" + "ZBgGIAMoBRIaChJjb21wbGV0ZUNpbmVtYU5hbWUYByABKAkSFQoNY29tcGxl" + "dGVOcGNJZBgIIAEoBRIaChJjb21wbGV0ZVR1dG9yaWFsSWQYCSABKAUSFgoO" + "Y29uZGl0aW9uQ291bnQYCiABKAUSFQoNY29uZGl0aW9uVHlwZRgLIAEoBRIQ" + "CghkZWNrTGlzdBgMIAMoBRIUCgxkaXNwbGF5TWFwSWQYDSABKAUSGgoSZGlz" + "cGxheVJld2FyZENvdW50GA4gAygFEhsKE2Rpc3BsYXlSZXdhcmRDb3VudDEY" + "DyADKAUSGwoTZGlzcGxheVJld2FyZENvdW50MhgQIAMoBRIbChNkaXNwbGF5" + "UmV3YXJkQ291bnQzGBEgAygFEhsKE2Rpc3BsYXlSZXdhcmRDb3VudDQYEiAD" + "KAUSFwoPZGlzcGxheVJld2FyZElkGBMgAygFEhgKEGRpc3BsYXlSZXdhcmRJ" + "ZDEYFCADKAUSGAoQZGlzcGxheVJld2FyZElkMhgVIAMoBRIYChBkaXNwbGF5" + "UmV3YXJkSWQzGBYgAygFEhgKEGRpc3BsYXlSZXdhcmRJZDQYFyADKAUSGQoR" + "ZGlzcGxheVJld2FyZFR5cGUYGCADKAUSGgoSZGlzcGxheVJld2FyZFR5cGUx" + "GBkgAygFEhoKEmRpc3BsYXlSZXdhcmRUeXBlMhgaIAMoBRIaChJkaXNwbGF5" + "UmV3YXJkVHlwZTMYGyADKAUSGgoSZGlzcGxheVJld2FyZFR5cGU0GBwgAygF" + "EhcKD2dpdmVRdWVzdEl0ZW1JZBgdIAMoBRIKCgJpZBgeIAEoBRIcChRpc0Rp" + "c2FibGVJbnRlcmFjdGlvbhgfIAEoBRIaChJpc0Rpc2FibGVRdWVzdE1hcmsY" + "ICABKAUSEgoKbWFnaWNWYWx1ZRghIAMoBRINCgVtYXBJZBgiIAEoBRITCgtu" + "ZXh0UXVlc3RJZBgjIAEoBRIOCgZwYWNrSWQYJCABKAUSFAoMcHJpb3JRdWVz" + "dElkGCUgASgFEh0KFXByb2xvZ1NraXBRdWVzdFRleHRJZBgmIAEoBRIhChlx" + "dWVzdENvbmRpdGlvblF1ZXN0VGV4dElkGCcgASgFEhwKFHF1ZXN0RGVzY1F1" + "ZXN0VGV4dElkGCggASgFEhwKFHF1ZXN0TmFtZVF1ZXN0VGV4dElkGCkgASgF" + "EhwKFHF1ZXN0U2tpcFF1ZXN0VGV4dElkGCogASgFEhwKFHJlcHV0YXRpb25D" + "b21wbGV0ZUlkGCsgASgFEhMKC3Jld2FyZENvdW50GCwgAygFEhQKDHJld2Fy" + "ZENvdW50MRgtIAMoBRIUCgxyZXdhcmRDb3VudDIYLiADKAUSFAoMcmV3YXJk" + "Q291bnQzGC8gAygFEhQKDHJld2FyZENvdW50NBgwIAMoBRIQCghyZXdhcmRJ" + "ZBgxIAMoBRIRCglyZXdhcmRJZDEYMiADKAUSEQoJcmV3YXJkSWQyGDMgAygF" + "EhEKCXJld2FyZElkMxg0IAMoBRIRCglyZXdhcmRJZDQYNSADKAUSEgoKcmV3" + "YXJkVHlwZRg2IAMoBRITCgtyZXdhcmRUeXBlMRg3IAMoBRITCgtyZXdhcmRU" + "eXBlMhg4IAMoBRITCgtyZXdhcmRUeXBlMxg5IAMoBRITCgtyZXdhcmRUeXBl" + "NBg6IAMoBRIaChJ0aW1lbGluZVN0YXJ0TWFwSWQYOyABKAUSDAoEdHlwZRg8" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestTable11005), QuestTable11005.Parser, new string[60]
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
