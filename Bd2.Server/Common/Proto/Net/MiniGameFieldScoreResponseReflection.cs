using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldScoreResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9NaW5pR2FtZUZpZWxkU2NvcmVSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IkcKGk1pbmlHYW1lRmllbGRTY29yZVJlc3BvbnNlEhUKDWN1cnJlbnRfc2NvcmUYASABKAUSEgoKY3VycmVudF9ocBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldScoreResponse), MiniGameFieldScoreResponse.Parser, new string[2] { "CurrentScore", "CurrentHp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
