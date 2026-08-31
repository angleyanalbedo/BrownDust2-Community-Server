using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MercenaryScoutResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9NZXJjZW5hcnlTY291dFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIlMKFk1lcmNlbmFyeVNjb3V0UmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MercenaryScoutResponse), MercenaryScoutResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
