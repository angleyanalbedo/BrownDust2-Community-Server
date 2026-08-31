using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LeaveUserResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9MZWF2ZVVzZXJSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IicKEUxlYXZlVXNlclJlc3BvbnNlEhIKCnVucmVnX2RhdGUYASABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LeaveUserResponse), LeaveUserResponse.Parser, new string[1] { "UnregDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
