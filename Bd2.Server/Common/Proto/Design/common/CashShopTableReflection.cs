using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CashShopTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvQ2FzaFNob3BUYWJsZV9f7Jyg66OM7IOB7KCQL0Nhc2hT" + "aG9wVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ipAEKDUNhc2hT" + "aG9wVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgCIAEoBRISCgppbGx1" + "c3ROYW1lGAMgASgJEg8KB3ByaWNlSWQYBCADKAUSEQoJcHJpY2VUeXBlGAUg" + "AygFEhAKCHByaW9yaXR5GAYgASgFEhYKDnByb2R1Y3RHcm91cElkGAcgASgF" + "EhQKDHJlc291cmNlTmFtZRgIIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9u" + "UAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21t" + "b25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashShopTable), CashShopTable.Parser, new string[8] { "GroupId", "Id", "IllustName", "PriceId", "PriceType", "Priority", "ProductGroupId", "ResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
