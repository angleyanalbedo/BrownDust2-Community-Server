using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeNodeActivationRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0Nvc3R1bWVOb2RlQWN0aXZhdGlvblJlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIpgBChxDb3N0" + "dW1lTm9kZUFjdGl2YXRpb25SZXF1ZXN0EgsKA3NlcRgBIAEoBRIYChBjaGFy" + "X2ludmVuX2luZGV4GAIgASgDEhsKE2Nvc3R1bWVfaW52ZW5faW5kZXgYAyAB" + "KAMSCgoCaWQYBCABKAUSKAoJaXRlbV9pbmZvGAUgAygLMhUucHJvdG8ubmV0" + "Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeNodeActivationRequest), CostumeNodeActivationRequest.Parser, new string[5] { "Seq", "CharInvenIndex", "CostumeInvenIndex", "Id", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
