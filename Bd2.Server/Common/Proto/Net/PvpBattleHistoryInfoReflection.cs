using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleHistoryInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL1B2cEJhdHRsZUhpc3RvcnlJbmZvLnByb3RvEglwcm90by5u" + "ZXQiiQIKFFB2cEJhdHRsZUhpc3RvcnlJbmZvEhQKDGJhdHRsZV9pbmRleBgB" + "IAEoAxIVCg1iYXR0bGVfcmVzdWx0GAIgASgFEhkKEWVuZW15X293bmVyX2lu" + "ZGV4GAMgASgDEhUKDWVuZW15X3VzZXJfaWQYBCABKAkSEAoIZW5lbXlfdnAY" + "BSABKAUSEgoKZW5lbXlfcmFuaxgGIAEoBRIYChBlbmVteV9jb3N0dW1lX2lk" + "GAcgAygDEhEKCWNoYW5nZV92cBgIIAEoBRIXCg9jb250aW51ZV93aW5fdnAY" + "CSABKAUSEgoKdGltZV92YWx1ZRgKIAEoAxISCgppc19ub19nYW1lGAsgASgI" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleHistoryInfo), PvpBattleHistoryInfo.Parser, new string[11]
		{
			"BattleIndex", "BattleResult", "EnemyOwnerIndex", "EnemyUserId", "EnemyVp", "EnemyRank", "EnemyCostumeId", "ChangeVp", "ContinueWinVp", "TimeValue",
			"IsNoGame"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
