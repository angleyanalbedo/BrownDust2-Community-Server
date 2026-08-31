using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL1NreVdheURCSW5mby5wcm90bxIJcHJvdG8ubmV0GhtDb21tb25zL01vbnN0ZXJEQkluZm8ucHJvdG8iXgoMU2t5V2F5REJJbmZvEg8KB2lzX2F1dG8YASABKAgSEAoIZ3JvdXBfaWQYAiABKAUSEgoKY3VycmVudF9pZBgDIAEoBRIXCg9tYXhfY2xlYXJfbGV2ZWwYBCABKAViBnByb3RvMw=="), new FileDescriptor[1] { MonsterDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayDBInfo), SkyWayDBInfo.Parser, new string[4] { "IsAuto", "GroupId", "CurrentId", "MaxClearLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
