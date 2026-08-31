using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleEnvyTowerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVF" + "bnZ5VG93ZXJUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJoChhF" + "dmlsQ2FzdGxlRW52eVRvd2VyVGFibGUSFAoMYmF0dGxlRGVja0lkGAEgASgF" + "EhMKC2JhdHRsZVBvd2VyGAIgASgFEgoKAmlkGAMgASgFEhUKDWlzRml4ZWRD" + "YW1lcmEYBCABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleEnvyTowerTable), EvilCastleEnvyTowerTable.Parser, new string[4] { "BattleDeckId", "BattlePower", "Id", "IsFixedCamera" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
