using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleTotalDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL0V2aWxDYXN0bGVUb3RhbERCSW5mby5wcm90bxIJcHJvdG8ubmV0IkkKFUV2aWxDYXN0bGVUb3RhbERCSW5mbxIMCgRyYW5rGAEgASgFEg0KBXBvaW50GAIgASgFEhMKC2lzX3Jld2FyZGVkGAMgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTotalDBInfo), EvilCastleTotalDBInfo.Parser, new string[3] { "Rank", "Point", "IsRewarded" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
