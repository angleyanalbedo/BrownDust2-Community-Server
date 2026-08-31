using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBingoPlayResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9NaW5pR2FtZUJpbmdvUGxheVJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvTWluaUdhbWVCaW5nb0RCSW5mby5wcm90bxog" + "Q29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8ikwMKGU1pbmlHYW1l" + "QmluZ29QbGF5UmVzcG9uc2USQwobYmVmb3JlX21pbmlfZ2FtZV9iaW5nb19p" + "bmZvGAEgASgLMh4ucHJvdG8ubmV0Lk1pbmlHYW1lQmluZ29EQkluZm8SPAoU" + "bWluaV9nYW1lX2JpbmdvX2luZm8YAiABKAsyHi5wcm90by5uZXQuTWluaUdh" + "bWVCaW5nb0RCSW5mbxIYChBvcGVuX2JpbmdvX2luZGV4GAMgAygFEjgKDm9w" + "ZW5fbGluZV9pbmZvGAQgAygLMiAucHJvdG8ubmV0Lk1pbmlHYW1lQmluZ29M" + "aW5lSW5mbxIzCgxzcGFjZV9yZXdhcmQYBSABKAsyHS5wcm90by5uZXQuUmV3" + "YXJkREJJbmZvQnVuZGxlEjIKC2xpbmVfcmV3YXJkGAYgASgLMh0ucHJvdG8u" + "bmV0LlJld2FyZERCSW5mb0J1bmRsZRI2Cg9jb21wbGV0ZV9yZXdhcmQYByAB" + "KAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[2]
	{
		MiniGameBingoDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoPlayResponse), MiniGameBingoPlayResponse.Parser, new string[7] { "BeforeMiniGameBingoInfo", "MiniGameBingoInfo", "OpenBingoIndex", "OpenLineInfo", "SpaceReward", "LineReward", "CompleteReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
