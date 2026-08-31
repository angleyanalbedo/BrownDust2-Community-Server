using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005264 RID: 21092
	public static class FishingItemInfoResponseReflection
	{
		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0602302F RID: 143407 RVA: 0x008DCC89 File Offset: 0x008DAE89
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingItemInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x040183A7 RID: 99239
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiZSZXNwb25zZS9GaXNoaW5nSXRlbUluZm9SZXNwb25zZS5wcm90bxIJcHJv", "dG8ubmV0Gh9Db21tb25zL0Zpc2hpbmdGaXNoREJJbmZvLnByb3RvGh5Db21t", "b25zL0Zpc2hpbmdSb2REQkluZm8ucHJvdG8aH0NvbW1vbnMvRmlzaGluZ0l0", "ZW1EQkluZm8ucHJvdG8iqgEKF0Zpc2hpbmdJdGVtSW5mb1Jlc3BvbnNlEi8K", "CWZpc2hfaW5mbxgBIAMoCzIcLnByb3RvLm5ldC5GaXNoaW5nRmlzaERCSW5m", "bxItCghyb2RfaW5mbxgCIAMoCzIbLnByb3RvLm5ldC5GaXNoaW5nUm9kREJJ", "bmZvEi8KCWl0ZW1faW5mbxgDIAMoCzIcLnByb3RvLm5ldC5GaXNoaW5nSXRl", "bURCSW5mb2IGcHJvdG8z" })), new FileDescriptor[]
		{
			FishingFishDBInfoReflection.Descriptor,
			FishingRodDBInfoReflection.Descriptor,
			FishingItemDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingItemInfoResponse), FishingItemInfoResponse.Parser, new string[] { "FishInfo", "RodInfo", "ItemInfo" }, null, null, null, null)
		}));
	}
}
