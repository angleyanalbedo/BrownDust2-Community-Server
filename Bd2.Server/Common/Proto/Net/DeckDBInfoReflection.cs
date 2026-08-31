using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJKCgpEZWNrREJJbmZvEhgKEGNoYXJfaW52ZW5faW5kZXgYASABKAMSEAoIcG9zaXRpb24YAiABKAUSEAoIc2VxdWVuY2UYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DeckDBInfo), DeckDBInfo.Parser, new string[3] { "CharInvenIndex", "Position", "Sequence" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
