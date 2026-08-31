using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntSeasonRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9Nb25zdGVySHVudFNlYXNvblJld2FyZFJlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnBy" + "b3RvIpIBCh9Nb25zdGVySHVudFNlYXNvblJld2FyZFJlc3BvbnNlEgwKBHJh" + "bmsYASABKAUSDQoFc2NvcmUYAiABKAUSFwoPbW9uc3Rlcl9odW50X2lkGAMg" + "ASgFEjkKEnJld2FyZF9pbmZvX2J1bmRsZRgEIAEoCzIdLnByb3RvLm5ldC5S" + "ZXdhcmREQkluZm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntSeasonRewardResponse), MonsterHuntSeasonRewardResponse.Parser, new string[4] { "Rank", "Score", "MonsterHuntId", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
