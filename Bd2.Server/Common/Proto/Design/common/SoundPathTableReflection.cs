using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SoundPathTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvU291bmRUYWJsZV9fX+yCrOyatOuTnC9Tb3VuZFBhdGhU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJHCg5Tb3VuZFBhdGhU" + "YWJsZRISCgpidXR0b25OYW1lGAEgASgJEgoKAmlkGAIgASgFEhUKDXNvdW5k" + "RmlsZVBhdGgYAyABKAlCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SoundPathTable), SoundPathTable.Parser, new string[3] { "ButtonName", "Id", "SoundFilePath" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
