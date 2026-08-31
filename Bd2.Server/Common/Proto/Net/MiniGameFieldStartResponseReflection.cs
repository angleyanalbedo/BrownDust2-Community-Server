using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldStartResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9NaW5pR2FtZUZpZWxkU3RhcnRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IjUKGk1pbmlHYW1lRmllbGRTdGFydFJlc3BvbnNlEhcKD2ZpZWxkX29iamVjdF9pZBgBIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldStartResponse), MiniGameFieldStartResponse.Parser, new string[1] { "FieldObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
