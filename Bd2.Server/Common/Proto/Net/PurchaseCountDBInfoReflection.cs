using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PurchaseCountDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL1B1cmNoYXNlQ291bnREQkluZm8ucHJvdG8SCXByb3RvLm5ldCJWChNQdXJjaGFzZUNvdW50REJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEgoKAmlkGAIgASgFEhIKCnNhbGVfZ3JvdXAYAyABKAUSDQoFY291bnQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PurchaseCountDBInfo), PurchaseCountDBInfo.Parser, new string[4] { "GroupId", "Id", "SaleGroup", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
