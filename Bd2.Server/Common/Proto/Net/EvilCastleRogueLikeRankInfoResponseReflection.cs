using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeRankInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlUmFua0luZm9SZXNwb25z" + "ZS5wcm90bxIJcHJvdG8ubmV0Gh1Db21tb25zL0d1aWxkQmFzZURCSW5mby5w" + "cm90byLaAQofRXZpbENhc3RsZVJvZ3VlTGlrZVJhbmtVc2VySW5mbxITCgtv" + "d25lcl9pbmRleBgBIAEoAxIPCgd1c2VyX2lkGAIgASgJEhAKCHVzZXJfZXhw" + "GAMgASgFEhsKE3BvcnRyYWl0X2Nvc3R1bWVfaWQYBCABKAUSMwoPZ3VpbGRf" + "YmFzZV9pbmZvGAUgASgLMhoucHJvdG8ubmV0Lkd1aWxkQmFzZURCSW5mbxIM" + "CgRyYW5rGAYgASgFEg0KBXNjb3JlGAcgASgFEhAKCHRpdGxlX2lkGAggASgF" + "IqsBCiNFdmlsQ2FzdGxlUm9ndWVMaWtlUmFua0luZm9SZXNwb25zZRJCCg51" + "c2VyX3JhbmtfaW5mbxgBIAMoCzIqLnByb3RvLm5ldC5FdmlsQ2FzdGxlUm9n" + "dWVMaWtlUmFua1VzZXJJbmZvEkAKDG15X3JhbmtfaW5mbxgCIAEoCzIqLnBy" + "b3RvLm5ldC5FdmlsQ2FzdGxlUm9ndWVMaWtlUmFua1VzZXJJbmZvYgZwcm90" + "bzM="), new FileDescriptor[1] { GuildBaseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeRankUserInfo), EvilCastleRogueLikeRankUserInfo.Parser, new string[8] { "OwnerIndex", "UserId", "UserExp", "PortraitCostumeId", "GuildBaseInfo", "Rank", "Score", "TitleId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeRankInfoResponse), EvilCastleRogueLikeRankInfoResponse.Parser, new string[2] { "UserRankInfo", "MyRankInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
