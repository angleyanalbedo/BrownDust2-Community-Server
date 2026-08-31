using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEndTestResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9CYXR0bGVFbmRUZXN0UmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldBoYQ29tbW9ucy9DaGFyREJJbmZvLnByb3RvGhtDb21tb25zL01vbnN0" + "ZXJEQkluZm8ucHJvdG8aH0NvbW1vbnMvQ2hhclBhcnRuZXJEQkluZm8ucHJv" + "dG8aHkNvbW1vbnMvRXZpbENhc3RsZURCSW5mby5wcm90bxojQ29tbW9ucy9F" + "dmlsQ2FzdGxlVG90YWxEQkluZm8ucHJvdG8aIENvbW1vbnMvUmV3YXJkREJJ" + "bmZvQnVuZGxlLnByb3RvGiNDb21tb25zL01vbnN0ZXJIdW50VXNlckRCSW5m" + "by5wcm90bxojQ29tbW9ucy9FdmlsQ2FzdGxlVG93ZXJEQkluZm8ucHJvdG8a" + "I0NvbW1vbnMvUGFja0V2ZW50QmF0dGxlREJJbmZvLnByb3RvGipDb21tb25z" + "L0V2aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8ucHJvdG8aK0NvbW1vbnMv" + "RXZpbENhc3RsZVJvZ3VlTGlrZUNob2ljZUluZm8ucHJvdG8aLENvbW1vbnMv" + "RXZpbENhc3RsZVJvZ3VlTGlrZUV2ZW50UmV3YXJkLnByb3RvGipDb21tb25z" + "L0V2aWxDYXN0bGVSb2d1ZUxpa2VTY29yZUluZm8ucHJvdG8aKUNvbW1vbnMv" + "RXZpbENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvLnByb3RvIpYKChVCYXR0bGVF" + "bmRUZXN0UmVzcG9uc2USFQoNYmF0dGxlX3Jlc3VsdBgBIAEoBRIWCg51c2Vy" + "X2xldmVsX2V4cBgCIAEoBRIoCgljaGFyX2luZm8YAyADKAsyFS5wcm90by5u" + "ZXQuQ2hhckRCSW5mbxIuCgxtb25zdGVyX2luZm8YBCADKAsyGC5wcm90by5u" + "ZXQuTW9uc3RlckRCSW5mbxI0Cg1yZXdhcmRfYnVuZGxlGAUgASgLMh0ucHJv" + "dG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRI6ChNib251c19yZXdhcmRfYnVu" + "ZGxlGAYgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRJBChpt" + "b25zdGVyX2h1bnRfcmV3YXJkX2J1bmRsZRgHIAEoCzIdLnByb3RvLm5ldC5S" + "ZXdhcmREQkluZm9CdW5kbGUSRwogbW9uc3Rlcl9odW50X2RhaWx5X3Jld2Fy" + "ZF9idW5kbGUYCCABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxl" + "EjcKEWNoYXJfcGFydG5lcl9pbmZvGAkgAygLMhwucHJvdG8ubmV0LkNoYXJQ" + "YXJ0bmVyREJJbmZvEjUKEGV2aWxfY2FzdGxlX2luZm8YCiABKAsyGy5wcm90" + "by5uZXQuRXZpbENhc3RsZURCSW5mbxJAChZldmlsX2Nhc3RsZV90b3RhbF9p" + "bmZvGAsgASgLMiAucHJvdG8ubmV0LkV2aWxDYXN0bGVUb3RhbERCSW5mbxIS" + "CgpldmFsdWF0aW9uGAwgASgFEkAKFm1vbnN0ZXJfaHVudF91c2VyX2luZm8Y" + "DSABKAsyIC5wcm90by5uZXQuTW9uc3Rlckh1bnRVc2VyREJJbmZvEgwKBHJh" + "bmsYDiABKAUSQAoWZXZpbF9jYXN0bGVfdG93ZXJfaW5mbxgPIAEoCzIgLnBy" + "b3RvLm5ldC5FdmlsQ2FzdGxlVG93ZXJEQkluZm8SQAoWcGFja19ldmVudF9i" + "YXR0bGVfaW5mbxgQIAEoCzIgLnByb3RvLm5ldC5QYWNrRXZlbnRCYXR0bGVE" + "QkluZm8SUwoiZXZpbGVfY2FzdGxlX3JvZ3VlX2xpa2Vfc3RhdGVfaW5mbxgR" + "IAEoCzInLnByb3RvLm5ldC5FdmlsQ2FzdGxlUm9ndWVMaWtlU3RhdGVJbmZv" + "ElUKI2V2aWxlX2Nhc3RsZV9yb2d1ZV9saWtlX2Nob2ljZV9pbmZvGBIgASgL" + "MigucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VDaG9pY2VJbmZvEicK" + "H2V2aWxlX2Nhc3RsZV9yb2d1ZV9saWtlX3JlX3JvbGwYEyABKAUSRAoRZXZl" + "bnRfcmV3YXJkX2luZm8YFCABKAsyKS5wcm90by5uZXQuRXZpbENhc3RsZVJv" + "Z3VlTGlrZUV2ZW50UmV3YXJkEhcKD3JvZ3VlX2xpa2VfZ29sZBgVIAEoBRJS" + "CiFldmlsX2Nhc3RsZV9yb2d1ZV9saWtlX3Njb3JlX2luZm8YFiABKAsyJy5w" + "cm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVNjb3JlSW5mbxITCgtjbGVh" + "cl9mbG9vchgXIAEoBRI/Cg9jbGVhcl9yb29tX2luZm8YGCABKAsyJi5wcm90" + "by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvYgZwcm90bzM="), new FileDescriptor[14]
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
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEndTestResponse), BattleEndTestResponse.Parser, new string[24]
		{
			"BattleResult", "UserLevelExp", "CharInfo", "MonsterInfo", "RewardBundle", "BonusRewardBundle", "MonsterHuntRewardBundle", "MonsterHuntDailyRewardBundle", "CharPartnerInfo", "EvilCastleInfo",
			"EvilCastleTotalInfo", "Evaluation", "MonsterHuntUserInfo", "Rank", "EvilCastleTowerInfo", "PackEventBattleInfo", "EvileCastleRogueLikeStateInfo", "EvileCastleRogueLikeChoiceInfo", "EvileCastleRogueLikeReRoll", "EventRewardInfo",
			"RogueLikeGold", "EvilCastleRogueLikeScoreInfo", "ClearFloor", "ClearRoomInfo"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
