using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004F98 RID: 20376
	public static class AvatarInfoResponseReflection
	{
		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06021774 RID: 137076 RVA: 0x008A197F File Offset: 0x0089FB7F
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017A45 RID: 96837
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiFSZXNwb25zZS9BdmF0YXJJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l", "dBodQ29tbW9ucy9BdmF0YXJVc2VEQkluZm8ucHJvdG8aGENvbW1vbnMvSXRl", "bURCSW5mby5wcm90byJzChJBdmF0YXJJbmZvUmVzcG9uc2USMwoPYXZhdGFy", "X3VzZV9pbmZvGAEgASgLMhoucHJvdG8ubmV0LkF2YXRhclVzZURCSW5mbxIo", "CglpdGVtX2luZm8YAiADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJv", "dG8z" })), new FileDescriptor[]
		{
			AvatarUseDBInfoReflection.Descriptor,
			ItemDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarInfoResponse), AvatarInfoResponse.Parser, new string[] { "AvatarUseInfo", "ItemInfo" }, null, null, null, null)
		}));
	}
}
