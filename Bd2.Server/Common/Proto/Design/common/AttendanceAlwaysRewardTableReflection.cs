using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AttendanceAlwaysRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0F0dGVuZGFuY2VB" + "bHdheXNSZXdhcmRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKO" + "AQobQXR0ZW5kYW5jZUFsd2F5c1Jld2FyZFRhYmxlEhcKD2F0dGVuZGFuY2VD" + "b3VudBgBIAEoBRIPCgdncm91cElkGAIgASgFEgoKAmlkGAMgASgFEhMKC3Jl" + "d2FyZENvdW50GAQgASgFEhAKCHJld2FyZElkGAUgASgFEhIKCnJld2FyZFR5" + "cGUYBiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRl" + "c2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceAlwaysRewardTable), AttendanceAlwaysRewardTable.Parser, new string[6] { "AttendanceCount", "GroupId", "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
