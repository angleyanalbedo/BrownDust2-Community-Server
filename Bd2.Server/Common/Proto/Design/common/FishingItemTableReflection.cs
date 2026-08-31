using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C96 RID: 31894
	public static class FishingItemTableReflection
	{
		// Token: 0x17011231 RID: 70193
		// (get) Token: 0x06046CB8 RID: 289976 RVA: 0x011377AA File Offset: 0x011359AA
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingItemTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB08 RID: 191240
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nSXRlbVRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIocBChBGaXNoaW5nSXRlbVRh", "YmxlEg4KBmJ1ZmZJZBgBIAMoBRIXCg9kZXNjTG9jYWxUZXh0SWQYAiABKAUS", "FgoOaWNvblNwcml0ZU5hbWUYAyABKAkSCgoCaWQYBCABKAUSEgoKbmFtZVRl", "eHRJZBgFIAEoBRISCgpzdGFja0NvdW50GAYgASgFQkRCE1Byb3RvLkRlc2ln", "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz", "aWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingItemTable), FishingItemTable.Parser, new string[] { "BuffId", "DescLocalTextId", "IconSpriteName", "Id", "NameTextId", "StackCount" }, null, null, null, null)
		}));
	}
}
