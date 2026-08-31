using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidSeasonRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9HdWlsZFJhaWRTZWFzb25SZXdhcmRSZXNwb25zZS5wcm90" + "bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90" + "byJ2Ch1HdWlsZFJhaWRTZWFzb25SZXdhcmRSZXNwb25zZRI5ChJyZXdhcmRf" + "aW5mb19idW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVu" + "ZGxlEhoKEmlzX3JlY2VpdmVkX3Jld2FyZBgCIAEoCGIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidSeasonRewardResponse), GuildRaidSeasonRewardResponse.Parser, new string[2] { "RewardInfoBundle", "IsReceivedReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
