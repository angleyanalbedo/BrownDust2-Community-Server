using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004442 RID: 17474
	public static class DeckCostumeSettingDBInfoReflection
	{
		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0601B412 RID: 111634 RVA: 0x007BB587 File Offset: 0x007B9787
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014D5B RID: 85339
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiZDb21tb25zL0RlY2tDb3N0dW1lU2V0dGluZ0RCSW5mby5wcm90bxIJcHJv", "dG8ubmV0Im8KGERlY2tDb3N0dW1lU2V0dGluZ0RCSW5mbxIYChBjaGFyX2lu", "dmVuX2luZGV4GAEgASgDEjkKC2Nvc3R1bWVfc2VxGAIgAygLMiQucHJvdG8u", "bmV0LkRlY2tDb3N0dW1lU2V0dGluZ1NlcUluZm8iTQoZRGVja0Nvc3R1bWVT", "ZXR0aW5nU2VxSW5mbxIbChNjb3N0dW1lX2ludmVuX2luZGV4GAEgASgDEhMK", "C2J1cnN0X2xldmVsGAIgASgFYgZwcm90bzM=" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeckCostumeSettingDBInfo), DeckCostumeSettingDBInfo.Parser, new string[] { "CharInvenIndex", "CostumeSeq" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(DeckCostumeSettingSeqInfo), DeckCostumeSettingSeqInfo.Parser, new string[] { "CostumeInvenIndex", "BurstLevel" }, null, null, null, null)
		}));
	}
}
