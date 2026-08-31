using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaStepUpScheduleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0dhY2hhU3RlcFVwU2NoZWR1bGVEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJTChlHYWNoYVN0ZXBVcFNjaGVkdWxlREJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEhIKCnN0YXJ0X3RpbWUYAiABKAMSEAoIZW5kX3RpbWUYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaStepUpScheduleDBInfo), GachaStepUpScheduleDBInfo.Parser, new string[3] { "GroupId", "StartTime", "EndTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
