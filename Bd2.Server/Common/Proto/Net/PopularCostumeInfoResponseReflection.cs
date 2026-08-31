using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularCostumeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9Qb3B1bGFyQ29zdHVtZUluZm9SZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GidDb21tb25zL1BvcHVsYXJDb3N0dW1lQ291bnREQkluZm8u" + "cHJvdG8iUAoaUG9wdWxhckNvc3R1bWVJbmZvUmVzcG9uc2USMgoEaW5mbxgB" + "IAMoCzIkLnByb3RvLm5ldC5Qb3B1bGFyQ29zdHVtZUNvdW50REJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[1] { PopularCostumeCountDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularCostumeInfoResponse), PopularCostumeInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
