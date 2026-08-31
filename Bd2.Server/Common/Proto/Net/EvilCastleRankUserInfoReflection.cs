using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRankUserInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb21tb25zL0V2aWxDYXN0bGVSYW5rVXNlckluZm8ucHJvdG8SCXByb3Rv" + "Lm5ldBodQ29tbW9ucy9HdWlsZEJhc2VEQkluZm8ucHJvdG8i0QEKFkV2aWxD" + "YXN0bGVSYW5rVXNlckluZm8SEwoLb3duZXJfaW5kZXgYASABKAMSDwoHdXNl" + "cl9pZBgCIAEoCRIQCgh1c2VyX2V4cBgDIAEoBRIbChNwb3J0cmFpdF9jb3N0" + "dW1lX2lkGAQgASgFEjMKD2d1aWxkX2Jhc2VfaW5mbxgFIAEoCzIaLnByb3Rv" + "Lm5ldC5HdWlsZEJhc2VEQkluZm8SDAoEcmFuaxgGIAEoBRINCgVwb2ludBgH" + "IAEoBRIQCgh0aXRsZV9pZBgIIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { GuildBaseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRankUserInfo), EvilCastleRankUserInfo.Parser, new string[8] { "OwnerIndex", "UserId", "UserExp", "PortraitCostumeId", "GuildBaseInfo", "Rank", "Point", "TitleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
