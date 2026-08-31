using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class IllustViewerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9JbGx1c3RWaWV3" + "ZXJUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiI6ChFJbGx1c3RW" + "aWV3ZXJUYWJsZRIKCgJpZBgBIAEoBRIZChF2b2ljZVJlc291cmNlTmFtZRgC" + "IAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(IllustViewerTable), IllustViewerTable.Parser, new string[2] { "Id", "VoiceResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
