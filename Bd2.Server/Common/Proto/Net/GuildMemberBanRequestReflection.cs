using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildMemberBanRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0d1aWxkTWVtYmVyQmFuUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjkKFUd1aWxkTWVtYmVyQmFuUmVxdWVzdBILCgNzZXEYASABKAUSEwoLb3duZXJfaW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildMemberBanRequest), GuildMemberBanRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
