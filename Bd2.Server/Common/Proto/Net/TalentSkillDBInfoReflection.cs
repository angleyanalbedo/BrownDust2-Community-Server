using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentSkillDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL1RhbGVudFNraWxsREJJbmZvLnByb3RvEglwcm90by5uZXQiXQoRVGFsZW50U2tpbGxEQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSEAoIZW5kX3RpbWUYAiABKAMSEQoJY29vbF90aW1lGAMgASgDEhEKCXVzZV9jb3VudBgEIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSkillDBInfo), TalentSkillDBInfo.Parser, new string[4] { "GroupId", "EndTime", "CoolTime", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
