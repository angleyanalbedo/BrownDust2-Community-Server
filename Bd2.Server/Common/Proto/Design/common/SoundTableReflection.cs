using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SoundTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFjb21tb24uZGIvU291bmRUYWJsZV9fX+yCrOyatOuTnC9Tb3VuZFRhYmxl" + "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIj8KClNvdW5kVGFibGUSCgoC" + "aWQYASABKAUSDgoGcGFja0lkGAIgASgFEhUKDXNvdW5kRmlsZVBhdGgYAyAB" + "KAlCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5j" + "b21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SoundTable), SoundTable.Parser, new string[3] { "Id", "PackId", "SoundFilePath" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
