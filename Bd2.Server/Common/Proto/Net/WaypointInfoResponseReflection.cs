using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class WaypointInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9XYXlwb2ludEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IisKFFdheXBvaW50SW5mb1Jlc3BvbnNlEhMKC3dheXBvaW50X2lkGAEgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(WaypointInfoResponse), WaypointInfoResponse.Parser, new string[1] { "WaypointId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
