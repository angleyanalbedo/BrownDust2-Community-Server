using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9TaG9wQnV5UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBog" + "Q29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8aG0NvbW1vbnMvUHJv" + "ZHVjdERCSW5mby5wcm90byJ8Cg9TaG9wQnV5UmVzcG9uc2USOQoScmV3YXJk" + "X2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1" + "bmRsZRIuCgxwcm9kdWN0X2luZm8YAiABKAsyGC5wcm90by5uZXQuUHJvZHVj" + "dERCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		ProductDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopBuyResponse), ShopBuyResponse.Parser, new string[2] { "RewardInfoBundle", "ProductInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
