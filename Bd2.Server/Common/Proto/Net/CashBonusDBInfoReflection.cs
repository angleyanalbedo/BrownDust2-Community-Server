using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043F6 RID: 17398
	public static class CashBonusDBInfoReflection
	{
		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0601B11F RID: 110879 RVA: 0x007B328A File Offset: 0x007B148A
		public static FileDescriptor Descriptor
		{
			get
			{
				return CashBonusDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014BFC RID: 84988
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0Nhc2hCb251c0RCSW5mby5wcm90bxIJcHJvdG8ubmV0ImYK" + "D0Nhc2hCb251c0RCSW5mbxIQCghncm91cF9pZBgBIAEoBRIZChFjb250ZW50" + "c19ncm91cF9pZBgCIAEoBRIRCglidXlfY291bnQYAyABKAUSEwoLcmV3YXJk" + "ZWRfaWQYBCADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CashBonusDBInfo), CashBonusDBInfo.Parser, new string[] { "GroupId", "ContentsGroupId", "BuyCount", "RewardedId" }, null, null, null, null)
		}));
	}
}
