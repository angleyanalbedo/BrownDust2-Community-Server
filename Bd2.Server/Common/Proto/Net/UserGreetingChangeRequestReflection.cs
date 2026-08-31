using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserGreetingChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1VzZXJHcmVldGluZ0NoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI6ChlVc2VyR3JlZXRpbmdDaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCghncmVldGluZxgCIAEoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserGreetingChangeRequest), UserGreetingChangeRequest.Parser, new string[2] { "Seq", "Greeting" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
