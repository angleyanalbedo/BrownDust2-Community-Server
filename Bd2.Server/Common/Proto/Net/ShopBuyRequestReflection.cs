using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L1Nob3BCdXlSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaHENv" + "bW1vbnMvU2hvcEl0ZW1EQkluZm8ucHJvdG8aGENvbW1vbnMvSXRlbURCSW5m" + "by5wcm90byKKAQoOU2hvcEJ1eVJlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3No" + "b3BfaWQYAiABKAUSLAoJaXRlbV9pbmZvGAMgASgLMhkucHJvdG8ubmV0LlNo" + "b3BJdGVtREJJbmZvEiwKDXVzZV9pdGVtX2luZm8YBCADKAsyFS5wcm90by5u" + "ZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		ShopItemDBInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopBuyRequest), ShopBuyRequest.Parser, new string[4] { "Seq", "ShopId", "ItemInfo", "UseItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
