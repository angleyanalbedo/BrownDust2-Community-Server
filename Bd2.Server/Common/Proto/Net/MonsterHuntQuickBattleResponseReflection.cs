using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntQuickBattleResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9Nb25zdGVySHVudFF1aWNrQmF0dGxlUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBojQ29tbW9ucy9Nb25zdGVySHVudFVzZXJEQkluZm8u" + "cHJvdG8aIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIvwBCh5N" + "b25zdGVySHVudFF1aWNrQmF0dGxlUmVzcG9uc2USQAoWbW9uc3Rlcl9odW50" + "X3VzZXJfaW5mbxgBIAEoCzIgLnByb3RvLm5ldC5Nb25zdGVySHVudFVzZXJE" + "QkluZm8SQQoabW9uc3Rlcl9odW50X3Jld2FyZF9idW5kbGUYAiABKAsyHS5w" + "cm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlEkcKIG1vbnN0ZXJfaHVudF9k" + "YWlseV9yZXdhcmRfYnVuZGxlGAMgASgLMh0ucHJvdG8ubmV0LlJld2FyZERC" + "SW5mb0J1bmRsZRIMCgRyYW5rGAQgASgFYgZwcm90bzM="), new FileDescriptor[2]
	{
		MonsterHuntUserDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntQuickBattleResponse), MonsterHuntQuickBattleResponse.Parser, new string[4] { "MonsterHuntUserInfo", "MonsterHuntRewardBundle", "MonsterHuntDailyRewardBundle", "Rank" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
