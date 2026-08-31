using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1RvdGFsV2FyRGVja0RCSW5mby5wcm90bxIJcHJvdG8ubmV0IjwKElRvdGFsV2FyRGVja0RCSW5mbxIRCglwbGF5X3R5cGUYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckDBInfo), TotalWarDeckDBInfo.Parser, new string[2] { "PlayType", "InvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
