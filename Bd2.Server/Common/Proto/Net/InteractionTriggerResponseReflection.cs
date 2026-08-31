using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class InteractionTriggerResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9JbnRlcmFjdGlvblRyaWdnZXJSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IhwKGkludGVyYWN0aW9uVHJpZ2dlclJlc3BvbnNlYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InteractionTriggerResponse), InteractionTriggerResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
