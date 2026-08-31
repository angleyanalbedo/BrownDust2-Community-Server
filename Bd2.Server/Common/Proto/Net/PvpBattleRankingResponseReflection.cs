using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9QdnBCYXR0bGVSYW5raW5nUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBojQ29tbW9ucy9QdnBCYXR0bGVSYW5rVXNlckluZm8ucHJvdG8i" + "kgEKGFB2cEJhdHRsZVJhbmtpbmdSZXNwb25zZRI7ChF1c2VyX3Jhbmtpbmdf" + "aW5mbxgBIAMoCzIgLnByb3RvLm5ldC5QdnBCYXR0bGVSYW5rVXNlckluZm8S" + "OQoPbXlfcmFua2luZ19pbmZvGAIgASgLMiAucHJvdG8ubmV0LlB2cEJhdHRs" + "ZVJhbmtVc2VySW5mb2IGcHJvdG8z"), new FileDescriptor[1] { PvpBattleRankUserInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankingResponse), PvpBattleRankingResponse.Parser, new string[2] { "UserRankingInfo", "MyRankingInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
