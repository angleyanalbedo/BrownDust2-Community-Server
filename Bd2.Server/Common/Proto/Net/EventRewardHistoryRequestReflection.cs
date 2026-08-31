using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventRewardHistoryRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0V2ZW50UmV3YXJkSGlzdG9yeVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIoChlFdmVudFJld2FyZEhpc3RvcnlSZXF1ZXN0EgsKA3NlcRgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventRewardHistoryRequest), EventRewardHistoryRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
