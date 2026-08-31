using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentOpenGuideTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkVjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b250ZW50T3Blbkd1aWRlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21t" + "b24iqgEKFUNvbnRlbnRPcGVuR3VpZGVUYWJsZRIKCgJpZBgBIAEoBRISCgpt" + "YWdpY1ZhbHVlGAIgASgFEhsKE29wZW5EZXNjTG9jYWxUZXh0SWQYAyABKAUS" + "FAoMb3Blbkljb25OYW1lGAQgASgJEhwKFG9wZW5UaXRsZUxvY2FsVGV4dElk" + "GAUgASgFEhIKCnNob3J0Q3V0SWQYBiABKAUSDAoEdHlwZRgHIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentOpenGuideTable), ContentOpenGuideTable.Parser, new string[7] { "Id", "MagicValue", "OpenDescLocalTextId", "OpenIconName", "OpenTitleLocalTextId", "ShortCutId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
