using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045E7 RID: 17895
	public static class IdCardInfoReflection
	{
		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0601BEAA RID: 114346 RVA: 0x007DABB4 File Offset: 0x007D8DB4
		public static FileDescriptor Descriptor
		{
			get
			{
				return IdCardInfoReflection.descriptor;
			}
		}

		// Token: 0x040157C0 RID: 88000
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "ChhDb21tb25zL0lkQ2FyZEluZm8ucHJvdG8SCXByb3RvLm5ldBocQ29tbW9u", "cy9JZENhcmRJdGVtSW5mby5wcm90byKNAgoKSWRDYXJkSW5mbxItCgpiYWNr", "Z3JvdW5kGAEgASgLMhkucHJvdG8ubmV0LklkQ2FyZEl0ZW1JbmZvEjEKDnN1", "Yl9iYWNrZ3JvdW5kGAIgASgLMhkucHJvdG8ubmV0LklkQ2FyZEl0ZW1JbmZv", "EjQKEWJhY2tncm91bmRfZWZmZWN0GAMgASgLMhkucHJvdG8ubmV0LklkQ2Fy", "ZEl0ZW1JbmZvEisKCHN0aWNrZXJzGAQgAygLMhkucHJvdG8ubmV0LklkQ2Fy", "ZEl0ZW1JbmZvEioKB215X2luZm8YBSABKAsyGS5wcm90by5uZXQuSWRDYXJk", "SXRlbUluZm8SDgoGcm90YXRlGAYgASgFYgZwcm90bzM=" })), new FileDescriptor[] { IdCardItemInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IdCardInfo), IdCardInfo.Parser, new string[] { "Background", "SubBackground", "BackgroundEffect", "Stickers", "MyInfo", "Rotate" }, null, null, null, null)
		}));
	}
}
