using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EnvInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVDb21tb25zL0VudkluZm8ucHJvdG8SCXByb3RvLm5ldCIrCgdFbnZJbmZvEg8KB2lzX2xpdmUYASABKAgSDwoHdXNlX3NkaxgCIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EnvInfo), EnvInfo.Parser, new string[2] { "IsLive", "UseSdk" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
