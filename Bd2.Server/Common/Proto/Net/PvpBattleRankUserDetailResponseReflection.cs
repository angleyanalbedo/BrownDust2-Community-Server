using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankUserDetailResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9QdnBCYXR0bGVSYW5rVXNlckRldGFpbFJlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQaJ0NvbW1vbnMvUHZwQmF0dGxlVXNlckRlY2tGdWxs" + "SW5mby5wcm90byLeAQofUHZwQmF0dGxlUmFua1VzZXJEZXRhaWxSZXNwb25z" + "ZRITCgtvd25lcl9pbmRleBgBIAEoAxIRCgl3aW5fY291bnQYAiABKAUSEgoK" + "bG9zZV9jb3VudBgDIAEoBRI+ChBhdHRhY2tfZGVja19pbmZvGAQgASgLMiQu" + "cHJvdG8ubmV0LlB2cEJhdHRsZVVzZXJEZWNrRnVsbEluZm8SPwoRZGVmZW5j" + "ZV9kZWNrX2luZm8YBSABKAsyJC5wcm90by5uZXQuUHZwQmF0dGxlVXNlckRl" + "Y2tGdWxsSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { PvpBattleUserDeckFullInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankUserDetailResponse), PvpBattleRankUserDetailResponse.Parser, new string[5] { "OwnerIndex", "WinCount", "LoseCount", "AttackDeckInfo", "DefenceDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
