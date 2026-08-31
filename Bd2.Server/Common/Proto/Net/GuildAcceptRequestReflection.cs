using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildAcceptRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0d1aWxkQWNjZXB0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjYKEkd1aWxkQWNjZXB0UmVxdWVzdBILCgNzZXEYASABKAUSEwoLb3duZXJfaW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildAcceptRequest), GuildAcceptRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
