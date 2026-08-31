using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052AC RID: 21164
	public static class FriendshipInfoResponseReflection
	{
		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x06023287 RID: 144007 RVA: 0x008E178D File Offset: 0x008DF98D
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018467 RID: 99431
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiVSZXNwb25zZS9GcmllbmRzaGlwSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90", "by5uZXQaHkNvbW1vbnMvRnJpZW5kc2hpcERCSW5mby5wcm90bxoeQ29tbW9u", "cy9Db3Vuc2VsaW5nREJJbmZvLnByb3RvIoQBChZGcmllbmRzaGlwSW5mb1Jl", "c3BvbnNlEjQKD2ZyaWVuZHNoaXBfaW5mbxgBIAMoCzIbLnByb3RvLm5ldC5G", "cmllbmRzaGlwREJJbmZvEjQKD2NvdW5zZWxpbmdfaW5mbxgCIAMoCzIbLnBy", "b3RvLm5ldC5Db3Vuc2VsaW5nREJJbmZvYgZwcm90bzM=" })), new FileDescriptor[]
		{
			FriendshipDBInfoReflection.Descriptor,
			CounselingDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipInfoResponse), FriendshipInfoResponse.Parser, new string[] { "FriendshipInfo", "CounselingInfo" }, null, null, null, null)
		}));
	}
}
