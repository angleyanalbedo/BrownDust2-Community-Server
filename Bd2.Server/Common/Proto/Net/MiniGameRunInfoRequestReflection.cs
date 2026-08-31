using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameRunInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L01pbmlHYW1lUnVuSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJAChZNaW5pR2FtZVJ1bkluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFldmVudF9zY2hlZHVsZV9pZBgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameRunInfoRequest), MiniGameRunInfoRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
