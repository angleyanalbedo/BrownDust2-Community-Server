using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PvpRankTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvUFZQVGFibGVfX1/qsbDsmrjsoITsn4EvUHZwUmFua1Rh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIp4ECgxQdnBSYW5rVGFi" + "bGUSHQoVYmF0dGxlTG9zZVJld2FyZENvdW50GAEgAygFEhoKEmJhdHRsZUxv" + "c2VSZXdhcmRJZBgCIAMoBRIcChRiYXR0bGVMb3NlUmV3YXJkVHlwZRgDIAMo" + "BRIcChRiYXR0bGVXaW5SZXdhcmRDb3VudBgEIAMoBRIZChFiYXR0bGVXaW5S" + "ZXdhcmRJZBgFIAMoBRIbChNiYXR0bGVXaW5SZXdhcmRUeXBlGAYgAygFEg8K" + "B2dyb3VwSWQYByABKAUSFgoOaWNvblNwcml0ZU5hbWUYCCABKAkSCgoCaWQY" + "CSABKAUSDQoFaXNFTE8YCiABKAUSEQoJbG9zZVBvaW50GAsgASgFEiIKGnBy" + "b21vdGlvblJld2FyZFJhbmRvbUJveElkGAwgASgFEhIKCnB2cFJhbmtpbmcY" + "DSABKAUSEwoLcmFua0dyb3VwSWQYDiABKAUSHAoUcmFua0dyb3VwTG9jYWxU" + "ZXh0SWQYDyABKAUSGwoTcmFua05hbWVMb2NhbFRleHRJZBgQIAEoBRIZChFz" + "ZWFzb25SZXdhcmRDb3VudBgRIAMoBRIWCg5zZWFzb25SZXdhcmRJZBgSIAMo" + "BRIYChBzZWFzb25SZXdhcmRUeXBlGBMgAygFEhUKDXNlYXNvblN0YXJ0VlAY" + "FCABKAUSCgoCdnAYFSABKAUSEAoId2luUG9pbnQYFiABKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpRankTable), PvpRankTable.Parser, new string[22]
		{
			"BattleLoseRewardCount", "BattleLoseRewardId", "BattleLoseRewardType", "BattleWinRewardCount", "BattleWinRewardId", "BattleWinRewardType", "GroupId", "IconSpriteName", "Id", "IsELO",
			"LosePoint", "PromotionRewardRandomBoxId", "PvpRanking", "RankGroupId", "RankGroupLocalTextId", "RankNameLocalTextId", "SeasonRewardCount", "SeasonRewardId", "SeasonRewardType", "SeasonStartVP",
			"Vp", "WinPoint"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
