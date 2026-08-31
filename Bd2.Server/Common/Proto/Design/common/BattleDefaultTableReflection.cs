using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BattleDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvQmF0dGxlVGFibGVfX1/soITtiKwvQmF0dGxlRGVmYXVs" + "dFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoEHChJCYXR0bGVE" + "ZWZhdWx0VGFibGUSDgoGQXRrTWF4GAEgASgFEg4KBkF0a01pbhgCIAEoBRIP" + "CgdDcmlETWF4GAMgASgBEg8KB0NyaURNaW4YBCABKAESDgoGQ3JpTWF4GAUg" + "ASgBEg4KBkNyaU1pbhgGIAEoARIOCgZEZWZNYXgYByABKAESDgoGRGVmTWlu" + "GAggASgBEiwKJEZpZWxkT2JqZWN0QmF0dGxlUmVhcnJhbmdlRWZmZWN0VGlt" + "ZRgJIAEoBRImCh5GaWVsZE9iamVjdEJhdHRsZVJlYXJyYW5nZVRpbWUYCiAB" + "KAUSEgoKSHBNYXhMaW1pdBgLIAEoBRIjChtiYXR0bGVDb250aW51ZUNvc3RJ" + "dGVtQ291bnQYDCABKAUSIAoYYmF0dGxlQ29udGludWVDb3N0SXRlbUlkGA0g" + "ASgFEiIKGmJhdHRsZUNvbnRpbnVlQ29zdEl0ZW1UeXBlGA4gASgFEh4KFmJh" + "dHRsZUNvbnRpbnVlTWF4Q291bnQYDyABKAUSGAoQYmF0dGxlUG93ZXJDb25z" + "dBgQIAEoBRIYChBjaGFpbkRhbWFnZVZhbHVlGBEgASgBEhUKDWNoYWluTWF4" + "Q291bnQYEiABKAUSFwoPZGVhdGhUaW1lQnVmZklkGBMgASgFEh0KFWRlYXRo" + "VGltZVN0YXJ0VHVyblB2UBgUIAEoBRIUCgxmcm9udE1vdmVTZWMYFSABKAES" + "CgoCaWQYFiABKAUSFwoPbWluQXR0YWNrRGFtYWdlGBcgASgFEhMKC3NpZGVN" + "b3ZlU2VjGBggASgBEhIKCnNwTWF4Q291bnQYGSABKAUSGgoSc3BTdGFydEh1" + "bnRlckNvdW50GBogASgFEhcKD3NwU3RhcnRQdkVDb3VudBgbIAEoBRIbChNz" + "cFN0YXJ0UHZQQkxVRUNvdW50GBwgASgFEhoKEnNwU3RhcnRQdlBSRURDb3Vu" + "dBgdIAEoBRIcChRzcFR1cm5BZGRIdW50ZXJDb3VudBgeIAEoBRIZChFzcFR1" + "cm5BZGRQdkVDb3VudBgfIAEoBRIZChFzcFR1cm5BZGRQdlBDb3VudBggIAEo" + "BRIbChNzdHJvbmdFbGVtZW50RWZmZWN0GCEgASgBEhMKC3R1cm5QYXNzU2Vj" + "GCIgASgBEhkKEXdlYWtFbGVtZW50RWZmZWN0GCMgASgBQkRCE1Byb3RvLkRl" + "c2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8u" + "RGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleDefaultTable), BattleDefaultTable.Parser, new string[35]
		{
			"AtkMax", "AtkMin", "CriDMax", "CriDMin", "CriMax", "CriMin", "DefMax", "DefMin", "FieldObjectBattleRearrangeEffectTime", "FieldObjectBattleRearrangeTime",
			"HpMaxLimit", "BattleContinueCostItemCount", "BattleContinueCostItemId", "BattleContinueCostItemType", "BattleContinueMaxCount", "BattlePowerConst", "ChainDamageValue", "ChainMaxCount", "DeathTimeBuffId", "DeathTimeStartTurnPvP",
			"FrontMoveSec", "Id", "MinAttackDamage", "SideMoveSec", "SpMaxCount", "SpStartHunterCount", "SpStartPvECount", "SpStartPvPBLUECount", "SpStartPvPREDCount", "SpTurnAddHunterCount",
			"SpTurnAddPvECount", "SpTurnAddPvPCount", "StrongElementEffect", "TurnPassSec", "WeakElementEffect"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
