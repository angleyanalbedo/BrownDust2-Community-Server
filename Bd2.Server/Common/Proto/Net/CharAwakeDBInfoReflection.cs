using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharAwakeDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0NoYXJBd2FrZURCSW5mby5wcm90bxIJcHJvdG8ubmV0IqoB" + "Cg9DaGFyQXdha2VEQkluZm8SFgoOdW5pcXVlX2NoYXJfaWQYASABKAUSHAoU" + "aW1wcmludF9zbG90XzFfbGV2ZWwYAiABKAUSHAoUaW1wcmludF9zbG90XzJf" + "bGV2ZWwYAyABKAUSHAoUaW1wcmludF9zbG90XzNfbGV2ZWwYBCABKAUSEAoI" + "aXNfYXdha2UYBSABKAgSEwoLb3duZXJfaW5kZXgYBiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharAwakeDBInfo), CharAwakeDBInfo.Parser, new string[6] { "UniqueCharId", "ImprintSlot1Level", "ImprintSlot2Level", "ImprintSlot3Level", "IsAwake", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
