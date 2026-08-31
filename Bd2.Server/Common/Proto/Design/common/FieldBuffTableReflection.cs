using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FieldBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvRmllbGRUYWJsZV9fX+2VhOuTnC9GaWVsZEJ1ZmZUYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiK7AgoORmllbGRCdWZmVGFi" + "bGUSGwoTYnVmZkRlc2NMb2NhbFRleHRJZBgBIAEoBRIVCg1idWZmTGFyZ2VJ" + "Y29uGAIgASgJEhsKE2J1ZmZOYW1lTG9jYWxUZXh0SWQYAyABKAUSFQoNYnVm" + "ZlNtYWxsSWNvbhgEIAEoCRIQCghidWZmVGltZRgFIAEoARIQCghidWZmVHlw" + "ZRgGIAEoBRIVCg1kaXNhcHBlYXJUaW1lGAcgASgBEhwKFGZpZWxkRGVzY0xv" + "Y2FsVGV4dElkGAggASgFEgoKAmlkGAkgASgFEhEKCWtub2NrQmFjaxgKIAEo" + "BRISCgpyZW5kZXJUeXBlGAsgASgFEhIKCnNlbGVjdEJ1ZmYYDCABKAUSEgoK" + "dGFyZ2V0VHlwZRgNIAEoBRINCgV2YWx1ZRgOIAEoAUJEQhNQcm90by5EZXNp" + "Z24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRl" + "c2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldBuffTable), FieldBuffTable.Parser, new string[14]
		{
			"BuffDescLocalTextId", "BuffLargeIcon", "BuffNameLocalTextId", "BuffSmallIcon", "BuffTime", "BuffType", "DisappearTime", "FieldDescLocalTextId", "Id", "KnockBack",
			"RenderType", "SelectBuff", "TargetType", "Value"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
