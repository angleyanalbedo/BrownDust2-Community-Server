using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserContentsInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1VzZXJDb250ZW50c0luZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiQgoXVXNlckNvbnRlbnRzSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhoKEnRhcmdldF9vd25lcl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserContentsInfoRequest), UserContentsInfoRequest.Parser, new string[2] { "Seq", "TargetOwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
