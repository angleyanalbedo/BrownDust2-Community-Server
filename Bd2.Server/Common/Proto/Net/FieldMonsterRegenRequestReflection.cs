using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterRegenRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0ZpZWxkTW9uc3RlclJlZ2VuUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjsKGEZpZWxkTW9uc3RlclJlZ2VuUmVxdWVzdBILCgNzZXEYASABKAUSEgoKbW9uc3Rlcl9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterRegenRequest), FieldMonsterRegenRequest.Parser, new string[2] { "Seq", "MonsterId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
