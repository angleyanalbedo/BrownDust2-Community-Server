using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventShopTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50U2hvcFRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIm0KDkV2ZW50U2hvcFRh" + "YmxlEhMKC2V2ZW50VGV4dElkGAEgASgFEgoKAmlkGAIgASgFEg8KB3ByaWNl" + "SWQYAyADKAUSEQoJcHJpY2VUeXBlGAQgAygFEhYKDnByb2R1Y3RHcm91cElk" + "GAUgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventShopTable), EventShopTable.Parser, new string[5] { "EventTextId", "Id", "PriceId", "PriceType", "ProductGroupId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
