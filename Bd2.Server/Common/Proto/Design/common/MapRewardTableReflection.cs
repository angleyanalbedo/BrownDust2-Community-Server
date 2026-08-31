using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MapRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1jb21tb24uZGIvTWFwVGFibGVfX1/rp7UvTWFwUmV3YXJkVGFibGUucHJv" + "dG8SE1Byb3RvLkRlc2lnbi5jb21tb24iwgEKDk1hcFJld2FyZFRhYmxlEgoK" + "AmlkGAEgASgFEhMKC2luc2lkZU1hcElkGAIgAygFEg0KBW1hcElkGAMgASgF" + "Eg4KBnBhY2tJZBgEIAEoBRIZChFyZXdhcmRBY3F1aXJlVHlwZRgFIAMoBRIQ" + "CghyZXdhcmRJZBgGIAEoBRIXCg9yZXdhcmRJbmZvQ291bnQYByABKAUSFgoO" + "cmV3YXJkSW5mb1R5cGUYCCABKAUSEgoKcmV3YXJkVHlwZRgJIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MapRewardTable), MapRewardTable.Parser, new string[9] { "Id", "InsideMapId", "MapId", "PackId", "RewardAcquireType", "RewardId", "RewardInfoCount", "RewardInfoType", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
