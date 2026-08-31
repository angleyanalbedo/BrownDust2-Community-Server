using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TalentRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvVGFsZW50VGFibGVfX1/snqzriqXsiqTtgqwvVGFsZW50" + "UmV3YXJkVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iWgoRVGFs" + "ZW50UmV3YXJkVGFibGUSCgoCaWQYASABKAUSEwoLcmV3YXJkQ291bnQYAiAD" + "KAUSEAoIcmV3YXJkSWQYAyADKAUSEgoKcmV3YXJkVHlwZRgEIAMoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentRewardTable), TalentRewardTable.Parser, new string[4] { "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
