using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleDamageDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL0JhdHRsZURhbWFnZURCSW5mby5wcm90bxIJcHJvdG8ubmV0Ii8KEkJhdHRsZURhbWFnZURCSW5mbxIKCgJpZBgBIAEoBRINCgV2YWx1ZRgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleDamageDBInfo), BattleDamageDBInfo.Parser, new string[2] { "Id", "Value" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
