using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterDamageResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9GaWVsZE1vbnN0ZXJEYW1hZ2VSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8iRgoaRmllbGRNb25zdGVyRGFtYWdlUmVzcG9uc2USKAoJY2hhcl9pbmZvGAEgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterDamageResponse), FieldMonsterDamageResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
