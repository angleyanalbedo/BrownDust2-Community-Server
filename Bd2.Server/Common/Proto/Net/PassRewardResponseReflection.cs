using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9QYXNzUmV3YXJkUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l" + "dBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8iaQoSUGFzc1Jl" + "d2FyZFJlc3BvbnNlEjkKEnJld2FyZF9pbmZvX2J1bmRsZRgBIAEoCzIdLnBy" + "b3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGUSGAoQbmV3YmllX3Bhc3Nfc3Rl" + "cBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassRewardResponse), PassRewardResponse.Parser, new string[2] { "RewardInfoBundle", "NewbiePassStep" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
