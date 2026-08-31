using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntRankInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Nb25zdGVySHVudFJhbmtJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBodQ29tbW9ucy9HdWlsZEJhc2VEQkluZm8ucHJvdG8i0gEK" + "F01vbnN0ZXJIdW50UmFua1VzZXJJbmZvEhMKC293bmVyX2luZGV4GAEgASgD" + "Eg8KB3VzZXJfaWQYAiABKAkSEAoIdXNlcl9leHAYAyABKAUSGwoTcG9ydHJh" + "aXRfY29zdHVtZV9pZBgEIAEoBRIzCg9ndWlsZF9iYXNlX2luZm8YBSABKAsy" + "Gi5wcm90by5uZXQuR3VpbGRCYXNlREJJbmZvEgwKBHJhbmsYBiABKAUSDQoF" + "c2NvcmUYByABKAESEAoIdGl0bGVfaWQYCCABKAUikwEKG01vbnN0ZXJIdW50" + "UmFua0luZm9SZXNwb25zZRI6Cg51c2VyX3JhbmtfaW5mbxgBIAMoCzIiLnBy" + "b3RvLm5ldC5Nb25zdGVySHVudFJhbmtVc2VySW5mbxI4CgxteV9yYW5rX2lu" + "Zm8YAiABKAsyIi5wcm90by5uZXQuTW9uc3Rlckh1bnRSYW5rVXNlckluZm9i" + "BnByb3RvMw=="), new FileDescriptor[1] { GuildBaseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntRankUserInfo), MonsterHuntRankUserInfo.Parser, new string[8] { "OwnerIndex", "UserId", "UserExp", "PortraitCostumeId", "GuildBaseInfo", "Rank", "Score", "TitleId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MonsterHuntRankInfoResponse), MonsterHuntRankInfoResponse.Parser, new string[2] { "UserRankInfo", "MyRankInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
