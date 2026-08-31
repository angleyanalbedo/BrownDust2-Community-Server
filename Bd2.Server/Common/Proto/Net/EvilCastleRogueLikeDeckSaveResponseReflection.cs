using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeDeckSaveResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlRGVja1NhdmVSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8iTwojRXZpbENhc3RsZVJvZ3VlTGlrZURlY2tTYXZlUmVzcG9uc2USKAoJZGVja19pbmZvGAEgAygLMhUucHJvdG8ubmV0LkRlY2tEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeDeckSaveResponse), EvilCastleRogueLikeDeckSaveResponse.Parser, new string[1] { "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
