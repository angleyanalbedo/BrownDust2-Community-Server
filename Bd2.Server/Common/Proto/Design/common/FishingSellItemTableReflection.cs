using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA5 RID: 31909
	public static class FishingSellItemTableReflection
	{
		// Token: 0x17011264 RID: 70244
		// (get) Token: 0x06046D5F RID: 290143 RVA: 0x01139819 File Offset: 0x01137A19
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingSellItemTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB5F RID: 191327
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjVjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nU2VsbEl0ZW1U", "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKNAQoURmlzaGluZ1Nl", "bGxJdGVtVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgCIAEoBRIOCgZp", "dGVtSWQYAyABKAUSEAoIaXRlbVR5cGUYBCABKAUSEgoKcHJpY2VDb3VudBgF", "IAEoBRIPCgdwcmljZUlkGAYgASgFEhEKCXByaWNlVHlwZRgHIAEoBUJEQhNQ", "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC", "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingSellItemTable), FishingSellItemTable.Parser, new string[] { "GroupId", "Id", "ItemId", "ItemType", "PriceCount", "PriceId", "PriceType" }, null, null, null, null)
		}));
	}
}
