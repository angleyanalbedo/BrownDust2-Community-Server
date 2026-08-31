using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA2 RID: 31906
	public static class FishingRodTableReflection
	{
		// Token: 0x1701125A RID: 70234
		// (get) Token: 0x06046D3E RID: 290110 RVA: 0x011391BF File Offset: 0x011373BF
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingRodTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB4E RID: 191310
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjBjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nUm9kVGFibGUu", "cHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iiAEKD0Zpc2hpbmdSb2RUYWJs", "ZRIUCgxhdmF0YXJJdGVtSWQYASABKAUSDgoGYnVmZklkGAIgAygFEhcKD2Rl", "c2NMb2NhbFRleHRJZBgDIAEoBRIWCg5pY29uU3ByaXRlTmFtZRgEIAEoCRIK", "CgJpZBgFIAEoBRISCgpuYW1lVGV4dElkGAYgASgFQkRCE1Byb3RvLkRlc2ln", "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz", "aWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingRodTable), FishingRodTable.Parser, new string[] { "AvatarItemId", "BuffId", "DescLocalTextId", "IconSpriteName", "Id", "NameTextId" }, null, null, null, null)
		}));
	}
}
