using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045FD RID: 17917
	public static class LifeCharLevelDBInfoReflection
	{
		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0601BF8B RID: 114571 RVA: 0x007DD3A4 File Offset: 0x007DB5A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeCharLevelDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015824 RID: 88100
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiFDb21tb25zL0xpZmVDaGFyTGV2ZWxEQkluZm8ucHJvdG8SCXByb3RvLm5l", "dCKXAQoTTGlmZUNoYXJMZXZlbERCSW5mbxIVCg1sb2dnaW5nX2xldmVsGAEg", "ASgFEhMKC2xvZ2dpbmdfZXhwGAIgASgFEhQKDG1pbmluZ19sZXZlbBgDIAEo", "BRISCgptaW5pbmdfZXhwGAQgASgFEhUKDWZhcm1pbmdfbGV2ZWwYBSABKAUS", "EwoLZmFybWluZ19leHAYBiABKAViBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeCharLevelDBInfo), LifeCharLevelDBInfo.Parser, new string[] { "LoggingLevel", "LoggingExp", "MiningLevel", "MiningExp", "FarmingLevel", "FarmingExp" }, null, null, null, null)
		}));
	}
}
