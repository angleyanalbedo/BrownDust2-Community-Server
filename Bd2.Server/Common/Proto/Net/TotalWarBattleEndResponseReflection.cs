using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarBattleEndResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9Ub3RhbFdhckJhdHRsZUVuZFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIENvbW1vbnMvQmF0dGxlRGFtYWdlREJJbmZvLnByb3RvImMK" + "GVRvdGFsV2FyQmF0dGxlRW5kUmVzcG9uc2USMQoKc2NvcmVfaW5mbxgBIAMo" + "CzIdLnByb3RvLm5ldC5CYXR0bGVEYW1hZ2VEQkluZm8SEwoLdG9wX3BlcmNl" + "bnQYAiABKAFiBnByb3RvMw=="), new FileDescriptor[1] { BattleDamageDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarBattleEndResponse), TotalWarBattleEndResponse.Parser, new string[2] { "ScoreInfo", "TopPercent" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
