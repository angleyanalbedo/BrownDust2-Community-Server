using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharImmortalResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9DaGFySW1tb3J0YWxSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8iQAoUQ2hhckltbW9ydGFsUmVzcG9uc2USKAoJY2hhcl9pbmZvGAEgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharImmortalResponse), CharImmortalResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
