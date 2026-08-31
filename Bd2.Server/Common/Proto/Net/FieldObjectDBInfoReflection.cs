using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0ZpZWxkT2JqZWN0REJJbmZvLnByb3RvEglwcm90by5uZXQa" + "J0NvbW1vbnMvRmllbGRPYmplY3RQb3NpdGlvbkRCSW5mby5wcm90byJXChFG" + "aWVsZE9iamVjdERCSW5mbxIKCgJpZBgBIAEoBRI2Cghwb3NpdGlvbhgCIAEo" + "CzIkLnByb3RvLm5ldC5GaWVsZE9iamVjdFBvc2l0aW9uREJJbmZvYgZwcm90" + "bzM="), new FileDescriptor[1] { FieldObjectPositionDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectDBInfo), FieldObjectDBInfo.Parser, new string[2] { "Id", "Position" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
