using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200457C RID: 17788
	public static class FishingRodDBInfoReflection
	{
		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0601BA0A RID: 113162 RVA: 0x007CD789 File Offset: 0x007CB989
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingRodDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015593 RID: 87443
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0Zpc2hpbmdSb2REQkluZm8ucHJvdG8SCXByb3RvLm5ldCJH" + "ChBGaXNoaW5nUm9kREJJbmZvEhMKC2ludmVuX2luZGV4GAEgASgDEgoKAmlk" + "GAIgASgFEhIKCnRpbWVfdmFsdWUYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingRodDBInfo), FishingRodDBInfo.Parser, new string[] { "InvenIndex", "Id", "TimeValue" }, null, null, null, null)
		}));
	}
}
