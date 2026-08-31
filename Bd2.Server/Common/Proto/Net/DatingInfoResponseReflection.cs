using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050EB RID: 20715
	public static class DatingInfoResponseReflection
	{
		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06022369 RID: 140137 RVA: 0x008BF272 File Offset: 0x008BD472
		public static FileDescriptor Descriptor
		{
			get
			{
				return DatingInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017EFB RID: 98043
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiFSZXNwb25zZS9EYXRpbmdJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l", "dBohQ29tbW9ucy9EYXRpbmdFcGlzb2RlREJJbmZvLnByb3RvGidDb21tb25z", "L0RhdGluZ01lc3NhZ2VDaG9pY2VEQkluZm8ucHJvdG8aJUNvbW1vbnMvRGF0", "aW5nTWVzc2FnZVJld2FyZEluZm8ucHJvdG8ixgEKEkRhdGluZ0luZm9SZXNw", "b25zZRI0CgxlcGlzb2RlX2luZm8YASADKAsyHi5wcm90by5uZXQuRGF0aW5n", "RXBpc29kZURCSW5mbxJBChNtZXNzYWdlX2Nob2ljZV9pbmZvGAIgAygLMiQu", "cHJvdG8ubmV0LkRhdGluZ01lc3NhZ2VDaG9pY2VEQkluZm8SNwoLcmV3YXJk", "X2luZm8YAyADKAsyIi5wcm90by5uZXQuRGF0aW5nTWVzc2FnZVJld2FyZElu", "Zm9iBnByb3RvMw==" })), new FileDescriptor[]
		{
			DatingEpisodeDBInfoReflection.Descriptor,
			DatingMessageChoiceDBInfoReflection.Descriptor,
			DatingMessageRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DatingInfoResponse), DatingInfoResponse.Parser, new string[] { "EpisodeInfo", "MessageChoiceInfo", "RewardInfo" }, null, null, null, null)
		}));
	}
}
