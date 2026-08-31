using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventScheduleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9FdmVudFNjaGVkdWxlSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvRXZlbnRTY2hlZHVsZURCSW5mby5wcm90bxot" + "Q29tbW9ucy9EZWxheWVkVmlzaWJpbGl0eVNjaGVkdWxlREJJbmZvLnByb3Rv" + "Iq4BChlFdmVudFNjaGVkdWxlSW5mb1Jlc3BvbnNlEjsKE2V2ZW50X3NjaGVk" + "dWxlX2luZm8YASADKAsyHi5wcm90by5uZXQuRXZlbnRTY2hlZHVsZURCSW5m" + "bxJUCiBkZWxheWVkX3Zpc2liaWxpdHlfc2NoZWR1bGVfaW5mbxgCIAMoCzIq" + "LnByb3RvLm5ldC5EZWxheWVkVmlzaWJpbGl0eVNjaGVkdWxlREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[2]
	{
		EventScheduleDBInfoReflection.Descriptor,
		DelayedVisibilityScheduleDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventScheduleInfoResponse), EventScheduleInfoResponse.Parser, new string[2] { "EventScheduleInfo", "DelayedVisibilityScheduleInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
