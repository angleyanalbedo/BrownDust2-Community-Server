using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeFloorInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VGbG9vckluZm8ucHJvdG8S" + "CXByb3RvLm5ldBopQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVMaWtlUm9vbUlu" + "Zm8ucHJvdG8iaQocRXZpbENhc3RsZVJvZ3VlTGlrZUZsb29ySW5mbxIOCgZu" + "dW1iZXIYASABKAUSOQoJcm9vbV9pbmZvGAIgAygLMiYucHJvdG8ubmV0LkV2" + "aWxDYXN0bGVSb2d1ZUxpa2VSb29tSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { EvilCastleRogueLikeRoomInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeFloorInfo), EvilCastleRogueLikeFloorInfo.Parser, new string[2] { "Number", "RoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
