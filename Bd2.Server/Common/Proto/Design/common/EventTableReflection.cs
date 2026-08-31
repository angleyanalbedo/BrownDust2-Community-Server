using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjBjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50VGFibGUu" + "cHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i0AEKCkV2ZW50VGFibGUSHQoV" + "YmFubmVyRm9udExvY2FsVGV4dElkGAEgASgFEhkKEWJhbm5lclJlc291Y2VO" + "YW1lGAIgASgJEhYKDmNhdGVnb3J5QmFubmVyGAMgASgJEg8KB2V2ZW50SWQY" + "BCABKAUSFwoPZXZlbnROYW1lVGV4dElkGAUgASgFEhEKCWV2ZW50VHlwZRgG" + "IAEoBRIKCgJpZBgHIAEoBRIXCg9pc0FjdGl2ZU9uRW50ZXIYCCABKAUSDgoG" + "c29ydElkGAkgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90" + "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventTable), EventTable.Parser, new string[9] { "BannerFontLocalTextId", "BannerResouceName", "CategoryBanner", "EventId", "EventNameTextId", "EventType", "Id", "IsActiveOnEnter", "SortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
