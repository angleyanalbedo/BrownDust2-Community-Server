using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AttendanceEventInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0F0dGVuZGFuY2VFdmVudEluZm8ucHJvdG8SCXByb3RvLm5l" + "dCJoChRBdHRlbmRhbmNlQWx3YXlzSW5mbxIZChFldmVudF9zY2hlZHVsZV9p" + "ZBgBIAEoBRIbChNhdHRlbmRhbmNlX2dyb3VwX2lkGAIgASgFEhgKEGF0dGVu" + "ZGFuY2VfY291bnQYAyABKAUidgoUQXR0ZW5kYW5jZUxpbWl0R3JvdXASHwoX" + "bGltaXRfZXZlbnRfc2NoZWR1bGVfaWQYASABKAUSPQoVYXR0ZW5kYW5jZV9s" + "aW1pdF9pbmZvGAIgAygLMh4ucHJvdG8ubmV0LkF0dGVuZGFuY2VMaW1pdElu" + "Zm8iSQoTQXR0ZW5kYW5jZUxpbWl0SW5mbxIKCgJpZBgBIAEoBRIRCglyZXdh" + "cmRfaWQYAiABKAUSEwoLcmV3YXJkX2RhdGUYAyABKAkiWAoXU3Vic2NyaWJl" + "QXR0ZW5kYW5jZUluZm8SEQoJdGlja2V0X2lkGAEgASgFEhUKDXJlc2VydmVk" + "X2RhdGUYAiABKAMSEwoLZXhwaXJ5X2RhdGUYAyABKAMiSAoVQXR0ZW5kYW5j" + "ZVBhY2thZ2VJbmZvEhAKCGdyb3VwX2lkGAEgASgFEgoKAmlkGAIgASgFEhEK" + "CWlzX3Jld2FyZBgDIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[5]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceAlwaysInfo), AttendanceAlwaysInfo.Parser, new string[3] { "EventScheduleId", "AttendanceGroupId", "AttendanceCount" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(AttendanceLimitGroup), AttendanceLimitGroup.Parser, new string[2] { "LimitEventScheduleId", "AttendanceLimitInfo" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(AttendanceLimitInfo), AttendanceLimitInfo.Parser, new string[3] { "Id", "RewardId", "RewardDate" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(SubscribeAttendanceInfo), SubscribeAttendanceInfo.Parser, new string[3] { "TicketId", "ReservedDate", "ExpiryDate" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(AttendancePackageInfo), AttendancePackageInfo.Parser, new string[3] { "GroupId", "Id", "IsReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
