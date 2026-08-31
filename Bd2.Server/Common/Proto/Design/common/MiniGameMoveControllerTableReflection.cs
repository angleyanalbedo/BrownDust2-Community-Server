using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameMoveControllerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL01pbmlHYW1l" + "TW92ZUNvbnRyb2xsZXJUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biKUAQobTWluaUdhbWVNb3ZlQ29udHJvbGxlclRhYmxlEh4KFmNvbnRyb2xs" + "ZXJSZXNvdXJjZU5hbWUYASABKAkSDwoHZ3JvdXBJZBgCIAEoBRIKCgJpZBgD" + "IAEoBRIUCgxtb3ZlTWF4Q291bnQYBCABKAUSFAoMbW92ZU1pbkNvdW50GAUg" + "ASgFEgwKBHR5cGUYBiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUu" + "L1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameMoveControllerTable), MiniGameMoveControllerTable.Parser, new string[6] { "ControllerResourceName", "GroupId", "Id", "MoveMaxCount", "MoveMinCount", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
