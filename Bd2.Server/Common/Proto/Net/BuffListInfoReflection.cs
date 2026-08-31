using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BuffListInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL0J1ZmZMaXN0SW5mby5wcm90bxIJcHJvdG8ubmV0ImQKDlNl" + "cnZlckJ1ZmZMaXN0EgoKAmlkGAEgASgFEhIKCnR1cm5fY291bnQYAiABKAUS" + "FwoPb3duZXJfdW5pcXVlX2lkGAMgASgDEhkKEWNyZWF0b3JfdW5pcXVlX2lk" + "GAQgASgDIngKC1NlcnZlckRvZGdlEgoKAmlkGAEgASgFEhIKCnR1cm5fY291" + "bnQYAiABKAUSFQoNc3VjY2Vzc19jb3VudBgDIAEoBRIXCg9vd25lcl91bmlx" + "dWVfaWQYBCABKAMSGQoRY3JlYXRvcl91bmlxdWVfaWQYBSABKAMiYwoNU2Vy" + "dmVyUmV2aXZhbBIKCgJpZBgBIAEoBRISCgp0dXJuX2NvdW50GAIgASgFEhcK" + "D293bmVyX3VuaXF1ZV9pZBgDIAEoAxIZChFjcmVhdG9yX3VuaXF1ZV9pZBgE" + "IAEoAyJnChFTZXJ2ZXJCYXJyaWVyQnVmZhIKCgJpZBgBIAEoBRISCgp0dXJu" + "X2NvdW50GAIgASgFEhcKD293bmVyX3VuaXF1ZV9pZBgDIAEoAxIZChFjcmVh" + "dG9yX3VuaXF1ZV9pZBgEIAEoAyJnChFTZXJ2ZXJFbGVtZW50QnVmZhIKCgJp" + "ZBgBIAEoBRISCgp0dXJuX2NvdW50GAIgASgFEhcKD293bmVyX3VuaXF1ZV9p" + "ZBgDIAEoAxIZChFjcmVhdG9yX3VuaXF1ZV9pZBgEIAEoAyJqChRTZXJ2ZXJX" + "b3VuZGVkQWRkQnVmZhIKCgJpZBgBIAEoBRISCgp0dXJuX2NvdW50GAIgASgF" + "EhcKD293bmVyX3VuaXF1ZV9pZBgDIAEoAxIZChFjcmVhdG9yX3VuaXF1ZV9p" + "ZBgEIAEoAyKZAQoRU2VydmVyRW5lcmd5R3VhcmQSCgoCaWQYASABKAUSEgoK" + "dHVybl9jb3VudBgCIAEoBRIVCg1yZW1haW5fZW5lcmd5GAMgASgDEhcKD293" + "bmVyX3VuaXF1ZV9pZBgEIAEoAxIZChFjcmVhdG9yX3VuaXF1ZV9pZBgFIAEo" + "AxIZChFtYXhfcmVtYWluX2VuZXJneRgGIAEoAyLSAgoUU2VydmVyQmF0dGxl" + "Q2hhclN0YXQSEgoKbWF4X2hlYWx0aBgBIAEoARIWCg5jdXJyZW50X2hlYWx0" + "aBgCIAEoARIVCg1hZ2lsaXR5X3ZhbHVlGAMgASgBEhwKFHBoeXNpY2FsX3Bv" + "d2VyX3ZhbHVlGAQgASgBEhkKEW1hZ2ljX3Bvd2VyX3ZhbHVlGAUgASgBEh4K" + "FnBoeXNpY2FsX2RlZmVuc2VfdmFsdWUYBiABKAESGwoTbWFnaWNfZGVmZW5z" + "ZV92YWx1ZRgHIAEoARIdChVjcml0aWNhbF9jaGFuY2VfdmFsdWUYCCABKAES" + "IgoaY3JpdGljYWxfZGFtYWdlX3JhdGVfdmFsdWUYCSABKAESHAoUZWxlbWVu" + "dF9kYW1hZ2VfdmFsdWUYCiABKAESIAoYZWxlbWVudF9yZXNpc3RhbmNlX3Zh" + "bHVlGAsgASgBImoKFFNlcnZlclZ1bG5lcmFibGVCdWZmEgoKAmlkGAEgASgF" + "EhIKCnR1cm5fY291bnQYAiABKAUSFwoPb3duZXJfdW5pcXVlX2lkGAMgASgD" + "EhkKEWNyZWF0b3JfdW5pcXVlX2lkGAQgASgDIpYBCg5TZXJ2ZXJBdXJhQnVm" + "ZhIKCgJpZBgBIAEoBRISCgp0dXJuX2NvdW50GAIgASgFEhcKD293bmVyX3Vu" + "aXF1ZV9pZBgDIAEoAxIZChFjcmVhdG9yX3VuaXF1ZV9pZBgEIAEoAxIUCgxh" + "dHRhY2tfcmFuZ2UYBSABKAUSGgoSYXR0YWNrX3JhbmdlX2NvdW50GAYgASgF" + "In4KFFNlcnZlclRyYW5zZm9ybWF0aW9uEgoKAmlkGAEgASgFEhIKCnR1cm5f" + "Y291bnQYAiABKAUSFwoPb3duZXJfdW5pcXVlX2lkGAMgASgDEhkKEWNyZWF0" + "b3JfdW5pcXVlX2lkGAQgASgDEhIKCmNvc3R1bWVfaWQYBSABKAUiZQoPU2Vy" + "dmVyQ2hhaW5CdWZmEgoKAmlkGAEgASgFEhIKCnR1cm5fY291bnQYAiABKAUS" + "FwoPb3duZXJfdW5pcXVlX2lkGAMgASgDEhkKEWNyZWF0b3JfdW5pcXVlX2lk" + "GAQgASgDImoKFFNlcnZlckNoYWluQm9udXNCdWZmEgoKAmlkGAEgASgFEhIK" + "CnR1cm5fY291bnQYAiABKAUSFwoPb3duZXJfdW5pcXVlX2lkGAMgASgDEhkK" + "EWNyZWF0b3JfdW5pcXVlX2lkGAQgASgDImYKEFNlcnZlckNoYWluTGltaXQS" + "CgoCaWQYASABKAUSEgoKdHVybl9jb3VudBgCIAEoBRIXCg9vd25lcl91bmlx" + "dWVfaWQYAyABKAMSGQoRY3JlYXRvcl91bmlxdWVfaWQYBCABKAMiagoUU2Vy" + "dmVyRW5oYW5jZWREYW1hZ2USCgoCaWQYASABKAUSEgoKdHVybl9jb3VudBgC" + "IAEoBRIXCg9vd25lcl91bmlxdWVfaWQYAyABKAMSGQoRY3JlYXRvcl91bmlx" + "dWVfaWQYBCABKAMiYgoMU2VydmVySW1tdW5lEgoKAmlkGAEgASgFEhIKCnR1" + "cm5fY291bnQYAiABKAUSFwoPb3duZXJfdW5pcXVlX2lkGAMgASgDEhkKEWNy" + "ZWF0b3JfdW5pcXVlX2lkGAQgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[16]
	{
		new GeneratedClrTypeInfo(typeof(ServerBuffList), ServerBuffList.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerDodge), ServerDodge.Parser, new string[5] { "Id", "TurnCount", "SuccessCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerRevival), ServerRevival.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerBarrierBuff), ServerBarrierBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerElementBuff), ServerElementBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerWoundedAddBuff), ServerWoundedAddBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerEnergyGuard), ServerEnergyGuard.Parser, new string[6] { "Id", "TurnCount", "RemainEnergy", "OwnerUniqueId", "CreatorUniqueId", "MaxRemainEnergy" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerBattleCharStat), ServerBattleCharStat.Parser, new string[11]
		{
			"MaxHealth", "CurrentHealth", "AgilityValue", "PhysicalPowerValue", "MagicPowerValue", "PhysicalDefenseValue", "MagicDefenseValue", "CriticalChanceValue", "CriticalDamageRateValue", "ElementDamageValue",
			"ElementResistanceValue"
		}, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerVulnerableBuff), ServerVulnerableBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerAuraBuff), ServerAuraBuff.Parser, new string[6] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId", "AttackRange", "AttackRangeCount" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerTransformation), ServerTransformation.Parser, new string[5] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId", "CostumeId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerChainBuff), ServerChainBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerChainBonusBuff), ServerChainBonusBuff.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerChainLimit), ServerChainLimit.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerEnhancedDamage), ServerEnhancedDamage.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ServerImmune), ServerImmune.Parser, new string[4] { "Id", "TurnCount", "OwnerUniqueId", "CreatorUniqueId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
