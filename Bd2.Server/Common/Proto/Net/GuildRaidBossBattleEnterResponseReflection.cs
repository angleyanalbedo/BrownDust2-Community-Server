using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossBattleEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXNwb25zZS9HdWlsZFJhaWRCb3NzQmF0dGxlRW50ZXJSZXNwb25zZS5w" + "cm90bxIJcHJvdG8ubmV0GiFDb21tb25zL0V2ZW50U2NoZWR1bGVEQkluZm8u" + "cHJvdG8aJUNvbW1vbnMvUGljdG9yaWFsQnVmZlN0YXREQkluZm8ucHJvdG8a" + "IENvbW1vbnMvR3VpbGRTdXBwb3J0ZXJJbmZvLnByb3RvIuEBCiBHdWlsZFJh" + "aWRCb3NzQmF0dGxlRW50ZXJSZXNwb25zZRI7ChNldmVudF9zY2hlZHVsZV9p" + "bmZvGAEgASgLMh4ucHJvdG8ubmV0LkV2ZW50U2NoZWR1bGVEQkluZm8SOgoO" + "YnVmZl9zdGF0X2luZm8YAiADKAsyIi5wcm90by5uZXQuUGljdG9yaWFsQnVm" + "ZlN0YXREQkluZm8SRAoTc3VwcG9ydGVyX2NoYXJfaW5mbxgDIAMoCzInLnBy" + "b3RvLm5ldC5HdWlsZFN1cHBvcnRlckJhdHRsZUNoYXJJbmZvYgZwcm90bzM="), new FileDescriptor[3]
	{
		EventScheduleDBInfoReflection.Descriptor,
		PictorialBuffStatDBInfoReflection.Descriptor,
		GuildSupporterInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossBattleEnterResponse), GuildRaidBossBattleEnterResponse.Parser, new string[3] { "EventScheduleInfo", "BuffStatInfo", "SupporterCharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
