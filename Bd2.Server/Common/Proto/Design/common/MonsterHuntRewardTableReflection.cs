using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckljb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudFJld2FyZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24u" + "Y29tbW9uIr0BChZNb25zdGVySHVudFJld2FyZFRhYmxlEhgKEGRhaWx5UmV3" + "YXJkQ291bnQYASADKAUSFQoNZGFpbHlSZXdhcmRJZBgCIAMoBRIXCg9kYWls" + "eVJld2FyZFR5cGUYAyADKAUSDwoHZ3JvdXBJZBgEIAEoBRINCgVsZXZlbBgF" + "IAEoBRITCgtyZXdhcmRDb3VudBgGIAMoBRIQCghyZXdhcmRJZBgHIAMoBRIS" + "CgpyZXdhcmRUeXBlGAggAygFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoV" + "Li9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntRewardTable), MonsterHuntRewardTable.Parser, new string[8] { "DailyRewardCount", "DailyRewardId", "DailyRewardType", "GroupId", "Level", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
