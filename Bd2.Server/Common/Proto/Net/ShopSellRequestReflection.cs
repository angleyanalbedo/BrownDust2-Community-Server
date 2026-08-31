using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopSellRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L1Nob3BTZWxsUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL1Nob3BJdGVtREJJbmZvLnByb3RvIl0KD1Nob3BTZWxsUmVxdWVzdBILCgNzZXEYASABKAUSDwoHc2hvcF9pZBgCIAEoBRIsCglpdGVtX2luZm8YAyADKAsyGS5wcm90by5uZXQuU2hvcEl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ShopItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopSellRequest), ShopSellRequest.Parser, new string[3] { "Seq", "ShopId", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
