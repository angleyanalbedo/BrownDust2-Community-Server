using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentGradeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "R3JhZGVUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKoAQoTRXF1" + "aXBtZW50R3JhZGVUYWJsZRIdChVlcXVpcEdyYWRlTG9jYWxUZXh0SWQYASAB" + "KAUSFgoOaWNvblNwcml0ZU5hbWUYAiABKAkSCgoCaWQYAyABKAUSGgoScmFu" + "a1NtZWx0SXRlbUNvdW50GAQgAygFEhcKD3JhbmtTbWVsdEl0ZW1JZBgFIAMo" + "BRIZChFyYW5rU21lbHRJdGVtVHlwZRgGIAMoBUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentGradeTable), EquipmentGradeTable.Parser, new string[6] { "EquipGradeLocalTextId", "IconSpriteName", "Id", "RankSmeltItemCount", "RankSmeltItemId", "RankSmeltItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
