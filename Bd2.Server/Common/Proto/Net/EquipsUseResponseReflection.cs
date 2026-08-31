using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipsUseResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9FcXVpcHNVc2VSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8iPQoRRXF1aXBzVXNlUmVzcG9uc2USKAoJY2hhcl9pbmZvGAEgASgLMhUucHJvdG8ubmV0LkNoYXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipsUseResponse), EquipsUseResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
