using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeQuickBattleResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlUXVpY2tCYXR0bGVSZXNw" + "b25zZS5wcm90bxIJcHJvdG8ubmV0GipDb21tb25zL0V2aWxDYXN0bGVSb2d1" + "ZUxpa2VTY29yZUluZm8ucHJvdG8iZQomRXZpbENhc3RsZVJvZ3VlTGlrZVF1" + "aWNrQmF0dGxlUmVzcG9uc2USOwoKc2NvcmVfaW5mbxgBIAEoCzInLnByb3Rv" + "Lm5ldC5FdmlsQ2FzdGxlUm9ndWVMaWtlU2NvcmVJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EvilCastleRogueLikeScoreInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeQuickBattleResponse), EvilCastleRogueLikeQuickBattleResponse.Parser, new string[1] { "ScoreInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
