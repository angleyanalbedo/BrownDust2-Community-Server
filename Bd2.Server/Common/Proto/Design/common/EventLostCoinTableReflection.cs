using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventLostCoinTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50TG9zdENv" + "aW5UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJyChJFdmVudExv" + "c3RDb2luVGFibGUSEwoLZXZlbnRQYWNrSWQYASADKAUSHAoUZ3VpZGVEZXNj" + "TG9jYWxUZXh0SWQYAiADKAUSHQoVZ3VpZGVUaXRsZUxvY2FsVGV4dElkGAMg" + "AygFEgoKAmlkGAQgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Q" + "cm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventLostCoinTable), EventLostCoinTable.Parser, new string[4] { "EventPackId", "GuideDescLocalTextId", "GuideTitleLocalTextId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
