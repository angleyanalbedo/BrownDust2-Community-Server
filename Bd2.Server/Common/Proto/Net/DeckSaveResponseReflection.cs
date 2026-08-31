using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DeckSaveResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9EZWNrU2F2ZVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "GENvbW1vbnMvRGVja0RCSW5mby5wcm90bxoYQ29tbW9ucy9DaGFyREJJbmZv" + "LnByb3RvImYKEERlY2tTYXZlUmVzcG9uc2USKAoJZGVja19pbmZvGAEgASgL" + "MhUucHJvdG8ubmV0LkRlY2tEQkluZm8SKAoJY2hhcl9pbmZvGAIgASgLMhUu" + "cHJvdG8ubmV0LkNoYXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[2]
	{
		DeckDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DeckSaveResponse), DeckSaveResponse.Parser, new string[2] { "DeckInfo", "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
