using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class InteractionTriggerRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0ludGVyYWN0aW9uVHJpZ2dlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI8ChlJbnRlcmFjdGlvblRyaWdnZXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRISCgp0cmlnZ2VyX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InteractionTriggerRequest), InteractionTriggerRequest.Parser, new string[2] { "Seq", "TriggerId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
