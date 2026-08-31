using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005255 RID: 21077
	public static class FishingCollectionInfoResponseReflection
	{
		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x06022FAE RID: 143278 RVA: 0x008DBAA0 File Offset: 0x008D9CA0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingCollectionInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401837A RID: 99194
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CixSZXNwb25zZS9GaXNoaW5nQ29sbGVjdGlvbkluZm9SZXNwb25zZS5wcm90", "bxIJcHJvdG8ubmV0GiVDb21tb25zL0Zpc2hpbmdDb2xsZWN0aW9uREJJbmZv", "LnByb3RvIlwKHUZpc2hpbmdDb2xsZWN0aW9uSW5mb1Jlc3BvbnNlEjsKD2Nv", "bGxlY3Rpb25faW5mbxgBIAMoCzIiLnByb3RvLm5ldC5GaXNoaW5nQ29sbGVj", "dGlvbkRCSW5mb2IGcHJvdG8z" })), new FileDescriptor[] { FishingCollectionDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingCollectionInfoResponse), FishingCollectionInfoResponse.Parser, new string[] { "CollectionInfo" }, null, null, null, null)
		}));
	}
}
