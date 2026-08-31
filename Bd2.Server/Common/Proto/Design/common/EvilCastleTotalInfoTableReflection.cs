using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleTotalInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVU" + "b3RhbEluZm9UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJ3ChhF" + "dmlsQ2FzdGxlVG90YWxJbmZvVGFibGUSCgoCaWQYASABKAUSHwoXbG9iYnlC" + "YWNrR3JvdWRJbWFnZVBhdGgYAiABKAkSFQoNbG9iYnlJY29uUGF0aBgDIAEo" + "CRIXCg9sb2JieUlsbHVzdFBhdGgYBCABKAlCREITUHJvdG8uRGVzaWduLmNv" + "bW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24u" + "Y29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTotalInfoTable), EvilCastleTotalInfoTable.Parser, new string[4] { "Id", "LobbyBackGroudImagePath", "LobbyIconPath", "LobbyIllustPath" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
