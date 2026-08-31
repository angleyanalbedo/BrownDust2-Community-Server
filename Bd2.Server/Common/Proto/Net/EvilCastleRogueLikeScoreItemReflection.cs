using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeScoreItemReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VTY29yZUl0ZW0ucHJvdG8SCXByb3RvLm5ldCJIChxFdmlsQ2FzdGxlUm9ndWVMaWtlU2NvcmVJdGVtEgoKAmlkGAEgASgFEg0KBXNjb3JlGAIgASgFEg0KBWNvdW50GAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeScoreItem), EvilCastleRogueLikeScoreItem.Parser, new string[3] { "Id", "Score", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
