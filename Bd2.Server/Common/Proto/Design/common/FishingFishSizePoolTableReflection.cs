using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C87 RID: 31879
	public static class FishingFishSizePoolTableReflection
	{
		// Token: 0x170111ED RID: 70125
		// (get) Token: 0x06046BF0 RID: 289776 RVA: 0x011349D3 File Offset: 0x01132BD3
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingFishSizePoolTableReflection.descriptor;
			}
		}

		// Token: 0x0402EA8E RID: 191118
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Cjljb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nRmlzaFNpemVQ", "b29sVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24idAoYRmlzaGlu", "Z0Zpc2hTaXplUG9vbFRhYmxlEhEKCWJ1ZmZWYWx1ZRgBIAEoBRIKCgJpZBgC", "IAEoBRIUCgxtYXhTaXplUmF0aW8YAyADKAUSFAoMbWluU2l6ZVJhdGlvGAQg", "AygFEg0KBXJhdGlvGAUgAygFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoV", "Li9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIG", "cHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingFishSizePoolTable), FishingFishSizePoolTable.Parser, new string[] { "BuffValue", "Id", "MaxSizeRatio", "MinSizeRatio", "Ratio" }, null, null, null, null)
		}));
	}
}
