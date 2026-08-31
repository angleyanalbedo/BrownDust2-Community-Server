using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0VxdWlwVXNlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkcKD0VxdWlwVXNlUmVxdWVzdBILCgNzZXEYASABKAUSEwoLZXF1aXBfaW5kZXgYAiABKAMSEgoKY2hhcl9pbmRleBgDIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipUseRequest), EquipUseRequest.Parser, new string[3] { "Seq", "EquipIndex", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
