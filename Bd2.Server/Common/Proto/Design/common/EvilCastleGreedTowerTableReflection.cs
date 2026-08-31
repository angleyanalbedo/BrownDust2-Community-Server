using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleGreedTowerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVH" + "cmVlZFRvd2VyVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iaQoZ" + "RXZpbENhc3RsZUdyZWVkVG93ZXJUYWJsZRIUCgxiYXR0bGVEZWNrSWQYASAB" + "KAUSEwoLYmF0dGxlUG93ZXIYAiABKAUSCgoCaWQYAyABKAUSFQoNaXNGaXhl" + "ZENhbWVyYRgEIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleGreedTowerTable), EvilCastleGreedTowerTable.Parser, new string[4] { "BattleDeckId", "BattlePower", "Id", "IsFixedCamera" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
