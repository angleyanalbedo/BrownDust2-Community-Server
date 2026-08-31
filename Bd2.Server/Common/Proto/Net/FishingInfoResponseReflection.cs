using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005261 RID: 21089
	public static class FishingInfoResponseReflection
	{
		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x06023013 RID: 143379 RVA: 0x008DC724 File Offset: 0x008DA924
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018399 RID: 99225
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiJSZXNwb25zZS9GaXNoaW5nSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5u", "ZXQaG0NvbW1vbnMvRmlzaGluZ0RCSW5mby5wcm90bxogQ29tbW9ucy9SZXdh", "cmREQkluZm9CdW5kbGUucHJvdG8iowEKE0Zpc2hpbmdJbmZvUmVzcG9uc2US", "KwoJZmlzaF9pbmZvGAEgASgLMhgucHJvdG8ubmV0LkZpc2hpbmdEQkluZm8S", "DgoGbWFwX2lkGAIgAygFEhQKDGJvYXRfc2tpbl9pZBgDIAMoBRI5ChJyZXdh", "cmRfaW5mb19idW5kbGUYBCABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZv", "QnVuZGxlYgZwcm90bzM=" })), new FileDescriptor[]
		{
			FishingDBInfoReflection.Descriptor,
			RewardDBInfoBundleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingInfoResponse), FishingInfoResponse.Parser, new string[] { "FishInfo", "MapId", "BoatSkinId", "RewardInfoBundle" }, null, null, null, null)
		}));
	}
}
