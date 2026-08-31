using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TotalWarRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvVG90YWxXYXJfX1/sooXrp5DsnZgg7IScL1RvdGFsV2Fy" + "UmV3YXJkVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24igQEKE1Rv" + "dGFsV2FyUmV3YXJkVGFibGUSFAoMYm9zc0lkbGVBbmltGAEgASgJEgoKAmlk" + "GAIgASgFEhMKC3Jld2FyZENvdW50GAMgASgFEhAKCHJld2FyZElkGAQgASgF" + "EhIKCnJld2FyZFR5cGUYBSABKAUSDQoFc2NvcmUYBiABKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarRewardTable), TotalWarRewardTable.Parser, new string[6] { "BossIdleAnim", "Id", "RewardCount", "RewardId", "RewardType", "Score" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
