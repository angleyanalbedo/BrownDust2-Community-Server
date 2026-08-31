using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaPointExchangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0dhY2hhUG9pbnRFeGNoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI6ChlHYWNoYVBvaW50RXhjaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCghncm91cF9pZBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaPointExchangeRequest), GachaPointExchangeRequest.Parser, new string[2] { "Seq", "GroupId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
