using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldBuffDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0ZpZWxkQnVmZkRCSW5mby5wcm90bxIJcHJvdG8ubmV0IkgKD0ZpZWxkQnVmZkRCSW5mbxIPCgdidWZmX2lkGAEgASgFEhIKCmJ1ZmZfY291bnQYAiABKAUSEAoIZW5kX3RpbWUYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldBuffDBInfo), FieldBuffDBInfo.Parser, new string[3] { "BuffId", "BuffCount", "EndTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
