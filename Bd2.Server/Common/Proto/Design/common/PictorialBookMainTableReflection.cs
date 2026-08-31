using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PictorialBookMainTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9QaWN0b3JpYWxC" + "b29rTWFpblRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIrsBChZQ" + "aWN0b3JpYWxCb29rTWFpblRhYmxlEhcKD2NvbmRpdGlvbkNoYXJJZBgBIAEo" + "BRIUCgxlbGVtZW50X3R5cGUYAiADKAUSCgoCaWQYAyABKAUSEAoIbWVudUlj" + "b24YBCABKAkSHAoUbWVudVRpdGxlTG9jYWxUZXh0SWQYBSABKAUSFgoOcGlj" + "dG9yaWFsT3JkZXIYBiABKAUSDAoEdHlwZRgHIAEoBRIQCgh1c2VCbGluZBgI" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PictorialBookMainTable), PictorialBookMainTable.Parser, new string[8] { "ConditionCharId", "ElementType", "Id", "MenuIcon", "MenuTitleLocalTextId", "PictorialOrder", "Type", "UseBlind" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
