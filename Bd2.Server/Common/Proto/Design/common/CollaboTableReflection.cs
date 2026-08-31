using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CollaboTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0NvbGxhYm9UYWJs" + "ZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiIuCgxDb2xsYWJvVGFibGUS" + "CgoCaWQYASABKAUSEgoKbmFtZVRleHRJZBgCIAEoCUJEQhNQcm90by5EZXNp" + "Z24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRl" + "c2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CollaboTable), CollaboTable.Parser, new string[2] { "Id", "NameTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
