using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004633 RID: 17971
	public static class MiniEventHubDBInfoReflection
	{
		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0601C1AD RID: 115117 RVA: 0x007E2FA8 File Offset: 0x007E11A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniEventHubDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015912 RID: 88338
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiBDb21tb25zL01pbmlFdmVudEh1YkRCSW5mby5wcm90bxIJcHJvdG8ubmV0", "GiRDb21tb25zL01pbmlFdmVudEh1YlNsb3REQkluZm8ucHJvdG8ipAEKEk1p", "bmlFdmVudEh1YkRCSW5mbxILCgN1aWQYASABKAUSDgoGaHViX2lkGAIgASgF", "EhIKCnN0YXJ0X3RpbWUYAyABKAMSFQoNcGxheV9lbmRfdGltZRgEIAEoAxIQ", "CghlbmRfdGltZRgFIAEoAxI0CglzbG90X2luZm8YBiADKAsyIS5wcm90by5u", "ZXQuTWluaUV2ZW50SHViU2xvdERCSW5mb2IGcHJvdG8z" })), new FileDescriptor[] { MiniEventHubSlotDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniEventHubDBInfo), MiniEventHubDBInfo.Parser, new string[] { "Uid", "HubId", "StartTime", "PlayEndTime", "EndTime", "SlotInfo" }, null, null, null, null)
		}));
	}
}
