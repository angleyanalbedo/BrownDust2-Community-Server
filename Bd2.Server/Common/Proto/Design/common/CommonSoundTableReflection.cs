using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CommonSoundTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvU291bmRUYWJsZV9fX+yCrOyatOuTnC9Db21tb25Tb3Vu" + "ZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIrsBChBDb21tb25T" + "b3VuZFRhYmxlEhcKD2JnbVBsYXllckhpZGRlbhgBIAEoBRIXCg9jb250ZW50" + "VGlja2V0SWQYAiABKAUSCgoCaWQYAyABKAUSDgoGcGFja0lkGAQgASgFEg4K" + "BnNvcnRJZBgFIAEoBRIXCg9zb3VuZE5hbWVUZXh0SWQYBiABKAUSEQoJc291" + "bmRQYXRoGAcgASgJEh0KFXNvdW5kU291cmNlTmFtZVRleHRJZBgIIAEoBUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CommonSoundTable), CommonSoundTable.Parser, new string[8] { "BgmPlayerHidden", "ContentTicketId", "Id", "PackId", "SortId", "SoundNameTextId", "SoundPath", "SoundSourceNameTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
