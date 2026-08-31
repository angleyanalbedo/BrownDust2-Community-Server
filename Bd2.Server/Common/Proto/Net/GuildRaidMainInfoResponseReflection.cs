using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidMainInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZFJhaWRNYWluSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQihgMKGUd1aWxkUmFpZE1haW5JbmZvUmVzcG9uc2USDgoGc2Vh" + "c29uGAEgASgFEhAKCHJhaWRfZGF5GAIgASgFEiEKGXRvZGF5X25vcm1hbF9i" + "YXR0bGVfY291bnQYAyABKAUSEgoKdXNlcl9zY29yZRgEIAEoAxIcChRsYXN0" + "X3Njb3JlX3Jld2FyZF9pZBgFIAEoBRIZChFndWlsZF90b3RhbF9zY29yZRgG" + "IAEoAxIZChFndWlsZF90b3BfcGVyY2VudBgHIAEoARITCgtnb2xlbV9sZXZl" + "bBgIIAEoBRIRCglnb2xlbV9leHAYCSABKAUSIAoYb2J0YWluYWJsZV9zZWFz" + "b25fcmV3YXJkGAogASgIEiEKGXRvZGF5X3N1cHBvcnRlcl91c2VfY291bnQY" + "CyABKAUSJAocdG90YWxfc3VwcG9ydGVyX3JlbnRhbF9jb3VudBgMIAEoBRIX" + "Cg90b3BfZ3VpbGRfc2NvcmUYDSABKAMSEAoIcGxheV9kYXkYDiADKAhiBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidMainInfoResponse), GuildRaidMainInfoResponse.Parser, new string[14]
		{
			"Season", "RaidDay", "TodayNormalBattleCount", "UserScore", "LastScoreRewardId", "GuildTotalScore", "GuildTopPercent", "GolemLevel", "GolemExp", "ObtainableSeasonReward",
			"TodaySupporterUseCount", "TotalSupporterRentalCount", "TopGuildScore", "PlayDay"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
