using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9FdmVudEV4Y2hhbmdlUmV3YXJkUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8a" + "J0NvbW1vbnMvRXZlbnRFeGNoYW5nZVJld2FyZERCSW5mby5wcm90byKjAQob" + "RXZlbnRFeGNoYW5nZVJld2FyZFJlc3BvbnNlEjkKEnJld2FyZF9pbmZvX2J1" + "bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGUSSQob" + "Y2hhbmdlX2V4Y2hhbmdlX3Jld2FyZF9pbmZvGAIgAygLMiQucHJvdG8ubmV0" + "LkV2ZW50RXhjaGFuZ2VSZXdhcmREQkluZm9iBnByb3RvMw=="), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		EventExchangeRewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeRewardResponse), EventExchangeRewardResponse.Parser, new string[2] { "RewardInfoBundle", "ChangeExchangeRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
