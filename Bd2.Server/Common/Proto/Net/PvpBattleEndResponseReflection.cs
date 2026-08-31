using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleEndResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9QdnBCYXR0bGVFbmRSZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8aH0NvbW1vbnMvQ2hhclBh" + "cnRuZXJEQkluZm8ucHJvdG8aJENvbW1vbnMvQmF0dGxlU3RhdGlzdGljc0RC" + "SW5mby5wcm90byKZAgoUUHZwQmF0dGxlRW5kUmVzcG9uc2USFQoNYmF0dGxl" + "X3Jlc3VsdBgBIAEoBRIoCglpdGVtX2luZm8YAiADKAsyFS5wcm90by5uZXQu" + "SXRlbURCSW5mbxI3ChFjaGFyX3BhcnRuZXJfaW5mbxgDIAMoCzIcLnByb3Rv" + "Lm5ldC5DaGFyUGFydG5lckRCSW5mbxIRCgljaGFuZ2VfdnAYBCABKAUSFwoP" + "Y29udGludWVfd2luX3ZwGAUgASgFEkEKFmJhdHRsZV9zdGF0aXN0aWNzX2lu" + "Zm8YBiABKAsyIS5wcm90by5uZXQuQmF0dGxlU3RhdGlzdGljc0RCSW5mbxIY" + "ChBvbmNlX3Jld2FyZF9pbmZvGAcgAygFYgZwcm90bzM="), new FileDescriptor[3]
	{
		ItemDBInfoReflection.Descriptor,
		CharPartnerDBInfoReflection.Descriptor,
		BattleStatisticsDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleEndResponse), PvpBattleEndResponse.Parser, new string[7] { "BattleResult", "ItemInfo", "CharPartnerInfo", "ChangeVp", "ContinueWinVp", "BattleStatisticsInfo", "OnceRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
