using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleOnceRewardInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9QdnBCYXR0bGVPbmNlUmV3YXJkSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQiOwofUHZwQmF0dGxlT25jZVJld2FyZEluZm9SZXNwb25zZRIYChBvbmNlX3Jld2FyZF9pbmZvGAEgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleOnceRewardInfoResponse), PvpBattleOnceRewardInfoResponse.Parser, new string[1] { "OnceRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
