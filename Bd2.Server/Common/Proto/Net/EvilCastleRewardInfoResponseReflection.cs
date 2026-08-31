using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRewardInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXNwb25zZS9FdmlsQ2FzdGxlUmV3YXJkSW5mb1Jlc3BvbnNlLnByb3Rv" + "Eglwcm90by5uZXQaJ0NvbW1vbnMvRXZpbENhc3RsZUVuZFNlYXNvbkRCSW5m" + "by5wcm90bxosQ29tbW9ucy9FdmlsQ2FzdGxlRW5kU2Vhc29uVG90YWxEQklu" + "Zm8ucHJvdG8aIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIuIB" + "ChxFdmlsQ2FzdGxlUmV3YXJkSW5mb1Jlc3BvbnNlEj0KD2VuZF9zZWFzb25f" + "aW5mbxgBIAMoCzIkLnByb3RvLm5ldC5FdmlsQ2FzdGxlRW5kU2Vhc29uREJJ" + "bmZvEkgKFWVuZF9zZWFzb25fdG90YWxfaW5mbxgCIAEoCzIpLnByb3RvLm5l" + "dC5FdmlsQ2FzdGxlRW5kU2Vhc29uVG90YWxEQkluZm8SOQoScmV3YXJkX2lu" + "Zm9fYnVuZGxlGAMgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRs" + "ZWIGcHJvdG8z"), new FileDescriptor[3]
	{
		EvilCastleEndSeasonDBInfoReflection.Descriptor,
		EvilCastleEndSeasonTotalDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRewardInfoResponse), EvilCastleRewardInfoResponse.Parser, new string[3] { "EndSeasonInfo", "EndSeasonTotalInfo", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
