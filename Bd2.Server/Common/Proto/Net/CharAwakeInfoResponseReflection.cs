using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharAwakeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9DaGFyQXdha2VJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBodQ29tbW9ucy9DaGFyQXdha2VEQkluZm8ucHJvdG8iTAoVQ2hhckF3YWtlSW5mb1Jlc3BvbnNlEjMKD2NoYXJfYXdha2VfaW5mbxgBIAMoCzIaLnByb3RvLm5ldC5DaGFyQXdha2VEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { CharAwakeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharAwakeInfoResponse), CharAwakeInfoResponse.Parser, new string[1] { "CharAwakeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
