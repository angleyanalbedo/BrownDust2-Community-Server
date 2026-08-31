using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TrapDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL1RyYXBEQkluZm8ucHJvdG8SCXByb3RvLm5ldCIvCgpUcmFwREJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEg8KB3RyYXBfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TrapDBInfo), TrapDBInfo.Parser, new string[2] { "GroupId", "TrapId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
