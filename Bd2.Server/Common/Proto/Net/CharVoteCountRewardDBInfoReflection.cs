using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004406 RID: 17414
	public static class CharVoteCountRewardDBInfoReflection
	{
		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0601B1C2 RID: 111042 RVA: 0x007B4EFC File Offset: 0x007B30FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return CharVoteCountRewardDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014C46 RID: 85062
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0NoYXJWb3RlQ291bnRSZXdhcmREQkluZm8ucHJvdG8SCXBy" + "b3RvLm5ldCJAChlDaGFyVm90ZUNvdW50UmV3YXJkREJJbmZvEhAKCGV2ZW50" + "X2lkGAEgASgFEhEKCXJld2FyZF9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CharVoteCountRewardDBInfo), CharVoteCountRewardDBInfo.Parser, new string[] { "EventId", "RewardId" }, null, null, null, null)
		}));
	}
}
