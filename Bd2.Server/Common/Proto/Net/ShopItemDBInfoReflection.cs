using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopItemDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL1Nob3BJdGVtREJJbmZvLnByb3RvEglwcm90by5uZXQiUwoOU2hvcEl0ZW1EQkluZm8SEwoLaW52ZW5faW5kZXgYASABKAMSCgoCaWQYAiABKAUSEgoKaXRlbV9jb3VudBgDIAEoBRIMCgRyYXRlGAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopItemDBInfo), ShopItemDBInfo.Parser, new string[4] { "InvenIndex", "Id", "ItemCount", "Rate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
