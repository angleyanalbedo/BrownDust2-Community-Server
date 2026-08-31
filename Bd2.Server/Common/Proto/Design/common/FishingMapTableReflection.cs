using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C9C RID: 31900
	public static class FishingMapTableReflection
	{
		// Token: 0x17011248 RID: 70216
		// (get) Token: 0x06046D01 RID: 290049 RVA: 0x0113868E File Offset: 0x0113688E
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingMapTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB2F RID: 191279
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjBjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nTWFwVGFibGUu", "cHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iewoPRmlzaGluZ01hcFRhYmxl", "EhcKD2Zpc2hQb29sR3JvdXBJZBgBIAEoBRIPCgdncm91cElkGAIgASgFEgoK", "AmlkGAMgASgFEhIKCm1haW5VSU5hbWUYBCABKAkSDQoFbWFwSWQYBSABKAUS", "DwoHbWFwVHlwZRgGIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v", "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy", "b3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingMapTable), FishingMapTable.Parser, new string[] { "FishPoolGroupId", "GroupId", "Id", "MainUIName", "MapId", "MapType" }, null, null, null, null)
		}));
	}
}
