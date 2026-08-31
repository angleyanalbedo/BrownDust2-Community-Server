using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankUserInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1B2cEJhdHRsZVJhbmtVc2VySW5mby5wcm90bxIJcHJvdG8u" + "bmV0GiNDb21tb25zL1B2cEJhdHRsZVVzZXJCYXNlSW5mby5wcm90bxodQ29t" + "bW9ucy9HdWlsZEJhc2VEQkluZm8ucHJvdG8i6AEKFVB2cEJhdHRsZVJhbmtV" + "c2VySW5mbxITCgtvd25lcl9pbmRleBgBIAEoAxIPCgd1c2VyX2lkGAIgASgJ" + "EhAKCHVzZXJfZXhwGAMgASgFEhsKE3BvcnRyYWl0X2Nvc3R1bWVfaWQYBCAB" + "KAUSMwoPZ3VpbGRfYmFzZV9pbmZvGAUgASgLMhoucHJvdG8ubmV0Lkd1aWxk" + "QmFzZURCSW5mbxIzCgliYXNlX2luZm8YBiABKAsyIC5wcm90by5uZXQuUHZw" + "QmF0dGxlVXNlckJhc2VJbmZvEhAKCHRpdGxlX2lkGAcgASgFYgZwcm90bzM="), new FileDescriptor[2]
	{
		PvpBattleUserBaseInfoReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankUserInfo), PvpBattleRankUserInfo.Parser, new string[7] { "OwnerIndex", "UserId", "UserExp", "PortraitCostumeId", "GuildBaseInfo", "BaseInfo", "TitleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
