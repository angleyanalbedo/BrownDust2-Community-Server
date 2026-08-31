using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaFixedTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhRml4ZWRUYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKoAQoPR2FjaGFGaXhlZFRh" + "YmxlEhkKEWczRXF1aXBGaXhlZENvdW50GAEgASgFEhsKE2c0Q29zdHVtZUZp" + "eGVkQ291bnQYAiABKAUSGQoRZzRFcXVpcEZpeGVkQ291bnQYAyABKAUSGwoT" + "ZzVDb3N0dW1lRml4ZWRDb3VudBgEIAEoBRIKCgJpZBgFIAEoBRIZChFpc1Jl" + "c2V0Rml4ZWRDb3VudBgGIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFa" + "FS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaFixedTable), GachaFixedTable.Parser, new string[6] { "G3EquipFixedCount", "G4CostumeFixedCount", "G4EquipFixedCount", "G5CostumeFixedCount", "Id", "IsResetFixedCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
