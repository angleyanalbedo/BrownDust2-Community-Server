using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectPositionDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0ZpZWxkT2JqZWN0UG9zaXRpb25EQkluZm8ucHJvdG8SCXByb3RvLm5ldCJMChlGaWVsZE9iamVjdFBvc2l0aW9uREJJbmZvEg4KBm1hcF9pZBgBIAEoBRIJCgF4GAIgASgCEgkKAXkYAyABKAISCQoBehgEIAEoAmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectPositionDBInfo), FieldObjectPositionDBInfo.Parser, new string[4] { "MapId", "X", "Y", "Z" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
