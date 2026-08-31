using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleTotalRankTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVU" + "b3RhbFJhbmtUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKgAQoY" + "RXZpbENhc3RsZVRvdGFsUmFua1RhYmxlEhMKC1Jld2FyZENvdW50GAEgAygF" + "EhAKCFJld2FyZElkGAIgAygFEhIKClJld2FyZFR5cGUYAyADKAUSFgoOaWNv" + "blNwcml0ZU5hbWUYBCABKAkSCgoCaWQYBSABKAUSDAoEcmFuaxgGIAEoBRIX" + "Cg9yYW5rTG9jYWxUZXh0SWQYByABKAVCREITUHJvdG8uRGVzaWduLmNvbW1v" + "blABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29t" + "bW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTotalRankTable), EvilCastleTotalRankTable.Parser, new string[7] { "RewardCount", "RewardId", "RewardType", "IconSpriteName", "Id", "Rank", "RankLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
