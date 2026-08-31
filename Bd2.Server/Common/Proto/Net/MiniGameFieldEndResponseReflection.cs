using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldEndResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9NaW5pR2FtZUZpZWxkRW5kUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8i0wEK" + "GE1pbmlHYW1lRmllbGRFbmRSZXNwb25zZRIZChFldmVudF9zY2hlZHVsZV9p" + "ZBgBIAEoBRINCgVzY29yZRgCIAEoBRIVCg1oaWdoZXN0X3Njb3JlGAMgASgF" + "EhkKEWxhc3RfcmV3YXJkX3BvaW50GAQgASgFEjkKEnJld2FyZF9pbmZvX2J1" + "bmRsZRgFIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGUSIAoY" + "aXNfcG9zc2libGVfcXVpY2tfcmV3YXJkGAYgASgIYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldEndResponse), MiniGameFieldEndResponse.Parser, new string[6] { "EventScheduleId", "Score", "HighestScore", "LastRewardPoint", "RewardInfoBundle", "IsPossibleQuickReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
