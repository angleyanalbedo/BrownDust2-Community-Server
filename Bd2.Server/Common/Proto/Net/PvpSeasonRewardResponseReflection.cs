using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpSeasonRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9QdnBTZWFzb25SZXdhcmRSZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byKfAQoX" + "UHZwU2Vhc29uUmV3YXJkUmVzcG9uc2USDAoEcmFuaxgBIAEoBRIKCgJ2cBgC" + "IAEoBRI5ChJyZXdhcmRfaW5mb19idW5kbGUYAyABKAsyHS5wcm90by5uZXQu" + "UmV3YXJkREJJbmZvQnVuZGxlEhUKDXJld2FyZF9zZWFzb24YBCABKAUSGAoQ" + "b25jZV9yZXdhcmRfaW5mbxgFIAMoBWIGcHJvdG8z"), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpSeasonRewardResponse), PvpSeasonRewardResponse.Parser, new string[5] { "Rank", "Vp", "RewardInfoBundle", "RewardSeason", "OnceRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
