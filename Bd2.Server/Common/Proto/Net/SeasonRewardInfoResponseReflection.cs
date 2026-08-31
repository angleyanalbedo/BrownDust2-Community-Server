using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SeasonRewardInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9TZWFzb25SZXdhcmRJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9TZWFzb25SZXdhcmREQkluZm8ucHJvdG8iTgoYU2Vhc29uUmV3YXJkSW5mb1Jlc3BvbnNlEjIKC3Jld2FyZF9pbmZvGAEgAygLMh0ucHJvdG8ubmV0LlNlYXNvblJld2FyZERCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { SeasonRewardDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SeasonRewardInfoResponse), SeasonRewardInfoResponse.Parser, new string[1] { "RewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
