using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L01vbnN0ZXJJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjMKEk1vbnN0ZXJJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSEAoIZ3JvdXBfaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterInfoRequest), MonsterInfoRequest.Parser, new string[2] { "Seq", "GroupId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
