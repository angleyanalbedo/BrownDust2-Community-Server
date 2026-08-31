using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C93 RID: 31891
	public static class FishingInventoryBuyTableReflection
	{
		// Token: 0x17011228 RID: 70184
		// (get) Token: 0x06046C98 RID: 289944 RVA: 0x01137248 File Offset: 0x01135448
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingInventoryBuyTableReflection.descriptor;
			}
		}

		// Token: 0x0402EAFA RID: 191226
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Cjljb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nSW52ZW50b3J5", "QnV5VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ibAoYRmlzaGlu", "Z0ludmVudG9yeUJ1eVRhYmxlEhEKCWNvc3RDb3VudBgBIAEoBRIOCgZjb3N0", "SWQYAiABKAUSEAoIY29zdFR5cGUYAyABKAUSDwoHZ3JvdXBJZBgEIAEoBRIK", "CgJpZBgFIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8u", "RGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingInventoryBuyTable), FishingInventoryBuyTable.Parser, new string[] { "CostCount", "CostId", "CostType", "GroupId", "Id" }, null, null, null, null)
		}));
	}
}
