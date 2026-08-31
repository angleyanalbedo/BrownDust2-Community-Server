using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PresetTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9Q" + "cmVzZXRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiIrCgtQcmVz" + "ZXRUYWJsZRIQCghpY29uTmFtZRgBIAEoCRIKCgJpZBgCIAEoBUJEQhNQcm90" + "by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1By" + "b3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetTable), PresetTable.Parser, new string[2] { "IconName", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
