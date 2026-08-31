using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C72 RID: 31858
	public static class FishingBuffTableReflection
	{
		// Token: 0x17011180 RID: 70016
		// (get) Token: 0x06046AB9 RID: 289465 RVA: 0x0112FD64 File Offset: 0x0112DF64
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingBuffTableReflection.descriptor;
			}
		}

		// Token: 0x0402E9CB RID: 190923
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQnVmZlRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIm0KEEZpc2hpbmdCdWZmVGFi", "bGUSFAoMYnVmZkR1cmF0aW9uGAEgASgFEhAKCGJ1ZmZUeXBlGAIgASgFEhEK", "CWJ1ZmZWYWx1ZRgDIAEoARIKCgJpZBgEIAEoBRISCgpuYW1lVGV4dElkGAUg", "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u", "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingBuffTable), FishingBuffTable.Parser, new string[] { "BuffDuration", "BuffType", "BuffValue", "Id", "NameTextId" }, null, null, null, null)
		}));
	}
}
