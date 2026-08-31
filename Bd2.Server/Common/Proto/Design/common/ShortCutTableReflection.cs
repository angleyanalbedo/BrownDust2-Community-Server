using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ShortCutTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9T" + "aG9ydEN1dFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIj8KDVNo" + "b3J0Q3V0VGFibGUSCgoCaWQYASABKAUSEgoKbWFnaWNWYWx1ZRgCIAMoBRIO" + "CgZ1aU5hbWUYAyABKAlCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShortCutTable), ShortCutTable.Parser, new string[3] { "Id", "MagicValue", "UiName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
