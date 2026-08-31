using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052A9 RID: 21161
	public static class FriendshipGiftResponseReflection
	{
		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x0602326B RID: 143979 RVA: 0x008E12F1 File Offset: 0x008DF4F1
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipGiftResponseReflection.descriptor;
			}
		}

		// Token: 0x0401845D RID: 99421
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiVSZXNwb25zZS9GcmllbmRzaGlwR2lmdFJlc3BvbnNlLnByb3RvEglwcm90", "by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvGh5Db21t", "b25zL0ZyaWVuZHNoaXBEQkluZm8ucHJvdG8inQEKFkZyaWVuZHNoaXBHaWZ0", "UmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxlGAEgASgLMh0ucHJvdG8u", "bmV0LlJld2FyZERCSW5mb0J1bmRsZRI0Cg9mcmllbmRzaGlwX2luZm8YAiAB", "KAsyGy5wcm90by5uZXQuRnJpZW5kc2hpcERCSW5mbxISCgpnYWluZWRfZXhw", "GAMgASgFYgZwcm90bzM=" })), new FileDescriptor[]
		{
			RewardDBInfoBundleReflection.Descriptor,
			FriendshipDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipGiftResponse), FriendshipGiftResponse.Parser, new string[] { "RewardInfoBundle", "FriendshipInfo", "GainedExp" }, null, null, null, null)
		}));
	}
}
