using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C6F RID: 31855
	public static class FishingBoatTableReflection
	{
		// Token: 0x17011172 RID: 70002
		// (get) Token: 0x06046A92 RID: 289426 RVA: 0x0112F50F File Offset: 0x0112D70F
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingBoatTableReflection.descriptor;
			}
		}

		// Token: 0x0402E9B3 RID: 190899
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQm9hdFRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIscBChBGaXNoaW5nQm9hdFRh", "YmxlEhcKD2JvYXRCdWZmR3JvdXBJZBgBIAMoBRIRCgljb3N0Q291bnQYAiAB", "KAUSDgoGY29zdElkGAMgASgFEhAKCGNvc3RUeXBlGAQgASgFEhAKCGRlc2ln", "bklkGAUgAygFEhkKEWZpc2hUcmFwRnJlcXVlbmN5GAYgASgFEhUKDWZpc2hU", "cmFwTGV2ZWwYByABKAUSCgoCaWQYCCABKAUSFQoNbXVsdGlDYXBhY2l0eRgJ", "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu", "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingBoatTable), FishingBoatTable.Parser, new string[] { "BoatBuffGroupId", "CostCount", "CostId", "CostType", "DesignId", "FishTrapFrequency", "FishTrapLevel", "Id", "MultiCapacity" }, null, null, null, null)
		}));
	}
}
