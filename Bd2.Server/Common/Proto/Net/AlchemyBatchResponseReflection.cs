using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AlchemyBatchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9BbGNoZW15QmF0Y2hSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iWAoUQWxjaGVteUJhdGNoUmVzcG9uc2USKAoJaXRlbV9pbmZvGAEgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm8SFgoOYWRkX3RhbGVudF9leHAYAiABKAViBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AlchemyBatchResponse), AlchemyBatchResponse.Parser, new string[2] { "ItemInfo", "AddTalentExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
