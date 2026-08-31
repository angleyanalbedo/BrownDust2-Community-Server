using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200545D RID: 21597
	public static class MiniEventHubInfoResponseReflection
	{
		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x060240C0 RID: 147648 RVA: 0x008FEF77 File Offset: 0x008FD177
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniEventHubInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401891B RID: 100635
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CidSZXNwb25zZS9NaW5pRXZlbnRIdWJJbmZvUmVzcG9uc2UucHJvdG8SCXBy", "b3RvLm5ldBogQ29tbW9ucy9NaW5pRXZlbnRIdWJEQkluZm8ucHJvdG8iVgoY", "TWluaUV2ZW50SHViSW5mb1Jlc3BvbnNlEjoKE21pbmlfZXZlbnRfaHViX2lu", "Zm8YASADKAsyHS5wcm90by5uZXQuTWluaUV2ZW50SHViREJJbmZvYgZwcm90", "bzM=" })), new FileDescriptor[] { MiniEventHubDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniEventHubInfoResponse), MiniEventHubInfoResponse.Parser, new string[] { "MiniEventHubInfo" }, null, null, null, null)
		}));
	}
}
