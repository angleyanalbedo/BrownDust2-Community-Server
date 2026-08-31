using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200461B RID: 17947
	public static class LifeUserDBInfoReflection
	{
		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0601C0B0 RID: 114864 RVA: 0x007E0183 File Offset: 0x007DE383
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeUserDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015897 RID: 88215
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "ChxDb21tb25zL0xpZmVVc2VyREJJbmZvLnByb3RvEglwcm90by5uZXQaIUNv", "bW1vbnMvTGlmZUNoYXJMZXZlbERCSW5mby5wcm90byKKAQoOTGlmZVVzZXJE", "QkluZm8SEQoJbGlmZV9jb2luGAEgASgFEhUKDWxpZmVfd29ybGRfaWQYAiAB", "KAUSPAoUbGlmZV9jaGFyX2xldmVsX2luZm8YAyABKAsyHi5wcm90by5uZXQu", "TGlmZUNoYXJMZXZlbERCSW5mbxIQCghjaHVua19pZBgEIAMoBWIGcHJvdG8z" })), new FileDescriptor[] { LifeCharLevelDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeUserDBInfo), LifeUserDBInfo.Parser, new string[] { "LifeCoin", "LifeWorldId", "LifeCharLevelInfo", "ChunkId" }, null, null, null, null)
		}));
	}
}
