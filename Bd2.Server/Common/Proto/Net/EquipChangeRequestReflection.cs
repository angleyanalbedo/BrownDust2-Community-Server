using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0VxdWlwQ2hhbmdlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkoKEkVxdWlwQ2hhbmdlUmVxdWVzdBILCgNzZXEYASABKAUSEwoLZXF1aXBfaW5kZXgYAiABKAMSEgoKY2hhcl9pbmRleBgDIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipChangeRequest), EquipChangeRequest.Parser, new string[3] { "Seq", "EquipIndex", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
