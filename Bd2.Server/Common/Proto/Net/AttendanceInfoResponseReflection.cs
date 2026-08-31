using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AttendanceInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9BdHRlbmRhbmNlSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQiMQoWQXR0ZW5kYW5jZUluZm9SZXNwb25zZRIXCg9hdHRlbmRhbmNlX3RpbWUYASADKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceInfoResponse), AttendanceInfoResponse.Parser, new string[1] { "AttendanceTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
