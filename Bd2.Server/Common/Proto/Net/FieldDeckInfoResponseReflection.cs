using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9GaWVsZERlY2tJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBodQ29tbW9ucy9GaWVsZERlY2tEQkluZm8ucHJvdG8iTAoVRmllbGREZWNrSW5mb1Jlc3BvbnNlEjMKD2ZpZWxkX2RlY2tfaW5mbxgBIAMoCzIaLnByb3RvLm5ldC5GaWVsZERlY2tEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { FieldDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldDeckInfoResponse), FieldDeckInfoResponse.Parser, new string[1] { "FieldDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
