using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L01vbnN0ZXJIdW50RGVja1NhdmVSZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQaI0NvbW1vbnMvTW9uc3Rlckh1bnREZWNrREJJbmZvLnByb3Rv" + "ImsKGk1vbnN0ZXJIdW50RGVja1NhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRJA" + "ChZtb25zdGVyX2h1bnRfZGVja19pbmZvGAIgAygLMiAucHJvdG8ubmV0Lk1v" + "bnN0ZXJIdW50RGVja0RCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { MonsterHuntDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntDeckSaveRequest), MonsterHuntDeckSaveRequest.Parser, new string[2] { "Seq", "MonsterHuntDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
