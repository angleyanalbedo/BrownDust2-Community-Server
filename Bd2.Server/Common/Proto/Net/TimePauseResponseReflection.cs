using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TimePauseResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9UaW1lUGF1c2VSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IigKEVRpbWVQYXVzZVJlc3BvbnNlEhMKC2FkZF9zZWNvbmRzGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TimePauseResponse), TimePauseResponse.Parser, new string[1] { "AddSeconds" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
