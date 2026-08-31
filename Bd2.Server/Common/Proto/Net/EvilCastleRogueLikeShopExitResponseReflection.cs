using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeShopExitResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcEV4aXRSZXNwb25z" + "ZS5wcm90bxIJcHJvdG8ubmV0GipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxp" + "a2VTdGF0ZUluZm8ucHJvdG8aKUNvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlr" + "ZVJvb21JbmZvLnByb3RvIrgBCiNFdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcEV4" + "aXRSZXNwb25zZRI7CgpzdGF0ZV9pbmZvGAEgASgLMicucHJvdG8ubmV0LkV2" + "aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8SEwoLY2xlYXJfZmxvb3IYAiAB" + "KAUSPwoPY2xlYXJfcm9vbV9pbmZvGAMgASgLMiYucHJvdG8ubmV0LkV2aWxD" + "YXN0bGVSb2d1ZUxpa2VSb29tSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeShopExitResponse), EvilCastleRogueLikeShopExitResponse.Parser, new string[3] { "StateInfo", "ClearFloor", "ClearRoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
