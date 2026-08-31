using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C78 RID: 31864
	public static class FishingCastingTableReflection
	{
		// Token: 0x17011198 RID: 70040
		// (get) Token: 0x06046B05 RID: 289541 RVA: 0x01130C97 File Offset: 0x0112EE97
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingCastingTableReflection.descriptor;
			}
		}

		// Token: 0x0402E9F3 RID: 190963
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjRjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQ2FzdGluZ1Rh", "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uImUKE0Zpc2hpbmdDYXN0", "aW5nVGFibGUSDgoGYnVmZklkGAEgASgFEhcKD2VuZEdhdWdlUGVyY2VudBgC", "IAEoARIKCgJpZBgDIAEoBRIZChFzdGFydEdhdWdlUGVyY2VudBgEIAEoAUJE", "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v", "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingCastingTable), FishingCastingTable.Parser, new string[] { "BuffId", "EndGaugePercent", "Id", "StartGaugePercent" }, null, null, null, null)
		}));
	}
}
