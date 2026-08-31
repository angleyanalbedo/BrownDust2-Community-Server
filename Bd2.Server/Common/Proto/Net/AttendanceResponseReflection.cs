using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AttendanceResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9BdHRlbmRhbmNlUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l" + "dBohQ29tbW9ucy9BdHRlbmRhbmNlRXZlbnRJbmZvLnByb3RvIqYDChJBdHRl" + "bmRhbmNlUmVzcG9uc2USPwoWYXR0ZW5kYW5jZV9hbHdheXNfaW5mbxgBIAMo" + "CzIfLnByb3RvLm5ldC5BdHRlbmRhbmNlQWx3YXlzSW5mbxI+ChVhdHRlbmRh" + "bmNlX2xpbWl0X2luZm8YAiADKAsyHy5wcm90by5uZXQuQXR0ZW5kYW5jZUxp" + "bWl0R3JvdXASIAoYc3RhbmRhcmRfYXR0ZW5kYW5jZV9pbmZvGAMgAygFEh8K" + "F3ByZW1pdW1fYXR0ZW5kYW5jZV9pbmZvGAQgAygFEiAKGG1vbnRobHkxX2F0" + "dGVuZGFuY2VfaW5mbxgFIAMoBRIgChhtb250aGx5Ml9hdHRlbmRhbmNlX2lu" + "Zm8YBiADKAUSRQoZc3Vic2NyaWJlX2F0dGVuZGFuY2VfaW5mbxgHIAMoCzIi" + "LnByb3RvLm5ldC5TdWJzY3JpYmVBdHRlbmRhbmNlSW5mbxJBChdhdHRlbmRh" + "bmNlX3BhY2thZ2VfaW5mbxgIIAMoCzIgLnByb3RvLm5ldC5BdHRlbmRhbmNl" + "UGFja2FnZUluZm9iBnByb3RvMw=="), new FileDescriptor[1] { AttendanceEventInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceResponse), AttendanceResponse.Parser, new string[8] { "AttendanceAlwaysInfo", "AttendanceLimitInfo", "StandardAttendanceInfo", "PremiumAttendanceInfo", "Monthly1AttendanceInfo", "Monthly2AttendanceInfo", "SubscribeAttendanceInfo", "AttendancePackageInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
