using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C84 RID: 31876
	public static class FishingFishPoolTableReflection
	{
		// Token: 0x170111E5 RID: 70117
		// (get) Token: 0x06046BD4 RID: 289748 RVA: 0x01134509 File Offset: 0x01132709
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingFishPoolTableReflection.descriptor;
			}
		}

		// Token: 0x0402EA80 RID: 191104
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjVjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nRmlzaFBvb2xU", "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJSChRGaXNoaW5nRmlz", "aFBvb2xUYWJsZRIOCgZmaXNoSWQYASADKAUSDwoHZ3JvdXBJZBgCIAEoBRIK", "CgJpZBgDIAEoBRINCgVyYXRpbxgEIAMoBUJEQhNQcm90by5EZXNpZ24uY29t", "bW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5j", "b21tb25iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingFishPoolTable), FishingFishPoolTable.Parser, new string[] { "FishId", "GroupId", "Id", "Ratio" }, null, null, null, null)
		}));
	}
}
