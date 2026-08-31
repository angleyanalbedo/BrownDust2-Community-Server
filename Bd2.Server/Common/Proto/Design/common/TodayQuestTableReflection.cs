using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TodayQuestTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9Ub2RheVF1ZXN0" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i2wUKD1RvZGF5UXVl" + "c3RUYWJsZRIYChBhY2NlcHRDaW5lbWFOYW1lGAEgASgJEh0KFWFjY2VwdERl" + "c2NRdWVzdFRleHRJZBgCIAEoBRITCgthY2NlcHROcGNJZBgDIAEoBRITCgtj" + "aGFyR3JvdXBJZBgEIAEoBRIRCgljbGVhclRpbWUYBSABKAUSFAoMY29sbGVj" + "dGlvbklkGAYgAygFEhoKEmNvbXBsZXRlQ2luZW1hTmFtZRgHIAEoCRIVCg1j" + "b21wbGV0ZU5wY0lkGAggASgFEhYKDmNvbmRpdGlvbkNvdW50GAkgASgFEhUK" + "DWNvbmRpdGlvblR5cGUYCiABKAUSEAoIZGVja0xpc3QYCyADKAUSGQoRZGlz" + "cGxheURpZmZpY3VsdHkYDCABKAUSFAoMZGlzcGxheU1hcElkGA0gASgFEhoK" + "EmRpc3BsYXlSZXdhcmRDb3VudBgOIAMoBRIXCg9kaXNwbGF5UmV3YXJkSWQY" + "DyADKAUSGQoRZGlzcGxheVJld2FyZFR5cGUYECADKAUSFwoPZ2l2ZVF1ZXN0" + "SXRlbUlkGBEgAygFEgoKAmlkGBIgASgFEhIKCm1hZ2ljVmFsdWUYEyADKAUS" + "DQoFbWFwSWQYFCABKAUSEwoLbmV4dFF1ZXN0SWQYFSABKAUSDgoGcGFja0lk" + "GBYgASgFEhQKDHByaW9yUXVlc3RJZBgXIAEoBRIhChlxdWVzdENvbmRpdGlv" + "blF1ZXN0VGV4dElkGBggASgFEhwKFHF1ZXN0RGVzY1F1ZXN0VGV4dElkGBkg" + "ASgFEhwKFHF1ZXN0TmFtZVF1ZXN0VGV4dElkGBogASgFEhwKFHJlcHV0YXRp" + "b25Db21wbGV0ZUlkGBsgASgFEhMKC3Jld2FyZENvdW50GBwgAygFEhAKCHJl" + "d2FyZElkGB0gAygFEhIKCnJld2FyZFR5cGUYHiADKAUSDAoEdHlwZRgfIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TodayQuestTable), TodayQuestTable.Parser, new string[31]
		{
			"AcceptCinemaName", "AcceptDescQuestTextId", "AcceptNpcId", "CharGroupId", "ClearTime", "CollectionId", "CompleteCinemaName", "CompleteNpcId", "ConditionCount", "ConditionType",
			"DeckList", "DisplayDifficulty", "DisplayMapId", "DisplayRewardCount", "DisplayRewardId", "DisplayRewardType", "GiveQuestItemId", "Id", "MagicValue", "MapId",
			"NextQuestId", "PackId", "PriorQuestId", "QuestConditionQuestTextId", "QuestDescQuestTextId", "QuestNameQuestTextId", "ReputationCompleteId", "RewardCount", "RewardId", "RewardType",
			"Type"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
