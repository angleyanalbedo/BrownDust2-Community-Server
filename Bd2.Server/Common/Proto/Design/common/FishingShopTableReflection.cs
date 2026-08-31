using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA8 RID: 31912
	public static class FishingShopTableReflection
	{
		// Token: 0x1701126F RID: 70255
		// (get) Token: 0x06046D83 RID: 290179 RVA: 0x01139EE2 File Offset: 0x011380E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingShopTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB71 RID: 191345
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nU2hvcFRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpkBChBGaXNoaW5nU2hvcFRh", "YmxlEhQKDGN1cnJlbmN5VHlwZRgBIAMoBRIWCg5kaWFsb3VnZVRleHRJZBgC", "IAEoBRIKCgJpZBgDIAEoBRISCgppbGx1c3ROYW1lGAQgASgJEhUKDW5wY05h", "bWVUZXh0SWQYBSABKAUSEgoKc2hvcEl0ZW1JZBgGIAEoBRIMCgR0eXBlGAcg", "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u", "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingShopTable), FishingShopTable.Parser, new string[] { "CurrencyType", "DialougeTextId", "Id", "IllustName", "NpcNameTextId", "ShopItemId", "Type" }, null, null, null, null)
		}));
	}
}
