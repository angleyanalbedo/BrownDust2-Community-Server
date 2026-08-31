using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class JpUserInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9KcFVzZXJJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCJPChJKcFVzZXJJbmZvUmVzcG9uc2USIgoaYWNjdW11bGF0ZWRfcGF5bWVudF9hbW91bnQYASABKAISFQoNZGF0ZV9vZl9iaXJ0aBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(JpUserInfoResponse), JpUserInfoResponse.Parser, new string[2] { "AccumulatedPaymentAmount", "DateOfBirth" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
