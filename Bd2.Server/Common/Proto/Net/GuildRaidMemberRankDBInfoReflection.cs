using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidMemberRankDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0d1aWxkUmFpZE1lbWJlclJhbmtEQkluZm8ucHJvdG8SCXBy" + "b3RvLm5ldCKNAQoZR3VpbGRSYWlkTWVtYmVyUmFua0RCSW5mbxIMCgRyYW5r" + "GAEgASgFEhMKC293bmVyX2luZGV4GAIgASgDEg8KB3VzZXJfaWQYAyABKAkS" + "DQoFc2NvcmUYBCABKAMSGwoTcG9ydHJhaXRfY29zdHVtZV9pZBgFIAEoBRIQ" + "Cgh0aXRsZV9pZBgGIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidMemberRankDBInfo), GuildRaidMemberRankDBInfo.Parser, new string[6] { "Rank", "OwnerIndex", "UserId", "Score", "PortraitCostumeId", "TitleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
