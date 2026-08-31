using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeShopItemInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1Db21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VTaG9wSXRlbUluZm8ucHJvdG8SCXByb3RvLm5ldCJcCh9FdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcEl0ZW1JbmZvEgwKBHR5cGUYASABKAUSCgoCaWQYAiABKAUSDQoFcHJpY2UYAyABKAUSEAoIc29sZF9vdXQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeShopItemInfo), EvilCastleRogueLikeShopItemInfo.Parser, new string[4] { "Type", "Id", "Price", "SoldOut" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
