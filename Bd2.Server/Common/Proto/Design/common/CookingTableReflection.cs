using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CookingTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0Nvb2tpbmdUYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLWAgoMQ29va2luZ1RhYmxl" + "Eg0KBWdyYWRlGAEgASgFEhYKDmljb25TcHJpdGVOYW1lGAIgASgJEgoKAmlk" + "GAMgASgFEhUKDWl0ZW1BY3F1aXJlSWQYBCADKAUSGgoSaXRlbURlc2NOYW1l" + "VGV4dElkGAUgASgFEhkKEWl0ZW1TdWJOYW1lVGV4dElkGAYgASgFEhkKEW1h" + "dGVyaWFsSXRlbUNvdW50GAcgAygFEhYKDm1hdGVyaWFsSXRlbUlkGAggAygF" + "EhAKCG5vdFRyYXNoGAkgASgFEg4KBnBhY2tJZBgKIAEoBRIYChByZWNpcGVO" + "YW1lVGV4dElkGAsgASgFEhcKD3Jlc3VsdEl0ZW1Db3VudBgMIAEoBRIUCgxy" + "ZXN1bHRJdGVtSWQYDSABKAUSEgoKc3RhY2tDb3VudBgOIAEoBRITCgt0YWxl" + "bnRMZXZlbBgPIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingTable), CookingTable.Parser, new string[15]
		{
			"Grade", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescNameTextId", "ItemSubNameTextId", "MaterialItemCount", "MaterialItemId", "NotTrash", "PackId",
			"RecipeNameTextId", "ResultItemCount", "ResultItemId", "StackCount", "TalentLevel"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
