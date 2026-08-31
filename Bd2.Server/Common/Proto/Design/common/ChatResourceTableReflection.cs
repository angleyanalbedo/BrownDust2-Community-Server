using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ChatResourceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9jb21tb24uZGIvR3VpbGRfX+q4uOuTnC9DaGF0UmVzb3VyY2VUYWJsZS5w" + "cm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJPChFDaGF0UmVzb3VyY2VUYWJs" + "ZRIYChBjaGF0UmVzb3VyY2VUeXBlGAEgASgFEgoKAmlkGAIgASgFEhQKDHJl" + "c291cmNlTmFtZRgDIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v" + "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ChatResourceTable), ChatResourceTable.Parser, new string[3] { "ChatResourceType", "Id", "ResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
