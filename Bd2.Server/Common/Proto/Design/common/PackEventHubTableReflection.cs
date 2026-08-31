using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventHubTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudEh1" + "YlRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uItECChFQYWNrRXZl" + "bnRIdWJUYWJsZRIRCglhdGxhc05hbWUYASABKAkSDwoHYmdtTmFtZRgCIAEo" + "CRIRCgljb2xsYWJvSWQYAyABKAUSGQoRZXZlbnRCZ0lsbHVzdE5hbWUYBCAB" + "KAkSFQoNZXZlbnRMb2dvTmFtZRgFIAEoCRIXCg9ldmVudE5hbWVUZXh0SWQY" + "BiABKAUSFwoPZXZlbnRSZXNvdXJjZUlkGAcgASgFEhIKCmZha2VQYWNrSWQY" + "CCABKAUSFwoPZ3VpZGVEZXNjVGV4dElkGAkgAygFEhgKEGd1aWRlVGl0bGVU" + "ZXh0SWQYCiADKAUSCgoCaWQYCyABKAUSDQoFaXNIVUQYDCABKAUSFwoPbG9h" + "ZGluZ1BhZ2VOYW1lGA0gASgJEhYKDnBhY2tCYW5uZXJOYW1lGA4gASgJEg4K" + "BnBhY2tJZBgPIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventHubTable), PackEventHubTable.Parser, new string[15]
		{
			"AtlasName", "BgmName", "CollaboId", "EventBgIllustName", "EventLogoName", "EventNameTextId", "EventResourceId", "FakePackId", "GuideDescTextId", "GuideTitleTextId",
			"Id", "IsHUD", "LoadingPageName", "PackBannerName", "PackId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
