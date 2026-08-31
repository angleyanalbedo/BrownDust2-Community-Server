using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeEventRewardReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VFdmVudFJld2FyZC5wcm90" + "bxIJcHJvdG8ubmV0GipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VTdGF0" + "ZUluZm8ucHJvdG8aGENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxoZQ29tbW9u" + "cy9SZWxpY0RCSW5mby5wcm90bxorQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVM" + "aWtlQ2hvaWNlSW5mby5wcm90byKuAgoeRXZpbENhc3RsZVJvZ3VlTGlrZUV2" + "ZW50UmV3YXJkEhcKD3JvZ3VlX2xpa2VfZ29sZBgBIAEoBRIoCgljaGFyX2lu" + "Zm8YAiADKAsyFS5wcm90by5uZXQuQ2hhckRCSW5mbxIuCg5hZGRfcmVsaWNf" + "aW5mbxgDIAMoCzIWLnByb3RvLm5ldC5SZWxpY0RCSW5mbxIxChFyZW1vdmVf" + "cmVsaWNfaW5mbxgEIAMoCzIWLnByb3RvLm5ldC5SZWxpY0RCSW5mbxI9Cgtj" + "aG9pY2VfaW5mbxgFIAEoCzIoLnByb3RvLm5ldC5FdmlsQ2FzdGxlUm9ndWVM" + "aWtlQ2hvaWNlSW5mbxIUCgxiYXR0bGVfbGV2ZWwYBiABKAUSEQoJaGVhbF9y" + "YXRlGAcgASgFYgZwcm90bzM="), new FileDescriptor[4]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		RelicDBInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeEventReward), EvilCastleRogueLikeEventReward.Parser, new string[7] { "RogueLikeGold", "CharInfo", "AddRelicInfo", "RemoveRelicInfo", "ChoiceInfo", "BattleLevel", "HealRate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
