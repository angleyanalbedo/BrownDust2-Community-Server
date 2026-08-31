using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PvpRankTableV1Reflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUFZQVGFibGVfX1/qsbDsmrjsoITsn4EvUHZwUmFua1Rh" + "YmxlVjEucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i/wMKDlB2cFJhbmtU" + "YWJsZVYxEh0KFWJhdHRsZUxvc2VSZXdhcmRDb3VudBgBIAMoBRIaChJiYXR0" + "bGVMb3NlUmV3YXJkSWQYAiADKAUSHAoUYmF0dGxlTG9zZVJld2FyZFR5cGUY" + "AyADKAUSHAoUYmF0dGxlV2luUmV3YXJkQ291bnQYBCADKAUSGQoRYmF0dGxl" + "V2luUmV3YXJkSWQYBSADKAUSGwoTYmF0dGxlV2luUmV3YXJkVHlwZRgGIAMo" + "BRIWCg5pY29uU3ByaXRlTmFtZRgHIAEoCRIKCgJpZBgIIAEoBRIRCglsb3Nl" + "UG9pbnQYCSABKAUSHAoUcHJvbW90aW9uUmV3YXJkQ291bnQYCiADKAUSGQoR" + "cHJvbW90aW9uUmV3YXJkSWQYCyADKAUSGwoTcHJvbW90aW9uUmV3YXJkVHlw" + "ZRgMIAMoBRISCgpwdnBSYW5raW5nGA0gASgFEhsKE3JhbmtOYW1lTG9jYWxU" + "ZXh0SWQYDiABKAUSGQoRc2Vhc29uUmV3YXJkQ291bnQYDyADKAUSFgoOc2Vh" + "c29uUmV3YXJkSWQYECADKAUSGAoQc2Vhc29uUmV3YXJkVHlwZRgRIAMoBRIV" + "Cg1zZWFzb25TdGFydFZQGBIgASgFEgoKAnZwGBMgASgFEhAKCHdpblBvaW50" + "GBQgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpRankTableV1), PvpRankTableV1.Parser, new string[20]
		{
			"BattleLoseRewardCount", "BattleLoseRewardId", "BattleLoseRewardType", "BattleWinRewardCount", "BattleWinRewardId", "BattleWinRewardType", "IconSpriteName", "Id", "LosePoint", "PromotionRewardCount",
			"PromotionRewardId", "PromotionRewardType", "PvpRanking", "RankNameLocalTextId", "SeasonRewardCount", "SeasonRewardId", "SeasonRewardType", "SeasonStartVP", "Vp", "WinPoint"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
