using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeNodeGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVOb2RlR3JvdXBUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biJhChVDb3N0dW1lTm9kZUdyb3VwVGFibGUSFAoMY2hhclVuaXF1ZUlkGAEg" + "ASgFEgoKAmlkGAIgASgFEhAKCGlzQWN0aXZlGAMgASgFEhQKDG5vZGVVSVBy" + "ZWZhYhgEIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8u" + "RGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeNodeGroupTable), CostumeNodeGroupTable.Parser, new string[4] { "CharUniqueId", "Id", "IsActive", "NodeUIPrefab" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
