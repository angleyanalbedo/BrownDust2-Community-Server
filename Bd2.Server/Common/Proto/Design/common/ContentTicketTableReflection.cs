using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentTicketTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b250ZW50VGlja2V0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "rgEKEkNvbnRlbnRUaWNrZXRUYWJsZRIXCg9kZXNjTG9jYWxUZXh0SWQYASAB" + "KAUSFgoOaWNvblNwcml0ZU5hbWUYAiABKAkSCgoCaWQYAyABKAUSGgoSaXRl" + "bURlc2NOYW1lVGV4dElkGAQgASgFEhYKDml0ZW1OYW1lVGV4dElkGAUgASgF" + "EhkKEWl0ZW1TdWJOYW1lVGV4dElkGAYgASgFEgwKBHR5cGUYByABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentTicketTable), ContentTicketTable.Parser, new string[7] { "DescLocalTextId", "IconSpriteName", "Id", "ItemDescNameTextId", "ItemNameTextId", "ItemSubNameTextId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
