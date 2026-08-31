using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050F7 RID: 20727
	public static class DeckCostumeSettingInfoResponseReflection
	{
		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x060223D8 RID: 140248 RVA: 0x008C0659 File Offset: 0x008BE859
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017F30 RID: 98096
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ci1SZXNwb25zZS9EZWNrQ29zdHVtZVNldHRpbmdJbmZvUmVzcG9uc2UucHJv", "dG8SCXByb3RvLm5ldBomQ29tbW9ucy9EZWNrQ29zdHVtZVNldHRpbmdEQklu", "Zm8ucHJvdG8iYwoeRGVja0Nvc3R1bWVTZXR0aW5nSW5mb1Jlc3BvbnNlEkEK", "FGNvc3R1bWVfc2V0dGluZ19pbmZvGAEgAygLMiMucHJvdG8ubmV0LkRlY2tD", "b3N0dW1lU2V0dGluZ0RCSW5mb2IGcHJvdG8z" })), new FileDescriptor[] { DeckCostumeSettingDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeckCostumeSettingInfoResponse), DeckCostumeSettingInfoResponse.Parser, new string[] { "CostumeSettingInfo" }, null, null, null, null)
		}));
	}
}
