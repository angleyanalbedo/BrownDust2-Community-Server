using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemMaterialInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0l0ZW1NYXRlcmlhbEluZm8ucHJvdG8SCXByb3RvLm5ldCJQChBJdGVtTWF0ZXJpYWxJbmZvEhMKC2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIgASgFEgwKBHR5cGUYAyABKAUSDQoFY291bnQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemMaterialInfo), ItemMaterialInfo.Parser, new string[4] { "InvenIndex", "Id", "Type", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
