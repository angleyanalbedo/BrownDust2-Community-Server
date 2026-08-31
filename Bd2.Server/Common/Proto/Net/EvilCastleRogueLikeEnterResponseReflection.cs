using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlRW50ZXJSZXNwb25zZS5w" + "cm90bxIJcHJvdG8ubmV0GipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VG" + "bG9vckluZm8ucHJvdG8aK0NvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlrZUNo" + "b2ljZUluZm8ucHJvdG8aKkNvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlrZVN0" + "YXRlSW5mby5wcm90byKFAgogRXZpbENhc3RsZVJvZ3VlTGlrZUVudGVyUmVz" + "cG9uc2USOwoKZmxvb3JfaW5mbxgBIAMoCzInLnByb3RvLm5ldC5FdmlsQ2Fz" + "dGxlUm9ndWVMaWtlRmxvb3JJbmZvEj0KC2Nob2ljZV9pbmZvGAIgASgLMigu" + "cHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VDaG9pY2VJbmZvEjsKCnN0" + "YXRlX2luZm8YAyABKAsyJy5wcm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlr" + "ZVN0YXRlSW5mbxIXCg9yb2d1ZV9saWtlX2dvbGQYBCABKAUSDwoHcmVfcm9s" + "bBgFIAEoBWIGcHJvdG8z"), new FileDescriptor[3]
	{
		EvilCastleRogueLikeFloorInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		EvilCastleRogueLikeStateInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeEnterResponse), EvilCastleRogueLikeEnterResponse.Parser, new string[5] { "FloorInfo", "ChoiceInfo", "StateInfo", "RogueLikeGold", "ReRoll" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
