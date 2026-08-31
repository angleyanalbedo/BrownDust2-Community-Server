using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldTrapInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9GaWVsZFRyYXBJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBodQ29tbW9ucy9GaWVsZFRyYXBEQkluZm8ucHJvdG8iTwoVRmllbGRUcmFwSW5mb1Jlc3BvbnNlEjYKEmZpZWxkX3RyYXBfZGJfaW5mbxgBIAMoCzIaLnByb3RvLm5ldC5GaWVsZFRyYXBEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { FieldTrapDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldTrapInfoResponse), FieldTrapInfoResponse.Parser, new string[1] { "FieldTrapDbInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
