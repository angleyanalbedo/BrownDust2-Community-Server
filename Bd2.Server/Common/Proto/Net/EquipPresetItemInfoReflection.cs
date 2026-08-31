using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetItemInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0VxdWlwUHJlc2V0SXRlbUluZm8ucHJvdG8SCXByb3RvLm5ldCJEChNFcXVpcFByZXNldEl0ZW1JbmZvEhIKCmVxdWlwX3R5cGUYASABKAUSGQoRZXF1aXBfaW52ZW5faW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetItemInfo), EquipPresetItemInfo.Parser, new string[2] { "EquipType", "EquipInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
