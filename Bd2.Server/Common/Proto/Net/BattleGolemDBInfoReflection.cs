using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleGolemDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0JhdHRsZUdvbGVtREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "3wEKEUJhdHRsZUdvbGVtREJJbmZvEg0KBWxldmVsGAEgASgFEg0KBWdhdWdl" + "GAIgASgBEhMKC3JlbWFpbl90dXJuGAMgASgFEhoKEnJlc2VydmVfY29zdHVt" + "ZV9pZBgEIAEoBRJGCg5za2lsbF90dXJuX2RpYxgFIAMoCzIuLnByb3RvLm5l" + "dC5CYXR0bGVHb2xlbURCSW5mby5Ta2lsbFR1cm5EaWNFbnRyeRozChFTa2ls" + "bFR1cm5EaWNFbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgB" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleGolemDBInfo), BattleGolemDBInfo.Parser, new string[5] { "Level", "Gauge", "RemainTurn", "ReserveCostumeId", "SkillTurnDic" }, null, null, null, new GeneratedClrTypeInfo[1])
	}));

	public static FileDescriptor Descriptor => descriptor;
}
