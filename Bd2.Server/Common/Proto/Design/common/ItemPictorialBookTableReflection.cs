using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ItemPictorialBookTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9JdGVtUGljdG9y" + "aWFsQm9va1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uInAKFkl0" + "ZW1QaWN0b3JpYWxCb29rVGFibGUSEAoIY2F0ZWdvcnkYASABKAUSGAoQY29s" + "bGVjdGlvbkJ1ZmZJZBgCIAEoBRIKCgJpZBgDIAEoBRIOCgZpdGVtSWQYBCAB" + "KAUSDgoGcGFja0lkGAUgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoV" + "Li9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemPictorialBookTable), ItemPictorialBookTable.Parser, new string[5] { "Category", "CollectionBuffId", "Id", "ItemId", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
