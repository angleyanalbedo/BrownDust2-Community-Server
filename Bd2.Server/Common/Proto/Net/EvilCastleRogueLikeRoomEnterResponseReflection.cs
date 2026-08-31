using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeRoomEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlUm9vbUVudGVyUmVzcG9u" + "c2UucHJvdG8SCXByb3RvLm5ldBoqQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVM" + "aWtlU3RhdGVJbmZvLnByb3RvGitDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxp" + "a2VDaG9pY2VJbmZvLnByb3RvGitDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxp" + "a2VTaG9wREJJbmZvLnByb3RvGipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxp" + "a2VFdmVudEluZm8ucHJvdG8aKUNvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlr" + "ZVJvb21JbmZvLnByb3RvIqEDCiRFdmlsQ2FzdGxlUm9ndWVMaWtlUm9vbUVu" + "dGVyUmVzcG9uc2USOwoKc3RhdGVfaW5mbxgBIAEoCzInLnByb3RvLm5ldC5F" + "dmlsQ2FzdGxlUm9ndWVMaWtlU3RhdGVJbmZvEj0KC2Nob2ljZV9pbmZvGAIg" + "ASgLMigucHJvdG8ubmV0LkV2aWxDYXN0bGVSb2d1ZUxpa2VDaG9pY2VJbmZv" + "EjsKCmV2ZW50X2luZm8YAyABKAsyJy5wcm90by5uZXQuRXZpbENhc3RsZVJv" + "Z3VlTGlrZUV2ZW50SW5mbxI7CglzaG9wX2luZm8YBCABKAsyKC5wcm90by5u" + "ZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVNob3BEQkluZm8SFAoMYmF0dGxlX2xl" + "dmVsGAUgASgFEhcKD3JvZ3VlX2xpa2VfZ29sZBgGIAEoBRITCgtjbGVhcl9m" + "bG9vchgHIAEoBRI/Cg9jbGVhcl9yb29tX2luZm8YCCABKAsyJi5wcm90by5u" + "ZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvYgZwcm90bzM="), new FileDescriptor[5]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		EvilCastleRogueLikeShopDBInfoReflection.Descriptor,
		EvilCastleRogueLikeEventInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeRoomEnterResponse), EvilCastleRogueLikeRoomEnterResponse.Parser, new string[8] { "StateInfo", "ChoiceInfo", "EventInfo", "ShopInfo", "BattleLevel", "RogueLikeGold", "ClearFloor", "ClearRoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
