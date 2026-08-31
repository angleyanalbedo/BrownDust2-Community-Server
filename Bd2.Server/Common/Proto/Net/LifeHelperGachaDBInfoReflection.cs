using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200460F RID: 17935
	public static class LifeHelperGachaDBInfoReflection
	{
		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0601C047 RID: 114759 RVA: 0x007DF33F File Offset: 0x007DD53F
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeHelperGachaDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015874 RID: 88180
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiNDb21tb25zL0xpZmVIZWxwZXJHYWNoYURCSW5mby5wcm90bxIJcHJvdG8u", "bmV0Gh5Db21tb25zL0xpZmVIZWxwZXJEQkluZm8ucHJvdG8iWwoVTGlmZUhl", "bHBlckdhY2hhREJJbmZvEhYKDmhlbHBlcl9zbG90X2lkGAEgASgFEioKBWdh", "Y2hhGAIgAygLMhsucHJvdG8ubmV0LkxpZmVIZWxwZXJEQkluZm9iBnByb3Rv", "Mw==" })), new FileDescriptor[] { LifeHelperDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeHelperGachaDBInfo), LifeHelperGachaDBInfo.Parser, new string[] { "HelperSlotId", "Gacha" }, null, null, null, null)
		}));
	}
}
