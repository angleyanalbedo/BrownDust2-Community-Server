using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004420 RID: 17440
	public static class ColosseumUserBaseInfoReflection
	{
		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0601B2C4 RID: 111300 RVA: 0x007B8196 File Offset: 0x007B6396
		public static FileDescriptor Descriptor
		{
			get
			{
				return ColosseumUserBaseInfoReflection.descriptor;
			}
		}

		// Token: 0x04014CCE RID: 85198
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL0NvbG9zc2V1bVVzZXJCYXNlSW5mby5wcm90bxIJcHJvdG8u" + "bmV0Im0KFUNvbG9zc2V1bVVzZXJCYXNlSW5mbxIKCgJ2cBgBIAEoBRIMCgRy" + "YW5rGAIgASgFEhEKCXdpbl9jb3VudBgDIAEoBRISCgpsb3NlX2NvdW50GAQg" + "ASgFEhMKC3RvcF9wZXJjZW50GAUgASgBYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ColosseumUserBaseInfo), ColosseumUserBaseInfo.Parser, new string[] { "Vp", "Rank", "WinCount", "LoseCount", "TopPercent" }, null, null, null, null)
		}));
	}
}
