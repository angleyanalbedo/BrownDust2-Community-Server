using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleUserInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9QdnBCYXR0bGVVc2VySW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaI0NvbW1vbnMvUHZwQmF0dGxlVXNlckJhc2VJbmZvLnByb3Rv" + "IosBChlQdnBCYXR0bGVVc2VySW5mb1Jlc3BvbnNlEjMKCWJhc2VfaW5mbxgB" + "IAEoCzIgLnByb3RvLm5ldC5QdnBCYXR0bGVVc2VyQmFzZUluZm8SGAoQaXNf" + "c2Vhc29uX3Jld2FyZBgCIAEoCBIfChdwdnBfdGFibGVfY2hhbmdlX3NlYXNv" + "bhgDIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { PvpBattleUserBaseInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleUserInfoResponse), PvpBattleUserInfoResponse.Parser, new string[3] { "BaseInfo", "IsSeasonReward", "PvpTableChangeSeason" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
