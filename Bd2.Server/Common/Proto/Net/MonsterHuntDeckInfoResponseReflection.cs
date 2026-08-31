using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Nb25zdGVySHVudERlY2tJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBojQ29tbW9ucy9Nb25zdGVySHVudERlY2tEQkluZm8ucHJv" + "dG8iXwobTW9uc3Rlckh1bnREZWNrSW5mb1Jlc3BvbnNlEkAKFm1vbnN0ZXJf" + "aHVudF9kZWNrX2luZm8YASADKAsyIC5wcm90by5uZXQuTW9uc3Rlckh1bnRE" + "ZWNrREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MonsterHuntDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntDeckInfoResponse), MonsterHuntDeckInfoResponse.Parser, new string[1] { "MonsterHuntDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
