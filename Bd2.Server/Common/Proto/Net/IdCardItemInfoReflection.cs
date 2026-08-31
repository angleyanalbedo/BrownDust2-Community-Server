using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045EA RID: 17898
	public static class IdCardItemInfoReflection
	{
		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0601BECB RID: 114379 RVA: 0x007DB2F2 File Offset: 0x007D94F2
		public static FileDescriptor Descriptor
		{
			get
			{
				return IdCardItemInfoReflection.descriptor;
			}
		}

		// Token: 0x040157D1 RID: 88017
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "ChxDb21tb25zL0lkQ2FyZEl0ZW1JbmZvLnByb3RvEglwcm90by5uZXQihAEK", "DklkQ2FyZEl0ZW1JbmZvEhMKC2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIg", "ASgFEgkKAXgYAyABKAUSCQoBeRgEIAEoBRIOCgZyb3RhdGUYBSABKAISDQoF", "c2NhbGUYBiABKAISDQoFbGF5ZXIYByABKAUSDQoFY29sb3IYCCABKAliBnBy", "b3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IdCardItemInfo), IdCardItemInfo.Parser, new string[] { "InvenIndex", "Id", "X", "Y", "Rotate", "Scale", "Layer", "Color" }, null, null, null, null)
		}));
	}
}
