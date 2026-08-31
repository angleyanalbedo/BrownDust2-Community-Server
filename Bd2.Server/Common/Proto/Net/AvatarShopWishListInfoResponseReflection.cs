using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004FA4 RID: 20388
	public static class AvatarShopWishListInfoResponseReflection
	{
		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x060217D3 RID: 137171 RVA: 0x008A245C File Offset: 0x008A065C
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarShopWishListInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017A5E RID: 96862
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9BdmF0YXJTaG9wV2lzaExpc3RJbmZvUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldCIxCh5BdmF0YXJTaG9wV2lzaExpc3RJbmZvUmVzcG9u" + "c2USDwoHc2hvcF9pZBgBIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarShopWishListInfoResponse), AvatarShopWishListInfoResponse.Parser, new string[] { "ShopId" }, null, null, null, null)
		}));
	}
}
