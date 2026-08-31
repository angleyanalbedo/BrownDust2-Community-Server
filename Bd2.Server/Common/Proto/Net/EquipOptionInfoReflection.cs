using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipOptionInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0VxdWlwT3B0aW9uSW5mby5wcm90bxIJcHJvdG8ubmV0Ii8KD0VxdWlwT3B0aW9uSW5mbxIQCghncm91cF9pZBgBIAEoBRIKCgJpZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipOptionInfo), EquipOptionInfo.Parser, new string[2] { "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
