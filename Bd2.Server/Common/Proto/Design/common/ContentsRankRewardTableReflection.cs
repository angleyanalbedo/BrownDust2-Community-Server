using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentsRankRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0NvbnRlbnRzUmFu" + "a1Jld2FyZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpQBChdD" + "b250ZW50c1JhbmtSZXdhcmRUYWJsZRIUCgxjb250ZW50c1R5cGUYASABKAUS" + "CgoCaWQYAiABKAUSDAoEcmFuaxgDIAEoBRITCgtyZXdhcmRDb3VudBgEIAMo" + "BRIQCghyZXdhcmRJZBgFIAMoBRISCgpyZXdhcmRUeXBlGAYgAygFEg4KBnNl" + "YXNvbhgHIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8u" + "RGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentsRankRewardTable), ContentsRankRewardTable.Parser, new string[7] { "ContentsType", "Id", "Rank", "RewardCount", "RewardId", "RewardType", "Season" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
