using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntChangeTeamRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L01vbnN0ZXJIdW50Q2hhbmdlVGVhbVJlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldBojQ29tbW9ucy9Nb25zdGVySHVudERlY2tEQkluZm8ucHJv" + "dG8ihwEKHE1vbnN0ZXJIdW50Q2hhbmdlVGVhbVJlcXVlc3QSCwoDc2VxGAEg" + "ASgFEkAKFm1vbnN0ZXJfaHVudF9kZWNrX2luZm8YAiABKAsyIC5wcm90by5u" + "ZXQuTW9uc3Rlckh1bnREZWNrREJJbmZvEhgKEGlzX2NoYW5nZV9tYW51YWwY" + "AyABKAhiBnByb3RvMw=="), new FileDescriptor[1] { MonsterHuntDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntChangeTeamRequest), MonsterHuntChangeTeamRequest.Parser, new string[3] { "Seq", "MonsterHuntDeckInfo", "IsChangeManual" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
