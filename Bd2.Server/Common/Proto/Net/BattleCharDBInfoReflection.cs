using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleCharDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0JhdHRsZUNoYXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldBoa" + "Q29tbW9ucy9CdWZmTGlzdEluZm8ucHJvdG8ihAwKEEJhdHRsZUNoYXJEQklu" + "Zm8SFAoMdW5pcXVlX2luZGV4GAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgD" + "EgoKAmlkGAMgASgFEgoKAmhwGAQgASgDEg0KBWxldmVsGAUgASgFEhsKE2Nv" + "c3R1bWVfaW52ZW5faW5kZXgYBiABKAMSEgoKY29zdHVtZV9pZBgHIAEoBRIV" + "Cg1jb3N0dW1lX2xldmVsGAggASgFEhIKCmdyaWRfaW5kZXgYCSABKAUSGgoS" + "cmVzZXJ2ZV9jb3N0dW1lX2lkGAogASgFEh8KF2lzX2FjdGl2ZV9zdWJfc2tp" + "bGxfdXNlGAsgASgIEhMKC2VxdWlwX2luZGV4GAwgAygDEiwKCWJ1ZmZfbGlz" + "dBgNIAMoCzIZLnByb3RvLm5ldC5TZXJ2ZXJCdWZmTGlzdBIlCgVkb2RnZRgO" + "IAMoCzIWLnByb3RvLm5ldC5TZXJ2ZXJEb2RnZRIpCgdyZXZpdmFsGA8gAygL" + "MhgucHJvdG8ubmV0LlNlcnZlclJldml2YWwSMgoMYmFycmllcl9idWZmGBAg" + "AygLMhwucHJvdG8ubmV0LlNlcnZlckJhcnJpZXJCdWZmEjIKDGVsZW1lbnRf" + "YnVmZhgRIAMoCzIcLnByb3RvLm5ldC5TZXJ2ZXJFbGVtZW50QnVmZhIyCgxl" + "bmVyZ3lfZ3VhcmQYEiADKAsyHC5wcm90by5uZXQuU2VydmVyRW5lcmd5R3Vh" + "cmQSOQoQd291bmRlZF9hZGRfYnVmZhgTIAMoCzIfLnByb3RvLm5ldC5TZXJ2" + "ZXJXb3VuZGVkQWRkQnVmZhI4Cg92dWxuZXJhYmxlX2J1ZmYYFCADKAsyHy5w" + "cm90by5uZXQuU2VydmVyVnVsbmVyYWJsZUJ1ZmYSJwoEYXVyYRgVIAMoCzIZ" + "LnByb3RvLm5ldC5TZXJ2ZXJBdXJhQnVmZhI3Cg50cmFuc2Zvcm1hdGlvbhgW" + "IAMoCzIfLnByb3RvLm5ldC5TZXJ2ZXJUcmFuc2Zvcm1hdGlvbhIuCgpjaGFp" + "bl9idWZmGBcgAygLMhoucHJvdG8ubmV0LlNlcnZlckNoYWluQnVmZhI3Cg5i" + "dWZmX3BsdXNfc3RhdBgYIAEoCzIfLnByb3RvLm5ldC5TZXJ2ZXJCYXR0bGVD" + "aGFyU3RhdBI7ChJidWZmX211bHRpcGxlX3N0YXQYGSABKAsyHy5wcm90by5u" + "ZXQuU2VydmVyQmF0dGxlQ2hhclN0YXQSFQoNYXR0YWNrX2RhbWFnZRgaIAEo" + "AxIUCgxiYXR0bGVfcG93ZXIYGyABKAUSGwoTdG90YWxfd2FyX3BsYXlfdHlw" + "ZRgcIAEoBRIhChljb25uZWN0X3BvdGVudGlhbF9jb3N0dW1lGB0gASgFEhwK" + "FHBvdGVudGlhbF9jb3N0dW1lX2lkGB4gAygFEioKInByaW9yaXR5X3NraWxs" + "X2Nvc3R1bWVfaW52ZW5faW5kZXgYHyADKAMSRQoOc2tpbGxfdHVybl9kaWMY" + "ICADKAsyLS5wcm90by5uZXQuQmF0dGxlQ2hhckRCSW5mby5Ta2lsbFR1cm5E" + "aWNFbnRyeRIXCg90YXJnZXRpbmdfY291bnQYISABKAUSOQoQY2hhaW5fYm9u" + "dXNfYnVmZhgiIAMoCzIfLnByb3RvLm5ldC5TZXJ2ZXJDaGFpbkJvbnVzQnVm" + "ZhIwCgtjaGFpbl9saW1pdBgjIAMoCzIbLnByb3RvLm5ldC5TZXJ2ZXJDaGFp" + "bkxpbWl0EjgKD2VuaGFuY2VkX2RhbWFnZRgkIAMoCzIfLnByb3RvLm5ldC5T" + "ZXJ2ZXJFbmhhbmNlZERhbWFnZRInCgZpbW11bmUYJSADKAsyFy5wcm90by5u" + "ZXQuU2VydmVySW1tdW5lEh0KFXN1cHBvcnRlcl9vd25lcl9pbmRleBgmIAEo" + "AxIcChRzdXBwb3J0ZXJfc2xvdF9pbmRleBgnIAEoBRozChFTa2lsbFR1cm5E" + "aWNFbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgBYgZwcm90" + "bzM="), new FileDescriptor[1] { BuffListInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleCharDBInfo), BattleCharDBInfo.Parser, new string[39]
		{
			"UniqueIndex", "InvenIndex", "Id", "Hp", "Level", "CostumeInvenIndex", "CostumeId", "CostumeLevel", "GridIndex", "ReserveCostumeId",
			"IsActiveSubSkillUse", "EquipIndex", "BuffList", "Dodge", "Revival", "BarrierBuff", "ElementBuff", "EnergyGuard", "WoundedAddBuff", "VulnerableBuff",
			"Aura", "Transformation", "ChainBuff", "BuffPlusStat", "BuffMultipleStat", "AttackDamage", "BattlePower", "TotalWarPlayType", "ConnectPotentialCostume", "PotentialCostumeId",
			"PrioritySkillCostumeInvenIndex", "SkillTurnDic", "TargetingCount", "ChainBonusBuff", "ChainLimit", "EnhancedDamage", "Immune", "SupporterOwnerIndex", "SupporterSlotIndex"
		}, null, null, null, new GeneratedClrTypeInfo[1])
	}));

	public static FileDescriptor Descriptor => descriptor;
}
