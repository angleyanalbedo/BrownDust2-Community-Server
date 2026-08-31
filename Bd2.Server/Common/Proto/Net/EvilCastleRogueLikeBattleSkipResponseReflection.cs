using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeBattleSkipResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlQmF0dGxlU2tpcFJlc3Bv" + "bnNlLnByb3RvEglwcm90by5uZXQaKkNvbW1vbnMvRXZpbENhc3RsZVJvZ3Vl" + "TGlrZVN0YXRlSW5mby5wcm90bxorQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVM" + "aWtlQ2hvaWNlSW5mby5wcm90bxopQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVM" + "aWtlUm9vbUluZm8ucHJvdG8i+QEKJUV2aWxDYXN0bGVSb2d1ZUxpa2VCYXR0" + "bGVTa2lwUmVzcG9uc2USOwoKc3RhdGVfaW5mbxgBIAEoCzInLnByb3RvLm5l" + "dC5FdmlsQ2FzdGxlUm9ndWVMaWtlU3RhdGVJbmZvEj0KC2Nob2ljZV9pbmZv" + "GAIgASgLMigucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VDaG9pY2VJ" + "bmZvEhMKC2NsZWFyX2Zsb29yGAMgASgFEj8KD2NsZWFyX3Jvb21faW5mbxgE" + "IAEoCzImLnByb3RvLm5ldC5FdmlsQ2FzdGxlUm9ndWVMaWtlUm9vbUluZm9i" + "BnByb3RvMw=="), new FileDescriptor[3]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeBattleSkipResponse), EvilCastleRogueLikeBattleSkipResponse.Parser, new string[4] { "StateInfo", "ChoiceInfo", "ClearFloor", "ClearRoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
