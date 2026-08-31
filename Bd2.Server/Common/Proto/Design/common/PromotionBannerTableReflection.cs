using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PromotionBannerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1Byb21vdGlvbkJh" + "bm5lclRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIqUBChRQcm9t" + "b3Rpb25CYW5uZXJUYWJsZRIWCg5iYW5uZXJDYXRlZ29yeRgBIAEoBRIdChVi" + "YW5uZXJGb250TG9jYWxUZXh0SWQYAiABKAUSEgoKYmFubmVyTmFtZRgDIAEo" + "CRIKCgJpZBgEIAEoBRIUCgxtYWdpY0dyb3VwSWQYBSABKAUSDwoHbWFnaWNJ" + "ZBgGIAEoBRIPCgdvcmRlcklkGAcgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21t" + "b25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNv" + "bW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PromotionBannerTable), PromotionBannerTable.Parser, new string[7] { "BannerCategory", "BannerFontLocalTextId", "BannerName", "Id", "MagicGroupId", "MagicId", "OrderId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
