using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventRewardHistoryDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL0V2ZW50UmV3YXJkSGlzdG9yeURCSW5mby5wcm90bxIJcHJvdG8ubmV0GhRDb21tb25zL0RlZmluZS5wcm90byJgChhFdmVudFJld2FyZEhpc3RvcnlEQkluZm8SGQoRZXZlbnRfc2NoZWR1bGVfaWQYASABKAUSFgoOZXZlbnRfZ3JvdXBfaWQYAiABKAUSEQoJcmV3YXJkX2lkGAMgAygFYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventRewardHistoryDBInfo), EventRewardHistoryDBInfo.Parser, new string[3] { "EventScheduleId", "EventGroupId", "RewardId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
