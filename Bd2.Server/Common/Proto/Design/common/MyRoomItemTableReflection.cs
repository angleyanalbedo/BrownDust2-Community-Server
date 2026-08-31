using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MyRoomItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvTXlSb29tX19f66eI7J2066O4L015Um9vbUl0ZW1UYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLZAwoPTXlSb29tSXRlbVRh" + "YmxlEhEKCWNhblJvdGF0ZRgBIAEoBRIUCgxjaGFySW50ZXJhY3QYAiADKAUS" + "FwoPZG9kZ2VQcmVmYWJOYW1lGAMgASgJEhMKC2VudW1Db3VudElkGAQgASgF" + "EhAKCGZpbHRlcklkGAUgASgFEhgKEGZpbHRlck5hbWVUZXh0SWQYBiABKAUS" + "CgoCaWQYByABKAUSFQoNaXRlbUFjcXVpcmVJZBgIIAMoBRIVCg1pdGVtQW5p" + "bWF0aW9uGAkgASgFEhQKDGl0ZW1JbnRlcmFjdBgKIAMoBRIWCg5pdGVtU3By" + "aXRlTmFtZRgLIAEoCRIdChVpdGVtVW5sb2NrTG9jYWxUZXh0SWQYDCABKAUS" + "EAoIbG9jYXRpb24YDSABKAUSEAoIbWF4Q291bnQYDiABKAUSHAoUb2JqZWN0" + "RGVzY05hbWVUZXh0SWQYDyABKAUSGAoQb2JqZWN0TmFtZVRleHRJZBgQIAEo" + "BRISCgpvYmplY3RUeXBlGBEgASgFEg4KBnBhY2tJZBgSIAEoBRISCgpwcmVm" + "YWJOYW1lGBMgASgJEhIKCnF1ZXN0TGV2ZWwYFCABKAUSFAoMcm9vbUl0ZW1U" + "eXBlGBUgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5E" + "ZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemTable), MyRoomItemTable.Parser, new string[21]
		{
			"CanRotate", "CharInteract", "DodgePrefabName", "EnumCountId", "FilterId", "FilterNameTextId", "Id", "ItemAcquireId", "ItemAnimation", "ItemInteract",
			"ItemSpriteName", "ItemUnlockLocalTextId", "Location", "MaxCount", "ObjectDescNameTextId", "ObjectNameTextId", "ObjectType", "PackId", "PrefabName", "QuestLevel",
			"RoomItemType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
