using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeAllRounderUpgradeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L0Nvc3R1bWVBbGxSb3VuZGVyVXBncmFkZVJlcXVlc3QucHJv" + "dG8SCXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIqcBCh9D" + "b3N0dW1lQWxsUm91bmRlclVwZ3JhZGVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIb" + "ChNjb3N0dW1lX2ludmVuX2luZGV4GAIgASgDEhgKEHByb2R1Y3RfZ3JvdXBf" + "aWQYAyABKAUSEgoKcHJvZHVjdF9pZBgEIAEoBRIsCg11c2VfaXRlbV9pbmZv" + "GAUgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeAllRounderUpgradeRequest), CostumeAllRounderUpgradeRequest.Parser, new string[5] { "Seq", "CostumeInvenIndex", "ProductGroupId", "ProductId", "UseItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
