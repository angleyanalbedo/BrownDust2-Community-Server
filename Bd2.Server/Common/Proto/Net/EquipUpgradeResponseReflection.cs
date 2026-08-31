using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipUpgradeResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9FcXVpcFVwZ3JhZGVSZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0GhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGhhDb21tb25zL0NoYXJE" + "QkluZm8ucHJvdG8aFENvbW1vbnMvRGVmaW5lLnByb3RvIqsBChRFcXVpcFVw" + "Z3JhZGVSZXNwb25zZRIqCgplcXVpcF9pbmZvGAEgASgLMhYucHJvdG8ubmV0" + "LkVxdWlwREJJbmZvEj0KC3Jlc3VsdF90eXBlGAIgASgOMigucHJvdG8ubmV0" + "LkRlZmluZV9FcXVpcFVwZ3JhZGVSZXN1bHRUeXBlEigKCWNoYXJfaW5mbxgD" + "IAEoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvYgZwcm90bzM="), new FileDescriptor[3]
	{
		EquipDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipUpgradeResponse), EquipUpgradeResponse.Parser, new string[3] { "EquipInfo", "ResultType", "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
