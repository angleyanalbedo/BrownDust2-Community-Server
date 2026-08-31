using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayScheduleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL1NreVdheVNjaGVkdWxlREJJbmZvLnByb3RvEglwcm90by5uZXQiSQoUU2t5V2F5U2NoZWR1bGVEQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSCwoDZGF5GAIgAygFEhIKCmJvbnVzX3JhdGUYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayScheduleDBInfo), SkyWayScheduleDBInfo.Parser, new string[3] { "GroupId", "Day", "BonusRate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
