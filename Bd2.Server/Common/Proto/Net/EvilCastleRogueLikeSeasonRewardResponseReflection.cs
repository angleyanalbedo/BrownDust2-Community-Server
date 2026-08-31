using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeSeasonRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlU2Vhc29uUmV3YXJkUmVz" + "cG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9C" + "dW5kbGUucHJvdG8icgonRXZpbENhc3RsZVJvZ3VlTGlrZVNlYXNvblJld2Fy" + "ZFJlc3BvbnNlEgwKBHJhbmsYASABKAUSOQoScmV3YXJkX2luZm9fYnVuZGxl" + "GAIgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeSeasonRewardResponse), EvilCastleRogueLikeSeasonRewardResponse.Parser, new string[2] { "Rank", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
