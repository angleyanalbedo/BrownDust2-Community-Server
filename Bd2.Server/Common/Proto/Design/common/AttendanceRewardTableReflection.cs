using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AttendanceRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvQXR0ZW5kYW5jZV9fX+yblOygleyVoS9BdHRlbmRhbmNl" + "UmV3YXJkVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ibwoVQXR0" + "ZW5kYW5jZVJld2FyZFRhYmxlEg8KB2dyb3VwSWQYASABKAUSCgoCaWQYAiAB" + "KAUSEwoLcmV3YXJkQ291bnQYAyABKAUSEAoIcmV3YXJkSWQYBCABKAUSEgoK" + "cmV3YXJkVHlwZRgFIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v" + "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceRewardTable), AttendanceRewardTable.Parser, new string[5] { "GroupId", "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
