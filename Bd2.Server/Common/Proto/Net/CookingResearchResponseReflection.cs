using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CookingResearchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9Db29raW5nUmVzZWFyY2hSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iQwoXQ29va2luZ1Jlc2VhcmNoUmVzcG9uc2USKAoJaXRlbV9pbmZvGAEgASgLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingResearchResponse), CookingResearchResponse.Parser, new string[1] { "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
