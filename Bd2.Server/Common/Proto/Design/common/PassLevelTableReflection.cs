using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PassLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvU2Vhc29uUGFzc1RhYmxlX19f7Iuc7KaM7Yyo7IqkL1Bh" + "c3NMZXZlbFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIusBCg5Q" + "YXNzTGV2ZWxUYWJsZRIYChBiYXNpY1Jld2FyZENvdW50GAEgASgFEhUKDWJh" + "c2ljUmV3YXJkSWQYAiABKAUSFwoPYmFzaWNSZXdhcmRUeXBlGAMgASgFEg8K" + "B2dyb3VwSWQYBCABKAUSCgoCaWQYBSABKAUSEwoLbmV4dE5lZWRFeHAYBiAB" + "KAUSGAoQcGFzczFSZXdhcmRDb3VudBgHIAEoBRIVCg1wYXNzMVJld2FyZElk" + "GAggASgFEhcKD3Bhc3MxUmV3YXJkVHlwZRgJIAEoBRITCgtwcmVtaXVtVHlw" + "ZRgKIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassLevelTable), PassLevelTable.Parser, new string[10] { "BasicRewardCount", "BasicRewardId", "BasicRewardType", "GroupId", "Id", "NextNeedExp", "Pass1RewardCount", "Pass1RewardId", "Pass1RewardType", "PremiumType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
