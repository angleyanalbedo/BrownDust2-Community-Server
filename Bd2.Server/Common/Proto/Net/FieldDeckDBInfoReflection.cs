using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldDeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0ZpZWxkRGVja0RCSW5mby5wcm90bxIJcHJvdG8ubmV0IloKD0ZpZWxkRGVja0RCSW5mbxIQCghzZXF1ZW5jZRgBIAEoBRIYChBjaGFyX2ludmVuX2luZGV4GAIgASgDEhsKE2Nvc3R1bWVfaW52ZW5faW5kZXgYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldDeckDBInfo), FieldDeckDBInfo.Parser, new string[3] { "Sequence", "CharInvenIndex", "CostumeInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
