using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopSellResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9TaG9wU2VsbFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIk0KEFNob3BTZWxsUmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopSellResponse), ShopSellResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
