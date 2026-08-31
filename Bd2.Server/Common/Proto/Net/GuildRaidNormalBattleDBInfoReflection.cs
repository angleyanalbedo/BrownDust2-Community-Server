using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidNormalBattleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilDb21tb25zL0d1aWxkUmFpZE5vcm1hbEJhdHRsZURCSW5mby5wcm90bxIJ" + "cHJvdG8ubmV0IoYBChtHdWlsZFJhaWROb3JtYWxCYXR0bGVEQkluZm8SEAoI" + "Z3JvdXBfaWQYASABKAUSCgoCaWQYAiABKAUSDQoFbGV2ZWwYAyABKAUSGgoS" + "Y29tcGxldGVfd2luX2NvdW50GAQgASgFEh4KFmJhdHRsZV9jaGFsbGVuZ2Vf" + "aW5kZXgYBSADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidNormalBattleDBInfo), GuildRaidNormalBattleDBInfo.Parser, new string[5] { "GroupId", "Id", "Level", "CompleteWinCount", "BattleChallengeIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
