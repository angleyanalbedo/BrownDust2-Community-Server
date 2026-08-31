using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackMemberTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9jb21tb24uZGIvUGFja1RhYmxlX19f7YypL1BhY2tNZW1iZXJUYWJsZS5w" + "cm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJaCg9QYWNrTWVtYmVyVGFibGUS" + "EgoKY2hhbmdlVHlwZRgBIAEoBRIKCgJpZBgCIAEoBRIQCghwYWNrVHlwZRgD" + "IAEoBRIVCg1zdWJNZW1iZXJUeXBlGAQgASgFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackMemberTable), PackMemberTable.Parser, new string[4] { "ChangeType", "Id", "PackType", "SubMemberType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
