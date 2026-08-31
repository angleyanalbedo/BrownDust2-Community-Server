using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashShopBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9DYXNoU2hvcEJ1eVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIlAKE0Nhc2hTaG9wQnV5UmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashShopBuyResponse), CashShopBuyResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
