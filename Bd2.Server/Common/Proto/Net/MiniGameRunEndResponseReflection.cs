using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameRunEndResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9NaW5pR2FtZVJ1bkVuZFJlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvIqsBChZN" + "aW5pR2FtZVJ1bkVuZFJlc3BvbnNlEhkKEWJlc3RfcmVjb3JkX3ZhbHVlGAEg" + "ASgFEhkKEWxhc3RfcmV3YXJkX3BvaW50GAIgASgFEjkKEnJld2FyZF9pbmZv" + "X2J1bmRsZRgDIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGUS" + "IAoYaXNfcG9zc2libGVfcXVpY2tfcmV3YXJkGAQgASgIYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameRunEndResponse), MiniGameRunEndResponse.Parser, new string[4] { "BestRecordValue", "LastRewardPoint", "RewardInfoBundle", "IsPossibleQuickReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
