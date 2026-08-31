using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9QYWNrQnV5UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoY" + "Q29tbW9ucy9QYWNrREJJbmZvLnByb3RvGiBDb21tb25zL1Jld2FyZERCSW5m" + "b0J1bmRsZS5wcm90bxoYQ29tbW9ucy9EZWNrREJJbmZvLnByb3RvIqABCg9Q" + "YWNrQnV5UmVzcG9uc2USKAoJcGFja19pbmZvGAEgASgLMhUucHJvdG8ubmV0" + "LlBhY2tEQkluZm8SOQoScmV3YXJkX2luZm9fYnVuZGxlGAIgASgLMh0ucHJv" + "dG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRIoCglkZWNrX2luZm8YAyADKAsy" + "FS5wcm90by5uZXQuRGVja0RCSW5mb2IGcHJvdG8z"), new FileDescriptor[3]
	{
		PackDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor,
		DeckDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackBuyResponse), PackBuyResponse.Parser, new string[3] { "PackInfo", "RewardInfoBundle", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
