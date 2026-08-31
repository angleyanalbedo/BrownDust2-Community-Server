using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052A6 RID: 21158
	public static class FriendshipCounselingResponseReflection
	{
		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0602324D RID: 143949 RVA: 0x008E0DA4 File Offset: 0x008DEFA4
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipCounselingResponseReflection.descriptor;
			}
		}

		// Token: 0x04018451 RID: 99409
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CitSZXNwb25zZS9GcmllbmRzaGlwQ291bnNlbGluZ1Jlc3BvbnNlLnByb3Rv", "Eglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3Rv", "Gh5Db21tb25zL0ZyaWVuZHNoaXBEQkluZm8ucHJvdG8itwEKHEZyaWVuZHNo", "aXBDb3Vuc2VsaW5nUmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxlGAEg", "ASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRI0Cg9mcmllbmRz", "aGlwX2luZm8YAiABKAsyGy5wcm90by5uZXQuRnJpZW5kc2hpcERCSW5mbxIS", "Cgppc19jb3JyZWN0GAMgASgIEhIKCmdhaW5lZF9leHAYBCABKAViBnByb3Rv", "Mw==" })), new FileDescriptor[]
		{
			RewardDBInfoBundleReflection.Descriptor,
			FriendshipDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipCounselingResponse), FriendshipCounselingResponse.Parser, new string[] { "RewardInfoBundle", "FriendshipInfo", "IsCorrect", "GainedExp" }, null, null, null, null)
		}));
	}
}
