using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005231 RID: 21041
	public static class FireWorksInfoResponseReflection
	{
		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x06022E8D RID: 142989 RVA: 0x008D9B2F File Offset: 0x008D7D2F
		public static FileDescriptor Descriptor
		{
			get
			{
				return FireWorksInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401832F RID: 99119
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9GaXJlV29ya3NJbmZvUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldCIyChVGaXJlV29ya3NJbmZvUmVzcG9uc2USGQoRcmV3YXJkZWRfZ3Jv" + "dXBfaWQYASADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FireWorksInfoResponse), FireWorksInfoResponse.Parser, new string[] { "RewardedGroupId" }, null, null, null, null)
		}));
	}
}
