using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9NaXNzaW9uSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaG0NvbW1vbnMvTWlzc2lvbkRCSW5mby5wcm90bxooQ29tbW9ucy9NaXNz" + "aW9uU2VjdGlvblJld2FyZERCSW5mby5wcm90byLWAQoTTWlzc2lvbkluZm9S" + "ZXNwb25zZRIuCgxtaXNzaW9uX2luZm8YASADKAsyGC5wcm90by5uZXQuTWlz" + "c2lvbkRCSW5mbxJKChttaXNzaW9uX3NlY3Rpb25fcmV3YXJkX2luZm8YAiAD" + "KAsyJS5wcm90by5uZXQuTWlzc2lvblNlY3Rpb25SZXdhcmREQkluZm8SIAoY" + "ZGFpbHlfbWlzc2lvbl9yZXNldF90aW1lGAMgASgDEiEKGXdlZWtseV9taXNz" + "aW9uX3Jlc2V0X3RpbWUYBCABKANiBnByb3RvMw=="), new FileDescriptor[2]
	{
		MissionDBInfoReflection.Descriptor,
		MissionSectionRewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionInfoResponse), MissionInfoResponse.Parser, new string[4] { "MissionInfo", "MissionSectionRewardInfo", "DailyMissionResetTime", "WeeklyMissionResetTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
