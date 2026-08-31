using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFJld2Fy" + "ZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uImUKDVJMUmV3YXJk" + "VGFibGUSCgoCaWQYASABKAUSEwoLcmV3YXJkQ291bnQYAiADKAUSEAoIcmV3" + "YXJkSWQYAyADKAUSEgoKcmV3YXJkVHlwZRgEIAMoBRINCgVzY29yZRgFIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLRewardTable), RLRewardTable.Parser, new string[5] { "Id", "RewardCount", "RewardId", "RewardType", "Score" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
