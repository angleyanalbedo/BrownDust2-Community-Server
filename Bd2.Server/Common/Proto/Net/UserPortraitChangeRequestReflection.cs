using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserPortraitChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1VzZXJQb3J0cmFpdENoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJFChlVc2VyUG9ydHJhaXRDaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIbChNwb3J0cmFpdF9jb3N0dW1lX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserPortraitChangeRequest), UserPortraitChangeRequest.Parser, new string[2] { "Seq", "PortraitCostumeId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
