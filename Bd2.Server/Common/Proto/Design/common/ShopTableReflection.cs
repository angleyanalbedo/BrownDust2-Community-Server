using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ShopTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvU2hvcFRhYmxlX19f7J246rKM7J6E7IOB7KCQL1Nob3BU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLRAgoJU2hvcFRhYmxl" + "EhoKEmJhcmdhaW5Mb2NhbFRleHRJZBgBIAEoBRIiChpncm91cEJhZE1lc3Nh" + "Z2VMb2NhbFRleHRJZBgCIAEoBRIhChlncm91cEJhZE5vdGljZUxvY2FsVGV4" + "dElkGAMgASgFEiMKG2dyb3VwR29vZE1lc3NhZ2VMb2NhbFRleHRJZBgEIAEo" + "BRIKCgJpZBgFIAEoBRIVCg1tYXBOYW1lVGV4dElkGAYgASgFEhYKDm5wY0xv" + "Y2FsVGV4dElkGAcgASgFEg4KBnBhY2tJZBgIIAEoBRIPCgdwcmljZUlkGAkg" + "AygFEhEKCXByaWNlVHlwZRgKIAMoBRISCgpyZXNldENvdW50GAsgASgFEhUK" + "DXJlc2V0VGVybVR5cGUYDCABKAUSEAoIc2hvcFR5cGUYDSABKAUSEAoIc3Rh" + "cnREYXkYDiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopTable), ShopTable.Parser, new string[14]
		{
			"BargainLocalTextId", "GroupBadMessageLocalTextId", "GroupBadNoticeLocalTextId", "GroupGoodMessageLocalTextId", "Id", "MapNameTextId", "NpcLocalTextId", "PackId", "PriceId", "PriceType",
			"ResetCount", "ResetTermType", "ShopType", "StartDay"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
