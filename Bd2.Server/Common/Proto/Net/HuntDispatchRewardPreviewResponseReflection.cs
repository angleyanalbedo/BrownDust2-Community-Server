using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchRewardPreviewResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjBSZXNwb25zZS9IdW50RGlzcGF0Y2hSZXdhcmRQcmV2aWV3UmVzcG9uc2Uu" + "cHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUu" + "cHJvdG8imQEKIUh1bnREaXNwYXRjaFJld2FyZFByZXZpZXdSZXNwb25zZRIa" + "ChJjdXJyZW50X3BsYXlfY291bnQYASABKAUSOQoScmV3YXJkX2luZm9fYnVu" + "ZGxlGAIgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRIdChVp" + "c19ub3RfcmV0dXJuX2ZyZWVfYXAYAyABKAhiBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchRewardPreviewResponse), HuntDispatchRewardPreviewResponse.Parser, new string[3] { "CurrentPlayCount", "RewardInfoBundle", "IsNotReturnFreeAp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
