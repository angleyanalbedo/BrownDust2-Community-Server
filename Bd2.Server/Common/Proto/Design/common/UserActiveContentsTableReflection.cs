using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class UserActiveContentsTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckdjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9V" + "c2VyQWN0aXZlQ29udGVudHNUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNv" + "bW1vbiKWAQoXVXNlckFjdGl2ZUNvbnRlbnRzVGFibGUSEQoJYWN0aXZlRGF5" + "GAEgASgFEhcKD2NvbnRlbnRUaWNrZXRJZBgCIAEoBRIKCgJpZBgDIAEoBRIM" + "CgR0eXBlGAQgASgFEhMKC3R5cGVHcm91cElkGAUgASgFEg4KBnR5cGVJZBgG" + "IAEoBRIQCgh1c2VyVHlwZRgHIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9u" + "UAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21t" + "b25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserActiveContentsTable), UserActiveContentsTable.Parser, new string[7] { "ActiveDay", "ContentTicketId", "Id", "Type", "TypeGroupId", "TypeId", "UserType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
