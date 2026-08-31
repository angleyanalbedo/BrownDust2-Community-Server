using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043EA RID: 17386
	public static class CafeteriaDBInfoReflection
	{
		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0601B0AD RID: 110765 RVA: 0x007B21C4 File Offset: 0x007B03C4
		public static FileDescriptor Descriptor
		{
			get
			{
				return CafeteriaDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014BCE RID: 84942
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ch1Db21tb25zL0NhZmV0ZXJpYURCSW5mby5wcm90bxIJcHJvdG8ubmV0IqUC", "Cg9DYWZldGVyaWFEQkluZm8SDQoFbGV2ZWwYASABKAUSGwoTcmV3YXJkX3Jl", "Y2VpcHRfdGltZRgCIAEoAxISCgpzcGF3bl90aW1lGAMgASgDEhkKEW9uZ29p", "bmdfbWFuYWdlX2lkGAQgASgFEiAKGGRhaWx5X3JlZ3VsYXJfY29zdHVtZV9p", "ZBgFIAMoBRIpCiFyZXdhcmRlZF9kYWlseV9yZWd1bGFyX2Nvc3R1bWVfaWQY", "BiADKAUSIwobZGFpbHlfY29ubmVjdGlvbl9jb3N0dW1lX2lkGAcgASgFEhwK", "FGNhbl9nZXRfcGhvbmVfbnVtYmVyGAggASgIEicKH2RhaWx5X25wY19yZXdh", "cmRfY3VycmVuY3lfY291bnQYCSABKAViBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CafeteriaDBInfo), CafeteriaDBInfo.Parser, new string[] { "Level", "RewardReceiptTime", "SpawnTime", "OngoingManageId", "DailyRegularCostumeId", "RewardedDailyRegularCostumeId", "DailyConnectionCostumeId", "CanGetPhoneNumber", "DailyNpcRewardCurrencyCount" }, null, null, null, null)
		}));
	}
}
