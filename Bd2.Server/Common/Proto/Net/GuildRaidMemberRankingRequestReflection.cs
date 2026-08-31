using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidMemberRankingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXF1ZXN0L0d1aWxkUmFpZE1lbWJlclJhbmtpbmdSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPAodR3VpbGRSYWlkTWVtYmVyUmFua2luZ1JlcXVlc3QSCwoDc2VxGAEgASgFEg4KBnNlYXNvbhgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidMemberRankingRequest), GuildRaidMemberRankingRequest.Parser, new string[2] { "Seq", "Season" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
