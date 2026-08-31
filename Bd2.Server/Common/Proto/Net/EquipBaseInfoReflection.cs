using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBaseInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL0VxdWlwQmFzZUluZm8ucHJvdG8SCXByb3RvLm5ldBodQ29t" + "bW9ucy9FcXVpcE9wdGlvbkluZm8ucHJvdG8izQEKDUVxdWlwQmFzZUluZm8S" + "CgoCaWQYASABKAUSDQoFbGV2ZWwYAiABKAUSLwoLbWFpbl9vcHRpb24YAyAD" + "KAsyGi5wcm90by5uZXQuRXF1aXBPcHRpb25JbmZvEi4KCnN1Yl9vcHRpb24Y" + "BCADKAsyGi5wcm90by5uZXQuRXF1aXBPcHRpb25JbmZvEjIKDnByaXZhdGVf" + "b3B0aW9uGAUgASgLMhoucHJvdG8ubmV0LkVxdWlwT3B0aW9uSW5mbxIMCgRy" + "YW5rGAYgAygFYgZwcm90bzM="), new FileDescriptor[1] { EquipOptionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBaseInfo), EquipBaseInfo.Parser, new string[6] { "Id", "Level", "MainOption", "SubOption", "PrivateOption", "Rank" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
