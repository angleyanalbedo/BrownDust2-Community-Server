using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FieldMiniGameStarterTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL0ZpZWxkTWlu" + "aUdhbWVTdGFydGVyVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "dQoZRmllbGRNaW5pR2FtZVN0YXJ0ZXJUYWJsZRIKCgJpZBgBIAEoBRIdChVp" + "bnRlYWN0aW9uTG9jYWxUZXh0SWQYAiABKAUSGQoRaXNBdXRvSW50ZXJhY3Rp" + "b24YAyABKAUSEgoKbWluaUdhbWVJZBgEIAEoBUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMiniGameStarterTable), FieldMiniGameStarterTable.Parser, new string[4] { "Id", "InteactionLocalTextId", "IsAutoInteraction", "MiniGameId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
