using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlSW5mb1Jlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQaKkNvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlrZVN0" + "YXRlSW5mby5wcm90bxoqQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVMaWtlRmxv" + "b3JJbmZvLnByb3RvGitDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VDaG9p" + "Y2VJbmZvLnByb3RvGhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8aGENvbW1v" + "bnMvQ2hhckRCSW5mby5wcm90bxobQ29tbW9ucy9Db3N0dW1lREJJbmZvLnBy" + "b3RvGhlDb21tb25zL1JlbGljREJJbmZvLnByb3RvGi1Db21tb25zL0V2aWxD" + "YXN0bGVSb2d1ZUxpa2VHcm93dGhEQkluZm8ucHJvdG8aKkNvbW1vbnMvRXZp" + "bENhc3RsZVJvZ3VlTGlrZUV2ZW50SW5mby5wcm90bxorQ29tbW9ucy9Fdmls" + "Q2FzdGxlUm9ndWVMaWtlU2hvcERCSW5mby5wcm90byK0BgofRXZpbENhc3Rs" + "ZVJvZ3VlTGlrZUluZm9SZXNwb25zZRI7CgpzdGF0ZV9pbmZvGAEgASgLMicu" + "cHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8SDQoFbGV2" + "ZWwYAiABKAUSOwoKZmxvb3JfaW5mbxgDIAMoCzInLnByb3RvLm5ldC5Fdmls" + "Q2FzdGxlUm9ndWVMaWtlRmxvb3JJbmZvEigKCWRlY2tfaW5mbxgEIAMoCzIV" + "LnByb3RvLm5ldC5EZWNrREJJbmZvEigKCWNoYXJfaW5mbxgFIAMoCzIVLnBy" + "b3RvLm5ldC5DaGFyREJJbmZvEi4KDGNvc3R1bWVfaW5mbxgGIAMoCzIYLnBy" + "b3RvLm5ldC5Db3N0dW1lREJJbmZvEioKCnJlbGljX2luZm8YByADKAsyFi5w" + "cm90by5uZXQuUmVsaWNEQkluZm8SPQoLY2hvaWNlX2luZm8YCCABKAsyKC5w" + "cm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZUNob2ljZUluZm8SDwoHcmVf" + "cm9sbBgJIAEoBRIQCghncm91cF9pZBgKIAEoBRIKCgJpZBgLIAEoBRI/Cgtn" + "cm93dGhfaW5mbxgMIAMoCzIqLnByb3RvLm5ldC5FdmlsQ2FzdGxlUm9ndWVM" + "aWtlR3Jvd3RoREJJbmZvEjsKCmV2ZW50X2luZm8YDSABKAsyJy5wcm90by5u" + "ZXQuRXZpbENhc3RsZVJvZ3VlTGlrZUV2ZW50SW5mbxI7CglzaG9wX2luZm8Y" + "DiABKAsyKC5wcm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVNob3BEQklu" + "Zm8SFAoMYmF0dGxlX2xldmVsGA8gASgFEhUKDW1heF90cnlfbGV2ZWwYECAB" + "KAUSEAoIb2JzaWRpYW4YESABKAUSFwoPcm9ndWVfbGlrZV9nb2xkGBIgASgF" + "Eg4KBnNlYXNvbhgTIAEoBRIWCg5yZWd1bGFyX3NlYXNvbhgUIAEoBRIVCg1z" + "ZWFzb25fcmV3YXJkGBUgASgIEhgKEG1heF9yZXdhcmRfbGV2ZWwYFiABKAVi" + "BnByb3RvMw=="), new FileDescriptor[10]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeFloorInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		DeckDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		RelicDBInfoReflection.Descriptor,
		EvilCastleRogueLikeGrowthDBInfoReflection.Descriptor,
		EvilCastleRogueLikeEventInfoReflection.Descriptor,
		EvilCastleRogueLikeShopDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeInfoResponse), EvilCastleRogueLikeInfoResponse.Parser, new string[22]
		{
			"StateInfo", "Level", "FloorInfo", "DeckInfo", "CharInfo", "CostumeInfo", "RelicInfo", "ChoiceInfo", "ReRoll", "GroupId",
			"Id", "GrowthInfo", "EventInfo", "ShopInfo", "BattleLevel", "MaxTryLevel", "Obsidian", "RogueLikeGold", "Season", "RegularSeason",
			"SeasonReward", "MaxRewardLevel"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
