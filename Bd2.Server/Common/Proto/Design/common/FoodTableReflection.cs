using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FoodTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9jb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0Zvb2RUYWJsZS5w" + "cm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLhAgoJRm9vZFRhYmxlEh0KFWZh" + "dm9yaXRlUmVjb3ZlcnlQb2ludBgBIAEoBRIcChRmYXZvcml0ZVVuaXF1ZUNo" + "YXJJZBgCIAMoBRISCgpmb29kQnVmZklkGAMgASgFEhAKCGZvb2RUeXBlGAQg" + "ASgFEg0KBWdyYWRlGAUgASgFEhYKDmljb25TcHJpdGVOYW1lGAYgASgJEgoK" + "AmlkGAcgASgFEhUKDWl0ZW1BY3F1aXJlSWQYCCADKAUSGgoSaXRlbURlc2NO" + "YW1lVGV4dElkGAkgASgFEhYKDml0ZW1OYW1lVGV4dElkGAogASgFEhAKCG5v" + "dFRyYXNoGAsgASgFEg4KBnBhY2tJZBgMIAMoBRIVCg1yZWNvdmVyeVBvaW50" + "GA0gASgFEhQKDHJlY292ZXJ5VHlwZRgOIAEoBRIQCghzb3J0VHlwZRgPIAEo" + "BRISCgpzdGFja0NvdW50GBAgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FoodTable), FoodTable.Parser, new string[16]
		{
			"FavoriteRecoveryPoint", "FavoriteUniqueCharId", "FoodBuffId", "FoodType", "Grade", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescNameTextId", "ItemNameTextId",
			"NotTrash", "PackId", "RecoveryPoint", "RecoveryType", "SortType", "StackCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
