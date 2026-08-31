using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventMissionCompleteRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkVjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50TWlzc2lv" + "bkNvbXBsZXRlUmV3YXJkVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21t" + "b24ihgEKH0V2ZW50TWlzc2lvbkNvbXBsZXRlUmV3YXJkVGFibGUSHAoUY29t" + "cGxldGVNaXNzaW9uQ291bnQYASABKAUSCgoCaWQYAiABKAUSEwoLcmV3YXJk" + "Q291bnQYAyABKAUSEAoIcmV3YXJkSWQYBCABKAUSEgoKcmV3YXJkVHlwZRgF" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventMissionCompleteRewardTable), EventMissionCompleteRewardTable.Parser, new string[5] { "CompleteMissionCount", "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
