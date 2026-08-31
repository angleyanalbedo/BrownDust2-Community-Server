using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CashPackageTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvQ2FzaFNob3BUYWJsZV9f7Jyg66OM7IOB7KCQL0Nhc2hQ" + "YWNrYWdlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iwQIKEENh" + "c2hQYWNrYWdlVGFibGUSHQoVYmFubmVyRm9udExvY2FsVGV4dElkGAEgASgF" + "EhwKFGNhdGVnb3J5UmVzb3VyY2VOYW1lGAIgASgJEhcKD2NvbnRlbnRzR3Jv" + "dXBJZBgDIAEoBRIbChNjb250ZW50c0xvY2FsVGV4dElkGAQgASgFEhwKFGNv" + "bnRlbnRzUmVzb3VyY2VOYW1lGAUgASgJEhYKDmNvbnRlbnRzU29ydElkGAYg" + "ASgFEg8KB2dyb3VwSWQYByABKAUSCgoCaWQYCCABKAUSFwoPaXNBY3RpdmVP" + "bkVudGVyGAkgASgFEhMKC3BhY2thZ2VUeXBlGAogASgFEhAKCHByaW9yaXR5" + "GAsgASgFEhQKDHJlc291cmNlTmFtZRgMIAEoCRIRCglzYWxlR3JvdXAYDSAB" + "KAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5j" + "b21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashPackageTable), CashPackageTable.Parser, new string[13]
		{
			"BannerFontLocalTextId", "CategoryResourceName", "ContentsGroupId", "ContentsLocalTextId", "ContentsResourceName", "ContentsSortId", "GroupId", "Id", "IsActiveOnEnter", "PackageType",
			"Priority", "ResourceName", "SaleGroup"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
