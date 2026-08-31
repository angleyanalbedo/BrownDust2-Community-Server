using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0FjaGlldmVtZW50REJJbmZvLnByb3RvEglwcm90by5uZXQiYgoRQWNoaWV2ZW1lbnREQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSDQoFdmFsdWUYAiABKAMSFAoMbWF4X2NsZWFyX2lkGAMgASgFEhYKDmNvbnRlbnRzX2dyb3VwGAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementDBInfo), AchievementDBInfo.Parser, new string[4] { "GroupId", "Value", "MaxClearId", "ContentsGroup" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
