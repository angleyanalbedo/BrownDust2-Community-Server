using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleStatisticsDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb21tb25zL0JhdHRsZVN0YXRpc3RpY3NEQkluZm8ucHJvdG8SCXByb3Rv" + "Lm5ldBogQ29tbW9ucy9CYXR0bGVEYW1hZ2VEQkluZm8ucHJvdG8ikAEKFkJh" + "dHRsZVN0YXRpc3RpY3NEQkluZm8SOQoSYXR0YWNrX2RhbWFnZV9pbmZvGAEg" + "AygLMh0ucHJvdG8ubmV0LkJhdHRsZURhbWFnZURCSW5mbxI7ChRyZWNlaXZl" + "ZF9kYW1hZ2VfaW5mbxgCIAMoCzIdLnByb3RvLm5ldC5CYXR0bGVEYW1hZ2VE" + "QkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { BattleDamageDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleStatisticsDBInfo), BattleStatisticsDBInfo.Parser, new string[2] { "AttackDamageInfo", "ReceivedDamageInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
