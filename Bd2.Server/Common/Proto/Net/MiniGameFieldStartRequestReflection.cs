using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldStartRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L01pbmlHYW1lRmllbGRTdGFydFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJDChlNaW5pR2FtZUZpZWxkU3RhcnRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFldmVudF9zY2hlZHVsZV9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldStartRequest), MiniGameFieldStartRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
