using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ProductTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvU2hvcFRhYmxlX19f7J246rKM7J6E7IOB7KCQL1Byb2R1" + "Y3RUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKMAgoMUHJvZHVj" + "dFRhYmxlEhMKC2J1eU1heENvdW50GAEgASgFEhQKDGRpc2NvdW50UmF0ZRgC" + "IAEoBRIUCgxlbGVtZW50Q291bnQYAyABKAUSEQoJZWxlbWVudElkGAQgASgF" + "EhMKC2VsZW1lbnRUeXBlGAUgASgFEg8KB2dyb3VwSWQYBiABKAUSCgoCaWQY" + "ByABKAUSEQoJbm9CYXJnYWluGAggASgFEhMKC3ByZW1pdW1SYXRlGAkgASgF" + "EhIKCnByaWNlQ291bnQYCiABKAUSDwoHcHJpY2VJZBgLIAEoBRIRCglwcmlj" + "ZVR5cGUYDCABKAUSFgoOcmVwdXRhdGlvblR5cGUYDSABKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ProductTable), ProductTable.Parser, new string[13]
		{
			"BuyMaxCount", "DiscountRate", "ElementCount", "ElementId", "ElementType", "GroupId", "Id", "NoBargain", "PremiumRate", "PriceCount",
			"PriceId", "PriceType", "ReputationType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
