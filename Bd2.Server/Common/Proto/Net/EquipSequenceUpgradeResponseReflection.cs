using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSequenceUpgradeResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXNwb25zZS9FcXVpcFNlcXVlbmNlVXBncmFkZVJlc3BvbnNlLnByb3Rv" + "Eglwcm90by5uZXQaGUNvbW1vbnMvRXF1aXBEQkluZm8ucHJvdG8aFENvbW1v" + "bnMvRGVmaW5lLnByb3RvGhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8aGENv" + "bW1vbnMvQ2hhckRCSW5mby5wcm90byLCAgocRXF1aXBTZXF1ZW5jZVVwZ3Jh" + "ZGVSZXNwb25zZRIqCgplcXVpcF9pbmZvGAEgASgLMhYucHJvdG8ubmV0LkVx" + "dWlwREJJbmZvEigKCWNoYXJfaW5mbxgCIAEoCzIVLnByb3RvLm5ldC5DaGFy" + "REJJbmZvEj0KC3Jlc3VsdF90eXBlGAMgASgOMigucHJvdG8ubmV0LkRlZmlu" + "ZV9FcXVpcFVwZ3JhZGVSZXN1bHRUeXBlEhEKCXRyeV9jb3VudBgEIAEoBRIw" + "ChFjb25zdW1lX2l0ZW1faW5mbxgFIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJ" + "bmZvEi0KDmxhY2tfaXRlbV9pbmZvGAYgAygLMhUucHJvdG8ubmV0Lkl0ZW1E" + "QkluZm8SGQoRdXBncmFkZV91c2VkX2dvbGQYByABKAViBnByb3RvMw=="), new FileDescriptor[4]
	{
		EquipDBInfoReflection.Descriptor,
		DefineReflection.Descriptor,
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSequenceUpgradeResponse), EquipSequenceUpgradeResponse.Parser, new string[7] { "EquipInfo", "CharInfo", "ResultType", "TryCount", "ConsumeItemInfo", "LackItemInfo", "UpgradeUsedGold" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
