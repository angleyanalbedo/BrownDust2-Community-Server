using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052AF RID: 21167
	public static class FriendshipSpecialEpisodeClearResponseReflection
	{
		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x0602329F RID: 144031 RVA: 0x008E1AE8 File Offset: 0x008DFCE8
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearResponseReflection.descriptor;
			}
		}

		// Token: 0x04018471 RID: 99441
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjRSZXNwb25zZS9GcmllbmRzaGlwU3BlY2lhbEVwaXNvZGVDbGVhclJlc3Bv", "bnNlLnByb3RvEglwcm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVu", "ZGxlLnByb3RvGixDb21tb25zL0ZyaWVuZHNoaXBTcGVjaWFsRXBpc29kZURC", "SW5mby5wcm90byKhAQolRnJpZW5kc2hpcFNwZWNpYWxFcGlzb2RlQ2xlYXJS", "ZXNwb25zZRI5ChJyZXdhcmRfaW5mb19idW5kbGUYASABKAsyHS5wcm90by5u", "ZXQuUmV3YXJkREJJbmZvQnVuZGxlEj0KCmNsZWFyX2luZm8YAiABKAsyKS5w", "cm90by5uZXQuRnJpZW5kc2hpcFNwZWNpYWxFcGlzb2RlREJJbmZvYgZwcm90", "bzM=" })), new FileDescriptor[]
		{
			RewardDBInfoBundleReflection.Descriptor,
			FriendshipSpecialEpisodeDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipSpecialEpisodeClearResponse), FriendshipSpecialEpisodeClearResponse.Parser, new string[] { "RewardInfoBundle", "ClearInfo" }, null, null, null, null)
		}));
	}
}
