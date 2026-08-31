using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004618 RID: 17944
	public static class LifeToolDBInfoReflection
	{
		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0601C096 RID: 114838 RVA: 0x007DFE66 File Offset: 0x007DE066
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeToolDBInfoReflection.descriptor;
			}
		}

		// Token: 0x0401588F RID: 88207
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL0xpZmVUb29sREJJbmZvLnByb3RvEglwcm90by5uZXQiLgoO" + "TGlmZVRvb2xEQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSCgoCaWQYAiABKAVi" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeToolDBInfo), LifeToolDBInfo.Parser, new string[] { "GroupId", "Id" }, null, null, null, null)
		}));
	}
}
