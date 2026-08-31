using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeEventChoiceResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlRXZlbnRDaG9pY2VSZXNw" + "b25zZS5wcm90bxIJcHJvdG8ubmV0GipDb21tb25zL0V2aWxDYXN0bGVSb2d1" + "ZUxpa2VTdGF0ZUluZm8ucHJvdG8aGENvbW1vbnMvQ2hhckRCSW5mby5wcm90" + "bxoZQ29tbW9ucy9SZWxpY0RCSW5mby5wcm90bxorQ29tbW9ucy9FdmlsQ2Fz" + "dGxlUm9ndWVMaWtlQ2hvaWNlSW5mby5wcm90bxosQ29tbW9ucy9FdmlsQ2Fz" + "dGxlUm9ndWVMaWtlRXZlbnRSZXdhcmQucHJvdG8aKUNvbW1vbnMvRXZpbENh" + "c3RsZVJvZ3VlTGlrZVJvb21JbmZvLnByb3RvIpcCCiZFdmlsQ2FzdGxlUm9n" + "dWVMaWtlRXZlbnRDaG9pY2VSZXNwb25zZRI7CgpzdGF0ZV9pbmZvGAEgASgL" + "MicucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8SFAoM" + "ZXZlbnRfcmVzdWx0GAIgASgFEhMKC2NsZWFyX2Zsb29yGAMgASgFEkQKEWV2" + "ZW50X3Jld2FyZF9pbmZvGAQgASgLMikucHJvdG8ubmV0LkV2aWxDYXN0bGVS" + "b2d1ZUxpa2VFdmVudFJld2FyZBI/Cg9jbGVhcl9yb29tX2luZm8YBSABKAsy" + "Ji5wcm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvYgZwcm90" + "bzM="), new FileDescriptor[6]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		RelicDBInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		EvilCastleRogueLikeEventRewardReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeEventChoiceResponse), EvilCastleRogueLikeEventChoiceResponse.Parser, new string[5] { "StateInfo", "EventResult", "ClearFloor", "EventRewardInfo", "ClearRoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
