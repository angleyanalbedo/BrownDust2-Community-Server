using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementClearResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9BY2hpZXZlbWVudENsZWFyUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8iZgoY" + "QWNoaWV2ZW1lbnRDbGVhclJlc3BvbnNlEg8KB2FkZF9leHAYASABKAUSOQoS" + "cmV3YXJkX2luZm9fYnVuZGxlGAIgASgLMh0ucHJvdG8ubmV0LlJld2FyZERC" + "SW5mb0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementClearResponse), AchievementClearResponse.Parser, new string[2] { "AddExp", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
