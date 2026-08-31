using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NoticeDetailInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L05vdGljZURldGFpbEluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOQoXTm90aWNlRGV0YWlsSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhEKCW5vdGljZV9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NoticeDetailInfoRequest), NoticeDetailInfoRequest.Parser, new string[2] { "Seq", "NoticeId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
