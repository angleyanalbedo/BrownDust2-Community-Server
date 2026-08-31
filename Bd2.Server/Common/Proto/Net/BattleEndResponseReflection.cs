using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEndResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9CYXR0bGVFbmRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8aG0NvbW1vbnMvTW9uc3RlckRC" + "SW5mby5wcm90bxofQ29tbW9ucy9DaGFyUGFydG5lckRCSW5mby5wcm90bxoe" + "Q29tbW9ucy9FdmlsQ2FzdGxlREJJbmZvLnByb3RvGiNDb21tb25zL0V2aWxD" + "YXN0bGVUb3RhbERCSW5mby5wcm90bxogQ29tbW9ucy9SZXdhcmREQkluZm9C" + "dW5kbGUucHJvdG8aI0NvbW1vbnMvTW9uc3Rlckh1bnRVc2VyREJJbmZvLnBy" + "b3RvGiNDb21tb25zL0V2aWxDYXN0bGVUb3dlckRCSW5mby5wcm90bxojQ29t" + "bW9ucy9QYWNrRXZlbnRCYXR0bGVEQkluZm8ucHJvdG8aKkNvbW1vbnMvRXZp" + "bENhc3RsZVJvZ3VlTGlrZVN0YXRlSW5mby5wcm90bxorQ29tbW9ucy9Fdmls" + "Q2FzdGxlUm9ndWVMaWtlQ2hvaWNlSW5mby5wcm90bxosQ29tbW9ucy9Fdmls" + "Q2FzdGxlUm9ndWVMaWtlRXZlbnRSZXdhcmQucHJvdG8aKkNvbW1vbnMvRXZp" + "bENhc3RsZVJvZ3VlTGlrZVNjb3JlSW5mby5wcm90bxopQ29tbW9ucy9Fdmls" + "Q2FzdGxlUm9ndWVMaWtlUm9vbUluZm8ucHJvdG8aKUNvbW1vbnMvR3VpbGRS" + "YWlkTm9ybWFsQmF0dGxlREJJbmZvLnByb3RvGiZDb21tb25zL0d1aWxkUmFp" + "ZEJhdHRsZUdvbGVtSW5mby5wcm90bxomQ29tbW9ucy9HdWlsZFJhaWRCYXR0" + "bGVTY29yZUluZm8ucHJvdG8i6QsKEUJhdHRsZUVuZFJlc3BvbnNlEhUKDWJh" + "dHRsZV9yZXN1bHQYASABKAUSFgoOdXNlcl9sZXZlbF9leHAYAiABKAUSKAoJ" + "Y2hhcl9pbmZvGAMgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm8SLgoMbW9u" + "c3Rlcl9pbmZvGAQgAygLMhgucHJvdG8ubmV0Lk1vbnN0ZXJEQkluZm8SNAoN" + "cmV3YXJkX2J1bmRsZRgFIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9C" + "dW5kbGUSOgoTYm9udXNfcmV3YXJkX2J1bmRsZRgGIAEoCzIdLnByb3RvLm5l" + "dC5SZXdhcmREQkluZm9CdW5kbGUSQQoabW9uc3Rlcl9odW50X3Jld2FyZF9i" + "dW5kbGUYByABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlEkcK" + "IG1vbnN0ZXJfaHVudF9kYWlseV9yZXdhcmRfYnVuZGxlGAggASgLMh0ucHJv" + "dG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRI3ChFjaGFyX3BhcnRuZXJfaW5m" + "bxgJIAMoCzIcLnByb3RvLm5ldC5DaGFyUGFydG5lckRCSW5mbxI1ChBldmls" + "X2Nhc3RsZV9pbmZvGAogASgLMhsucHJvdG8ubmV0LkV2aWxDYXN0bGVEQklu" + "Zm8SQAoWZXZpbF9jYXN0bGVfdG90YWxfaW5mbxgLIAEoCzIgLnByb3RvLm5l" + "dC5FdmlsQ2FzdGxlVG90YWxEQkluZm8SEgoKZXZhbHVhdGlvbhgMIAEoBRJA" + "ChZtb25zdGVyX2h1bnRfdXNlcl9pbmZvGA0gASgLMiAucHJvdG8ubmV0Lk1v" + "bnN0ZXJIdW50VXNlckRCSW5mbxIMCgRyYW5rGA4gASgFEkAKFmV2aWxfY2Fz" + "dGxlX3Rvd2VyX2luZm8YDyABKAsyIC5wcm90by5uZXQuRXZpbENhc3RsZVRv" + "d2VyREJJbmZvEkAKFnBhY2tfZXZlbnRfYmF0dGxlX2luZm8YECABKAsyIC5w" + "cm90by5uZXQuUGFja0V2ZW50QmF0dGxlREJJbmZvElMKImV2aWxlX2Nhc3Rs" + "ZV9yb2d1ZV9saWtlX3N0YXRlX2luZm8YESABKAsyJy5wcm90by5uZXQuRXZp" + "bENhc3RsZVJvZ3VlTGlrZVN0YXRlSW5mbxJVCiNldmlsZV9jYXN0bGVfcm9n" + "dWVfbGlrZV9jaG9pY2VfaW5mbxgSIAEoCzIoLnByb3RvLm5ldC5FdmlsQ2Fz" + "dGxlUm9ndWVMaWtlQ2hvaWNlSW5mbxInCh9ldmlsZV9jYXN0bGVfcm9ndWVf" + "bGlrZV9yZV9yb2xsGBMgASgFEkQKEWV2ZW50X3Jld2FyZF9pbmZvGBQgASgL" + "MikucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VFdmVudFJld2FyZBIX" + "Cg9yb2d1ZV9saWtlX2dvbGQYFSABKAUSUgohZXZpbF9jYXN0bGVfcm9ndWVf" + "bGlrZV9zY29yZV9pbmZvGBYgASgLMicucHJvdG8ubmV0LkV2aWxDYXN0bGVS" + "b2d1ZUxpa2VTY29yZUluZm8SEwoLY2xlYXJfZmxvb3IYFyABKAUSPwoPY2xl" + "YXJfcm9vbV9pbmZvGBggASgLMiYucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1" + "ZUxpa2VSb29tSW5mbxJNCh1ndWlsZF9yYWlkX25vcm1hbF9iYXR0bGVfaW5m" + "bxgZIAEoCzImLnByb3RvLm5ldC5HdWlsZFJhaWROb3JtYWxCYXR0bGVEQklu" + "Zm8SQgoVZ3VpbGRfcmFpZF9nb2xlbV9pbmZvGBogASgLMiMucHJvdG8ubmV0" + "Lkd1aWxkUmFpZEJhdHRsZUdvbGVtSW5mbxJCChVndWlsZF9yYWlkX3Njb3Jl" + "X2luZm8YGyABKAsyIy5wcm90by5uZXQuR3VpbGRSYWlkQmF0dGxlU2NvcmVJ" + "bmZvYgZwcm90bzM="), new FileDescriptor[17]
	{
		CharDBInfoReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor,
		CharPartnerDBInfoReflection.Descriptor,
		EvilCastleDBInfoReflection.Descriptor,
		EvilCastleTotalDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor,
		MonsterHuntUserDBInfoReflection.Descriptor,
		EvilCastleTowerDBInfoReflection.Descriptor,
		PackEventBattleDBInfoReflection.Descriptor,
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		EvilCastleRogueLikeEventRewardReflection.Descriptor,
		EvilCastleRogueLikeScoreInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor,
		GuildRaidNormalBattleDBInfoReflection.Descriptor,
		GuildRaidBattleGolemInfoReflection.Descriptor,
		GuildRaidBattleScoreInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEndResponse), BattleEndResponse.Parser, new string[27]
		{
			"BattleResult", "UserLevelExp", "CharInfo", "MonsterInfo", "RewardBundle", "BonusRewardBundle", "MonsterHuntRewardBundle", "MonsterHuntDailyRewardBundle", "CharPartnerInfo", "EvilCastleInfo",
			"EvilCastleTotalInfo", "Evaluation", "MonsterHuntUserInfo", "Rank", "EvilCastleTowerInfo", "PackEventBattleInfo", "EvileCastleRogueLikeStateInfo", "EvileCastleRogueLikeChoiceInfo", "EvileCastleRogueLikeReRoll", "EventRewardInfo",
			"RogueLikeGold", "EvilCastleRogueLikeScoreInfo", "ClearFloor", "ClearRoomInfo", "GuildRaidNormalBattleInfo", "GuildRaidGolemInfo", "GuildRaidScoreInfo"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
