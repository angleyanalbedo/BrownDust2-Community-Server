using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RecipeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9SZWNpcGVJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCI0ChJSZWNpcGVJbmZvUmVzcG9uc2USCwoDc2VxGAEgASgFEhEKCXJlY2lwZV9pZBgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RecipeInfoResponse), RecipeInfoResponse.Parser, new string[2] { "Seq", "RecipeId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
