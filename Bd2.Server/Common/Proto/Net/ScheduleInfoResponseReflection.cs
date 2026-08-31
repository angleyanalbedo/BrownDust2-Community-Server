using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ScheduleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9TY2hlZHVsZUluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0GhlDb21tb25zL1NjaGR1bGVJbmZvLnByb3RvInEKFFNjaGVkdWxlSW5m" + "b1Jlc3BvbnNlEicKH3NjaGVkdWxlX2NhbGN1bGF0ZV9taWxlX3NlY29uZHMY" + "ASABKAUSMAoNc2NoZWR1bGVfaW5mbxgCIAMoCzIZLnByb3RvLm5ldC5TY2hl" + "ZHVsZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { SchduleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ScheduleInfoResponse), ScheduleInfoResponse.Parser, new string[2] { "ScheduleCalculateMileSeconds", "ScheduleInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
