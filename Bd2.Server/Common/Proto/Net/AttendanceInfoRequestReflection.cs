using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AttendanceInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0F0dGVuZGFuY2VJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkoKFUF0dGVuZGFuY2VJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSEgoKc3RhcnRfZGF0ZRgCIAEoBRIQCghlbmRfZGF0ZRgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceInfoRequest), AttendanceInfoRequest.Parser, new string[3] { "Seq", "StartDate", "EndDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
