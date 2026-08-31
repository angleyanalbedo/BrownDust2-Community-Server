using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C75 RID: 31861
	public static class FishingBuyItemTableReflection
	{
		// Token: 0x17011189 RID: 70025
		// (get) Token: 0x06046AD9 RID: 289497 RVA: 0x011302EE File Offset: 0x0112E4EE
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingBuyItemTableReflection.descriptor;
			}
		}

		// Token: 0x0402E9D9 RID: 190937
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjRjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQnV5SXRlbVRh", "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIuYBChNGaXNoaW5nQnV5", "SXRlbVRhYmxlEg8KB2dyb3VwSWQYASABKAUSCgoCaWQYAiABKAUSEQoJaXRl", "bUNvdW50GAMgASgFEg4KBml0ZW1JZBgEIAEoBRIQCghpdGVtVHlwZRgFIAEo", "BRISCgpwcmljZUNvdW50GAYgASgFEg8KB3ByaWNlSWQYByABKAUSEQoJcHJp", "Y2VUeXBlGAggASgFEhoKEnB1cmNoYXNlTGltaXRDb3VudBgJIAEoBRIZChFw", "dXJjaGFzZUxpbWl0VHlwZRgKIAEoBRIOCgZzb3J0SWQYCyABKAVCREITUHJv", "dG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQ", "cm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM=" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingBuyItemTable), FishingBuyItemTable.Parser, new string[]
			{
				"GroupId", "Id", "ItemCount", "ItemId", "ItemType", "PriceCount", "PriceId", "PriceType", "PurchaseLimitCount", "PurchaseLimitType",
				"SortId"
			}, null, null, null, null)
		}));
	}
}
