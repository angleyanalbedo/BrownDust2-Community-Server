using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NoticeInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L05vdGljZUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOQoRTm90aWNlSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhcKD25vdGljZV9sYXN0X3NlcRgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NoticeInfoRequest), NoticeInfoRequest.Parser, new string[2] { "Seq", "NoticeLastSeq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
