using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0V2ZW50UmV3YXJkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImgKEkV2ZW50UmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSGQoRZXZlbnRfc2NoZWR1bGVfaWQYAiABKAUSFwoPcmV3YXJkX2dyb3VwX2lkGAMgASgFEhEKCXJld2FyZF9pZBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventRewardRequest), EventRewardRequest.Parser, new string[4] { "Seq", "EventScheduleId", "RewardGroupId", "RewardId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
