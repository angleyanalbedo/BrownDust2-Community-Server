using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameRunQuickRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9NaW5pR2FtZVJ1blF1aWNrUmV3YXJkUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJv" + "dG8iWwoeTWluaUdhbWVSdW5RdWlja1Jld2FyZFJlc3BvbnNlEjkKEnJld2Fy" + "ZF9pbmZvX2J1bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9C" + "dW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameRunQuickRewardResponse), MiniGameRunQuickRewardResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
