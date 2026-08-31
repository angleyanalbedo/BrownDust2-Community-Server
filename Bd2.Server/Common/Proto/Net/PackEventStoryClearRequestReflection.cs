using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventStoryClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L1BhY2tFdmVudFN0b3J5Q2xlYXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiWgoaUGFja0V2ZW50U3RvcnlDbGVhclJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWV2ZW50X3VpZBgCIAEoBRIQCghncm91cF9pZBgDIAEoBRIKCgJpZBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryClearRequest), PackEventStoryClearRequest.Parser, new string[4] { "Seq", "EventUid", "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
