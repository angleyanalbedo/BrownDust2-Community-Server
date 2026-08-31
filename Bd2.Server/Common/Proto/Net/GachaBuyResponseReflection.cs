using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9HYWNoYUJ1eVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "IENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvGh5Db21tb25zL0dh" + "Y2hhRml4ZWREQkluZm8ucHJvdG8iuAEKEEdhY2hhQnV5UmVzcG9uc2USOQoS" + "cmV3YXJkX2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERC" + "SW5mb0J1bmRsZRIRCglnZXRfcG9pbnQYAiABKAUSNQoQZ2FjaGFfZml4ZWRf" + "aW5mbxgDIAMoCzIbLnByb3RvLm5ldC5HYWNoYUZpeGVkREJJbmZvEh8KF3Nl" + "bGVjdGlvbl9hcHBseV9zb3J0X2lkGAQgAygFYgZwcm90bzM="), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		GachaFixedDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaBuyResponse), GachaBuyResponse.Parser, new string[4] { "RewardInfoBundle", "GetPoint", "GachaFixedInfo", "SelectionApplySortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
