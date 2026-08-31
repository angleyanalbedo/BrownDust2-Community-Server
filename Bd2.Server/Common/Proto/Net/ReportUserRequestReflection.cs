using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ReportUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1JlcG9ydFVzZXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPAoRUmVwb3J0VXNlclJlcXVlc3QSCwoDc2VxGAEgASgFEhoKEnRhcmdldF9vd25lcl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ReportUserRequest), ReportUserRequest.Parser, new string[2] { "Seq", "TargetOwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
