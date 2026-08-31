using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidMemberRankingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9HdWlsZFJhaWRNZW1iZXJSYW5raW5nUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBonQ29tbW9ucy9HdWlsZFJhaWRNZW1iZXJSYW5rREJJ" + "bmZvLnByb3RvIpcBCh5HdWlsZFJhaWRNZW1iZXJSYW5raW5nUmVzcG9uc2US" + "NwoJcmFua19pbmZvGAEgAygLMiQucHJvdG8ubmV0Lkd1aWxkUmFpZE1lbWJl" + "clJhbmtEQkluZm8SPAoOdXNlcl9yYW5rX2luZm8YAiABKAsyJC5wcm90by5u" + "ZXQuR3VpbGRSYWlkTWVtYmVyUmFua0RCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { GuildRaidMemberRankDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidMemberRankingResponse), GuildRaidMemberRankingResponse.Parser, new string[2] { "RankInfo", "UserRankInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
