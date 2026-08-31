using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaPointManualExchangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L0dhY2hhUG9pbnRNYW51YWxFeGNoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJPCh9HYWNoYVBvaW50TWFudWFsRXhjaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCghncm91cF9pZBgCIAEoAxINCgVjb3VudBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaPointManualExchangeRequest), GachaPointManualExchangeRequest.Parser, new string[3] { "Seq", "GroupId", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
