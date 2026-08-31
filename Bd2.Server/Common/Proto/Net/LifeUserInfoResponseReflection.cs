using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200541A RID: 21530
	public static class LifeUserInfoResponseReflection
	{
		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06023E5B RID: 147035 RVA: 0x008F940F File Offset: 0x008F760F
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeUserInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401883C RID: 100412
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiNSZXNwb25zZS9MaWZlVXNlckluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u", "bmV0GhxDb21tb25zL0xpZmVVc2VyREJJbmZvLnByb3RvGh9Db21tb25zL0xp", "ZmVDaXRpemVuREJJbmZvLnByb3RvGh5Db21tb25zL0xpZmVIZWxwZXJEQklu", "Zm8ucHJvdG8itAEKFExpZmVVc2VySW5mb1Jlc3BvbnNlEjEKDmxpZmVfdXNl", "cl9pbmZvGAIgASgLMhkucHJvdG8ubmV0LkxpZmVVc2VyREJJbmZvEjcKEWxp", "ZmVfY2l0aXplbl9saXN0GAMgAygLMhwucHJvdG8ubmV0LkxpZmVDaXRpemVu", "REJJbmZvEjAKC2hlbHBlcl9pbmZvGAQgAygLMhsucHJvdG8ubmV0LkxpZmVI", "ZWxwZXJEQkluZm9iBnByb3RvMw==" })), new FileDescriptor[]
		{
			LifeUserDBInfoReflection.Descriptor,
			LifeCitizenDBInfoReflection.Descriptor,
			LifeHelperDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeUserInfoResponse), LifeUserInfoResponse.Parser, new string[] { "LifeUserInfo", "LifeCitizenList", "HelperInfo" }, null, null, null, null)
		}));
	}
}
