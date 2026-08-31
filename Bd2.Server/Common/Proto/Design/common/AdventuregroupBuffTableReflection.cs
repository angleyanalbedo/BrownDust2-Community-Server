using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AdventuregroupBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9BZHZlbnR1cmVn" + "cm91cEJ1ZmZUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJKChdB" + "ZHZlbnR1cmVncm91cEJ1ZmZUYWJsZRIKCgJpZBgBIAEoBRIQCghzdGF0VHlw" + "ZRgCIAEoBRIRCglzdGF0VmFsdWUYAyABKAFCREITUHJvdG8uRGVzaWduLmNv" + "bW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24u" + "Y29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AdventuregroupBuffTable), AdventuregroupBuffTable.Parser, new string[3] { "Id", "StatType", "StatValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
