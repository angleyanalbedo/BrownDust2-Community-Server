using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentNpcDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL1RhbGVudE5wY0RCSW5mby5wcm90bxIJcHJvdG8ubmV0IkUKD1RhbGVudE5wY0RCSW5mbxIOCgZucGNfaWQYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUSEAoIZW5kX3RpbWUYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentNpcDBInfo), TalentNpcDBInfo.Parser, new string[3] { "NpcId", "GroupId", "EndTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
