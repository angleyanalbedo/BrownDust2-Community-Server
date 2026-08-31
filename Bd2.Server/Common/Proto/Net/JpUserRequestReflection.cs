using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class JpUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSZXF1ZXN0L0pwVXNlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJGCg1KcFVzZXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRIMCgR5ZWFyGAIgASgFEg0KBW1vbnRoGAMgASgFEgsKA2RheRgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(JpUserRequest), JpUserRequest.Parser, new string[4] { "Seq", "Year", "Month", "Day" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
