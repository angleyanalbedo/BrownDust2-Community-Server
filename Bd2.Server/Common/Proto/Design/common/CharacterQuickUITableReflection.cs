using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharacterQuickUITableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJhY3RlclF1aWNrVUlUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biJrChVDaGFyYWN0ZXJRdWlja1VJVGFibGUSCgoCaWQYASABKAUSDwoHcXVp" + "Y2tVaRgCIAEoBRIaChJxdWlja1VpTG9jYWxUZXh0SWQYAyABKAUSGQoRcXVp" + "Y2tVaVNwcml0ZU5hbWUYBCABKAlCREITUHJvdG8uRGVzaWduLmNvbW1vblAB" + "WhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9u" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharacterQuickUITable), CharacterQuickUITable.Parser, new string[4] { "Id", "QuickUi", "QuickUiLocalTextId", "QuickUiSpriteName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
