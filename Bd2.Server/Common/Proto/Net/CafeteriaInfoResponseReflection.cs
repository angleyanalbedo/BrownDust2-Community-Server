using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004FDC RID: 20444
	public static class CafeteriaInfoResponseReflection
	{
		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x06021A71 RID: 137841 RVA: 0x008ABF57 File Offset: 0x008AA157
		public static FileDescriptor Descriptor
		{
			get
			{
				return CafeteriaInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017BE3 RID: 97251
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiRSZXNwb25zZS9DYWZldGVyaWFJbmZvUmVzcG9uc2UucHJvdG8SCXByb3Rv", "Lm5ldBodQ29tbW9ucy9DYWZldGVyaWFEQkluZm8ucHJvdG8aJUNvbW1vbnMv", "Q2FmZXRlcmlhRmFjaWxpdHlEQkluZm8ucHJvdG8aLENvbW1vbnMvQ2FmZXRl", "cmlhUGFydFRpbWVNYW5hZ2VyREJJbmZvLnByb3RvItEBChVDYWZldGVyaWFJ", "bmZvUmVzcG9uc2USMgoOY2FmZXRlcmlhX2luZm8YASABKAsyGi5wcm90by5u", "ZXQuQ2FmZXRlcmlhREJJbmZvEjkKDWZhY2lsaXR5X2luZm8YAiADKAsyIi5w", "cm90by5uZXQuQ2FmZXRlcmlhRmFjaWxpdHlEQkluZm8SSQoWcGFydF90aW1l", "X21hbmFnZXJfaW5mbxgDIAMoCzIpLnByb3RvLm5ldC5DYWZldGVyaWFQYXJ0", "VGltZU1hbmFnZXJEQkluZm9iBnByb3RvMw==" })), new FileDescriptor[]
		{
			CafeteriaDBInfoReflection.Descriptor,
			CafeteriaFacilityDBInfoReflection.Descriptor,
			CafeteriaPartTimeManagerDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CafeteriaInfoResponse), CafeteriaInfoResponse.Parser, new string[] { "CafeteriaInfo", "FacilityInfo", "PartTimeManagerInfo" }, null, null, null, null)
		}));
	}
}
