using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleResultDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL0JhdHRsZVJlc3VsdERCSW5mby5wcm90bxIJcHJvdG8ubmV0" + "Gh5Db21tb25zL0JhdHRsZUNoYXJEQkluZm8ucHJvdG8aJENvbW1vbnMvQmF0" + "dGxlU3RhdGlzdGljc0RCSW5mby5wcm90bxomQ29tbW9ucy9CYXR0bGVHcmlk" + "VHlwZUl0ZW1EQkluZm8ucHJvdG8aH0NvbW1vbnMvQmF0dGxlR29sZW1EQklu" + "Zm8ucHJvdG8ivAMKEkJhdHRsZVJlc3VsdERCSW5mbxIVCg1iYXR0bGVfcmVz" + "dWx0GAEgASgFEjIKDXJlZF9jaGFyX2luZm8YAiADKAsyGy5wcm90by5uZXQu" + "QmF0dGxlQ2hhckRCSW5mbxIzCg5ibHVlX2NoYXJfaW5mbxgDIAMoCzIbLnBy" + "b3RvLm5ldC5CYXR0bGVDaGFyREJJbmZvEjYKCWdyaWRfaXRlbRgEIAMoCzIj" + "LnByb3RvLm5ldC5CYXR0bGVHcmlkVHlwZUl0ZW1EQkluZm8SQQoWYmF0dGxl" + "X3N0YXRpc3RpY3NfaW5mbxgFIAEoCzIhLnByb3RvLm5ldC5CYXR0bGVTdGF0" + "aXN0aWNzREJJbmZvEjAKCmdvbGVtX2luZm8YBiABKAsyHC5wcm90by5uZXQu" + "QmF0dGxlR29sZW1EQkluZm8SOwoWcmVkX2RlY2tfb3V0X2NoYXJfaW5mbxgH" + "IAMoCzIbLnByb3RvLm5ldC5CYXR0bGVDaGFyREJJbmZvEjwKF2JsdWVfZGVj" + "a19vdXRfY2hhcl9pbmZvGAggAygLMhsucHJvdG8ubmV0LkJhdHRsZUNoYXJE" + "QkluZm9iBnByb3RvMw=="), new FileDescriptor[4]
	{
		BattleCharDBInfoReflection.Descriptor,
		BattleStatisticsDBInfoReflection.Descriptor,
		BattleGridTypeItemDBInfoReflection.Descriptor,
		BattleGolemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleResultDBInfo), BattleResultDBInfo.Parser, new string[8] { "BattleResult", "RedCharInfo", "BlueCharInfo", "GridItem", "BattleStatisticsInfo", "GolemInfo", "RedDeckOutCharInfo", "BlueDeckOutCharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
