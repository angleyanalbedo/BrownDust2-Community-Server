using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayScheduleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9Ta3lXYXlTY2hlZHVsZUluZm9SZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GiJDb21tb25zL1NreVdheVNjaGVkdWxlREJJbmZvLnByb3Rv" + "IlQKGlNreVdheVNjaGVkdWxlSW5mb1Jlc3BvbnNlEjYKDXNjaGVkdWxlX2lu" + "Zm8YASADKAsyHy5wcm90by5uZXQuU2t5V2F5U2NoZWR1bGVEQkluZm9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { SkyWayScheduleDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayScheduleInfoResponse), SkyWayScheduleInfoResponse.Parser, new string[1] { "ScheduleInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
