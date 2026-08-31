using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeStateInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8ucHJvdG8SCXByb3RvLm5ldCJKChxFdmlsQ2FzdGxlUm9ndWVMaWtlU3RhdGVJbmZvEg0KBWZsb29yGAEgASgFEgwKBHJvb20YAiABKAUSDQoFc3RhdGUYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeStateInfo), EvilCastleRogueLikeStateInfo.Parser, new string[3] { "Floor", "Room", "State" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
