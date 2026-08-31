using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntUserInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Nb25zdGVySHVudFVzZXJJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBojQ29tbW9ucy9Nb25zdGVySHVudFVzZXJEQkluZm8ucHJv" + "dG8ibQobTW9uc3Rlckh1bnRVc2VySW5mb1Jlc3BvbnNlEkAKFm1vbnN0ZXJf" + "aHVudF91c2VyX2luZm8YASABKAsyIC5wcm90by5uZXQuTW9uc3Rlckh1bnRV" + "c2VyREJJbmZvEgwKBHJhbmsYAiABKAViBnByb3RvMw=="), new FileDescriptor[1] { MonsterHuntUserDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntUserInfoResponse), MonsterHuntUserInfoResponse.Parser, new string[2] { "MonsterHuntUserInfo", "Rank" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
