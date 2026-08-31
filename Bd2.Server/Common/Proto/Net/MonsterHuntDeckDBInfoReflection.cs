using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntDeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL01vbnN0ZXJIdW50RGVja0RCSW5mby5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8iTwoVTW9uc3Rlckh1bnREZWNrREJJbmZvEgwKBHRlYW0YASABKAUSKAoJZGVja19pbmZvGAIgAygLMhUucHJvdG8ubmV0LkRlY2tEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntDeckDBInfo), MonsterHuntDeckDBInfo.Parser, new string[2] { "Team", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
