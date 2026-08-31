using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004439 RID: 17465
	public static class DatingEpisodeDBInfoReflection
	{
		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0601B3B8 RID: 111544 RVA: 0x007BA875 File Offset: 0x007B8A75
		public static FileDescriptor Descriptor
		{
			get
			{
				return DatingEpisodeDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014D38 RID: 85304
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiFDb21tb25zL0RhdGluZ0VwaXNvZGVEQkluZm8ucHJvdG8SCXByb3RvLm5l", "dCKuAQoTRGF0aW5nRXBpc29kZURCSW5mbxIQCghncm91cF9pZBgBIAEoBRIU", "CgxkYXRpbmdfcG9pbnQYAiABKAUSFQoNbGFzdF9jbGVhcl9pZBgDIAEoBRId", "ChVsYXN0X21lc3NhZ2VfZ3JvdXBfaWQYBCABKAUSFwoPbGFzdF9tZXNzYWdl", "X2lkGAUgASgFEiAKGGxhc3RfbWVzc2FnZV91cGRhdGVfdGltZRgGIAEoA2IG", "cHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DatingEpisodeDBInfo), DatingEpisodeDBInfo.Parser, new string[] { "GroupId", "DatingPoint", "LastClearId", "LastMessageGroupId", "LastMessageId", "LastMessageUpdateTime" }, null, null, null, null)
		}));
	}
}
