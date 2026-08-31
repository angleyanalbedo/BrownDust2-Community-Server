using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundInfoListResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
	{
		"CixSZXNwb25zZS9IdW50aW5nR3JvdW5kSW5mb0xpc3RSZXNwb25zZS5wcm90",
		"bxIJcHJvdG8ubmV0GiFDb21tb25zL0h1bnRpbmdHcm91bmREQkluZm8ucHJv",
		"dG8iXAodSHVudGluZ0dyb3VuZEluZm9MaXN0UmVzcG9uc2USOwoTaHVudGlu",
		"Z19ncm91bmRfaW5mbxgBIAMoCzIeLnByb3RvLm5ldC5IdW50aW5nR3JvdW5k",
		"REJJbmZvYgZwcm90bzM="
	})), new FileDescriptor[1] { HuntingGroundDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundInfoListResponse), HuntingGroundInfoListResponse.Parser, new string[1] { "HuntingGroundInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
