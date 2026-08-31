using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class UserAlterTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckdjb21tb24uZGIvVXNlckFsdGVyX19f7Jyg7KCAIEFsdGVy642w7J207YSw" + "IOq0gOumrC9Vc2VyQWx0ZXJUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNv" + "bW1vbiKuAQoOVXNlckFsdGVyVGFibGUSFQoNY29uZGl0aW9uVHlwZRgBIAEo" + "BRIPCgdncm91cElkGAIgASgFEgoKAmlkGAMgASgFEhEKCWl0ZW1Db3VudBgE" + "IAMoBRIOCgZpdGVtSWQYBSADKAUSEAoIaXRlbVR5cGUYBiADKAUSDgoGcGFj" + "a0lkGAcgASgFEg8KB3F1ZXN0SWQYCCABKAUSEgoKcXVlc3RMZXZlbBgJIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserAlterTable), UserAlterTable.Parser, new string[9] { "ConditionType", "GroupId", "Id", "ItemCount", "ItemId", "ItemType", "PackId", "QuestId", "QuestLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
