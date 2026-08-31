using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SellItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvU2hvcFRhYmxlX19f7J246rKM7J6E7IOB7KCQL1NlbGxJ" + "dGVtVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ivAEKDVNlbGxJ" + "dGVtVGFibGUSFAoMZGlzY291bnRSYXRlGAEgASgFEhQKDGVsZW1lbnRDb3Vu" + "dBgCIAEoBRIRCgllbGVtZW50SWQYAyABKAUSEwoLZWxlbWVudFR5cGUYBCAB" + "KAUSCgoCaWQYBSABKAUSEwoLcHJlbWl1bVJhdGUYBiABKAUSEgoKcHJpY2VD" + "b3VudBgHIAEoBRIPCgdwcmljZUlkGAggASgFEhEKCXByaWNlVHlwZRgJIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SellItemTable), SellItemTable.Parser, new string[9] { "DiscountRate", "ElementCount", "ElementId", "ElementType", "Id", "PremiumRate", "PriceCount", "PriceId", "PriceType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
