using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200547D RID: 21629
	public static class MiniGameDefenseInfoResponseReflection
	{
		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x060241DC RID: 147932 RVA: 0x00901B89 File Offset: 0x008FFD89
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniGameDefenseInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401898A RID: 100746
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9NaW5pR2FtZURlZmVuc2VJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldCJNChtNaW5pR2FtZURlZmVuc2VJbmZvUmVzcG9uc2USGQoR" + "ZXZlbnRfc2NoZWR1bGVfaWQYASABKAUSEwoLcmV3YXJkX2luZm8YAiADKAVi" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniGameDefenseInfoResponse), MiniGameDefenseInfoResponse.Parser, new string[] { "EventScheduleId", "RewardInfo" }, null, null, null, null)
		}));
	}
}
