using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementClearInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL0FjaGlldmVtZW50Q2xlYXJJbmZvLnByb3RvEglwcm90by5uZXQiNAoUQWNoaWV2ZW1lbnRDbGVhckluZm8SEAoIZ3JvdXBfaWQYASABKAUSCgoCaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementClearInfo), AchievementClearInfo.Parser, new string[2] { "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
