using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildJoinSendInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZEpvaW5TZW5kSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaGUNvbW1vbnMvR3VpbGREQkluZm8ucHJvdG8aH0NvbW1vbnMv" + "R3VpbGRBY3Rpb25EQkluZm8ucHJvdG8ifgoZR3VpbGRKb2luU2VuZEluZm9S" + "ZXNwb25zZRIuCg5qb2luX3NlbmRfaW5mbxgBIAMoCzIWLnByb3RvLm5ldC5H" + "dWlsZERCSW5mbxIxCgthY3Rpb25faW5mbxgCIAMoCzIcLnByb3RvLm5ldC5H" + "dWlsZEFjdGlvbkRCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		GuildDBInfoReflection.Descriptor,
		GuildActionDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildJoinSendInfoResponse), GuildJoinSendInfoResponse.Parser, new string[2] { "JoinSendInfo", "ActionInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
