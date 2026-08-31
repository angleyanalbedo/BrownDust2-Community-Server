using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntUserDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL01vbnN0ZXJIdW50VXNlckRCSW5mby5wcm90bxIJcHJvdG8u" + "bmV0IowCChVNb25zdGVySHVudFVzZXJEQkluZm8SDgoGc2Vhc29uGAEgASgF" + "EhcKD21vbnN0ZXJfaHVudF9pZBgCIAEoBRINCgVsZXZlbBgDIAEoBRIQCghz" + "dGFydF9ocBgEIAEoAxIhChloaWdoZXN0X2ZpcnN0X3R1cm5fZGFtYWdlGAUg" + "ASgFEhIKCmhpZ2hlc3RfaHAYBiABKAMSFwoPaGlnaGVzdF9ocF9kYXRlGAcg" + "ASgDEiQKHGN1cnJlbnRfbGV2ZWxfaGlnaGVzdF9kYW1hZ2UYCCABKAMSHAoU" + "ZGFpbHlfaGlnaGVzdF9kYW1hZ2UYCSABKAMSFQoNc2Vhc29uX3Jld2FyZBgK" + "IAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntUserDBInfo), MonsterHuntUserDBInfo.Parser, new string[10] { "Season", "MonsterHuntId", "Level", "StartHp", "HighestFirstTurnDamage", "HighestHp", "HighestHpDate", "CurrentLevelHighestDamage", "DailyHighestDamage", "SeasonReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
