using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleRankTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVS" + "YW5rVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24imwEKE0V2aWxD" + "YXN0bGVSYW5rVGFibGUSEwoLUmV3YXJkQ291bnQYASADKAUSEAoIUmV3YXJk" + "SWQYAiADKAUSEgoKUmV3YXJkVHlwZRgDIAMoBRIWCg5pY29uU3ByaXRlTmFt" + "ZRgEIAEoCRIKCgJpZBgFIAEoBRIMCgRyYW5rGAYgASgFEhcKD3JhbmtMb2Nh" + "bFRleHRJZBgHIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRankTable), EvilCastleRankTable.Parser, new string[7] { "RewardCount", "RewardId", "RewardType", "IconSpriteName", "Id", "Rank", "RankLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
