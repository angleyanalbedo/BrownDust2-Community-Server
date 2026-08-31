using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserTitleChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L1VzZXJUaXRsZUNoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI3ChZVc2VyVGl0bGVDaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCgh0aXRsZV9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserTitleChangeRequest), UserTitleChangeRequest.Parser, new string[2] { "Seq", "TitleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
