using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200527C RID: 21116
	public static class FishingTrapInfoResponseReflection
	{
		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x060230FA RID: 143610 RVA: 0x008DE74C File Offset: 0x008DC94C
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingTrapInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x040183EC RID: 99308
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiZSZXNwb25zZS9GaXNoaW5nVHJhcEluZm9SZXNwb25zZS5wcm90bxIJcHJv", "dG8ubmV0Gh9Db21tb25zL0Zpc2hpbmdUcmFwREJJbmZvLnByb3RvIrABChdG", "aXNoaW5nVHJhcEluZm9SZXNwb25zZRIgChh0cmFwX3Jld2FyZF9yZWNlaXB0", "X3RpbWUYASABKAMSNAoOZmlzaF90cmFwX2luZm8YAiADKAsyHC5wcm90by5u", "ZXQuRmlzaGluZ1RyYXBEQkluZm8SFQoNdG90YWxfYWRkX2V4cBgDIAEoBRIT", "CgthZnRlcl9sZXZlbBgEIAEoBRIRCglhZnRlcl9leHAYBSABKAViBnByb3Rv", "Mw==" })), new FileDescriptor[] { FishingTrapDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingTrapInfoResponse), FishingTrapInfoResponse.Parser, new string[] { "TrapRewardReceiptTime", "FishTrapInfo", "TotalAddExp", "AfterLevel", "AfterExp" }, null, null, null, null)
		}));
	}
}
