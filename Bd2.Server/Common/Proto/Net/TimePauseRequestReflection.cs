using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TimePauseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L1RpbWVQYXVzZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI0ChBUaW1lUGF1c2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgthY3Rpb25fdHlwZRgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TimePauseRequest), TimePauseRequest.Parser, new string[2] { "Seq", "ActionType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
