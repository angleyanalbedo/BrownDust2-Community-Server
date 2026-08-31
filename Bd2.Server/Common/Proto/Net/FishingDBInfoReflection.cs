using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200456A RID: 17770
	public static class FishingDBInfoReflection
	{
		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0601B955 RID: 112981 RVA: 0x007CBBF3 File Offset: 0x007C9DF3
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingDBInfoReflection.descriptor;
			}
		}

		// Token: 0x0401554B RID: 87371
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "ChtDb21tb25zL0Zpc2hpbmdEQkluZm8ucHJvdG8SCXByb3RvLm5ldCKPAQoN", "RmlzaGluZ0RCSW5mbxILCgNleHAYASABKAUSDQoFbGV2ZWwYAiABKAUSEgoK", "Ym9hdF9sZXZlbBgDIAEoBRIUCgxib2F0X3NraW5faWQYBCABKAUSGwoTdXNl", "X3JvZF9pbnZlbl9pbmRleBgFIAEoAxIbChNtdWx0aV9hcF9yZXNldF90aW1l", "GAYgASgDYgZwcm90bzM=" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingDBInfo), FishingDBInfo.Parser, new string[] { "Exp", "Level", "BoatLevel", "BoatSkinId", "UseRodInvenIndex", "MultiApResetTime" }, null, null, null, null)
		}));
	}
}
