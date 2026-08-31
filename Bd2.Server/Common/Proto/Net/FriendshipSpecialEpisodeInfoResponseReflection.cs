using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052B2 RID: 21170
	public static class FriendshipSpecialEpisodeInfoResponseReflection
	{
		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x060232B9 RID: 144057 RVA: 0x008E1EE2 File Offset: 0x008E00E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018479 RID: 99449
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjNSZXNwb25zZS9GcmllbmRzaGlwU3BlY2lhbEVwaXNvZGVJbmZvUmVzcG9u", "c2UucHJvdG8SCXByb3RvLm5ldBosQ29tbW9ucy9GcmllbmRzaGlwU3BlY2lh", "bEVwaXNvZGVEQkluZm8ucHJvdG8iXwokRnJpZW5kc2hpcFNwZWNpYWxFcGlz", "b2RlSW5mb1Jlc3BvbnNlEjcKBGluZm8YASADKAsyKS5wcm90by5uZXQuRnJp", "ZW5kc2hpcFNwZWNpYWxFcGlzb2RlREJJbmZvYgZwcm90bzM=" })), new FileDescriptor[] { FriendshipSpecialEpisodeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipSpecialEpisodeInfoResponse), FriendshipSpecialEpisodeInfoResponse.Parser, new string[] { "Info" }, null, null, null, null)
		}));
	}
}
