using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PvpDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvUFZQVGFibGVfX1/qsbDsmrjsoITsn4EvUHZwRGVmYXVs" + "dFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIqUFCg9QdnBEZWZh" + "dWx0VGFibGUSEQoJQmF0dGxlQkdNGAEgASgJEg4KBlZQX01pbhgCIAEoBRIV" + "Cg1iYXR0bGVFbmRUdXJuGAMgASgFEhkKEWJhdHRsZUhpc3RvcnlIb3VyGAQg" + "ASgFEh8KF2JhdHRsZUhpc3RvcnlMaW1pdENvdW50GAUgASgFEiQKHGJhdHRs" + "ZUhpc3RvcnlSZWZyZXNoQ29vbFRpbWUYBiABKAUSGgoSYmF0dGxlUGVuYWx0" + "eVJhdGlvGAcgASgFEhoKEmJhdHRsZVBlbmFsdHlSb3VuZBgIIAEoBRIXCg9i" + "YXR0bGVSZWFkeVRpbWUYCSABKAUSGgoSYmF0dGxlU2tpcFdhaXRUdXJuGAog" + "ASgFEhEKCWNhcmVDb3VudBgLIAEoBRIQCghjYXJlTG9zZRgMIAEoBRIUCgxj" + "YXJlUG9pbnRNYXgYDSABKAUSDwoHY2FyZVdpbhgOIAEoBRIYChBjb3JyZWN0" + "aW9uRmFjdG9yGA8gASgFEgoKAmlkGBAgASgFEhIKCm1hdGNoQ291bnQYESAB" + "KAUSGQoRbWF0Y2hFeGNsdWRlQ291bnQYEiABKAUSFAoMbWF0Y2hWcFJhbmdl" + "GBMgAygFEhIKCm5ld2JpZUNhcmUYFCABKAUSJAoccG9wdWxhckNvc3R1bWVN" + "aW5SYW5rR3JvdXBJZBgVIAEoBRIXCg9wdnBVc2VDb2luQ291bnQYFiABKAUS" + "HAoUcmVwZWF0QmF0dGxlSW50ZXJ2YWwYFyABKAUSGgoSc2VhcmNoaW5nUG9v" + "bENvdW50GBggASgFEg8KB3N0YXJ0VlAYGSABKAUSFwoPdG9wUmFua0JvdW5k" + "YXJ5GBogASgFEhsKE3RvcFJhbmtNYXRjaFZwUmFuZ2UYGyADKAVCREITUHJv" + "dG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQ" + "cm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpDefaultTable), PvpDefaultTable.Parser, new string[27]
		{
			"BattleBGM", "VPMin", "BattleEndTurn", "BattleHistoryHour", "BattleHistoryLimitCount", "BattleHistoryRefreshCoolTime", "BattlePenaltyRatio", "BattlePenaltyRound", "BattleReadyTime", "BattleSkipWaitTurn",
			"CareCount", "CareLose", "CarePointMax", "CareWin", "CorrectionFactor", "Id", "MatchCount", "MatchExcludeCount", "MatchVpRange", "NewbieCare",
			"PopularCostumeMinRankGroupId", "PvpUseCoinCount", "RepeatBattleInterval", "SearchingPoolCount", "StartVP", "TopRankBoundary", "TopRankMatchVpRange"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
