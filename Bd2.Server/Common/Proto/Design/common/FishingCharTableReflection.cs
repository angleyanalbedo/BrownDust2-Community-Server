using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C7B RID: 31867
	public static class FishingCharTableReflection
	{
		// Token: 0x170111A0 RID: 70048
		// (get) Token: 0x06046B23 RID: 289571 RVA: 0x0113119C File Offset: 0x0112F39C
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingCharTableReflection.descriptor;
			}
		}

		// Token: 0x0402E9FF RID: 190975
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQ2hhclRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIlIKEEZpc2hpbmdDaGFyVGFi", "bGUSCgoCaWQYASABKAUSEgoKbGV2ZWx1cEV4cBgCIAEoBRINCgVwb3dlchgD", "IAEoARIPCgdzdGFtaW5hGAQgASgBQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q", "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v", "bmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingCharTable), FishingCharTable.Parser, new string[] { "Id", "LevelupExp", "Power", "Stamina" }, null, null, null, null)
		}));
	}
}
