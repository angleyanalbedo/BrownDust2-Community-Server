using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9DaGFyUGFydG5lckluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0Gh9Db21tb25zL0NoYXJQYXJ0bmVyREJJbmZvLnByb3RvIlIKF0NoYXJQYXJ0bmVySW5mb1Jlc3BvbnNlEjcKEWNoYXJfcGFydG5lcl9pbmZvGAEgAygLMhwucHJvdG8ubmV0LkNoYXJQYXJ0bmVyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { CharPartnerDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerInfoResponse), CharPartnerInfoResponse.Parser, new string[1] { "CharPartnerInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
